//#define Bench

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace URA_Pokemon
{

    public class Xblood
    {
        #region D�clatations
        // nombres de pok�mons charg�s
        static int nbloaded = 0;
        // liste des pok�mons
        static Pokemon[] _PKlist;
        public Pokemon[] PKlist;
        static SortedDictionary<string, int> _SDPokemon;
        SortedDictionary<string, int> SDPokemon;
        // liste des mouvements
        static Capacite[] _Clist;
        public Capacite[] Clist;
        static SortedDictionary<string, int> _SDCapacite;
        SortedDictionary<string, int> SDCapacite;
        // liste des capacit�s sp�
        public static CapSpe[] CSlist;
        //Tableau des types
        static int[,] _Types;
        public static int[,] Types
        {
            get
            {
                if (_Types == null)
                    FillTypes();
                return _Types;
            }
        }
        //Association des noms aux nombres correspondants
        public static string[] NomsTypes;
        //Tableau des types existants r�element dans le jeu
        public static bool[,] TypesExistants;
        // nombres de branches trouv�es
        public int branches = 0;
        // nombres de feuilles trouv�es
        public int leafs = 0;
        // Agruments pour le thread
        public Pokemon argPokemon;
        public Capacite[] argCapacite;
        // R�sultat du thread
        public Noeud returnNode;
        // Limite la profondeur de recherche
        public int deepness = 0;
        // Record de profondeur
        public int recordmax = 0;
        bool firstmin = true;
        public int recordmin = 0;
        public static bool PKlistisFilled = false;

        public static string CurrentDirectory = "";

        static System.Threading.Mutex muteur = new System.Threading.Mutex();
        #endregion

        public Xblood()
        {
            muteur.WaitOne();
            PKlist = _PKlist;
            Clist = _Clist;
            SDPokemon = _SDPokemon;
            SDCapacite = _SDCapacite;
            muteur.ReleaseMutex();
        }

        #region Les z�venements

        public event EventHandler LeafFound;
        void OnLeafFound(EventArgs e)
        {
            if (LeafFound != null)
                LeafFound(leafs, e);
        }

        public event EventHandler BranchAdded;
        void OnBranchAdded(EventArgs e)
        {
            if (BranchAdded != null)
                BranchAdded(branches, e);
        }

        public event EventHandler Finished;
        void OnFinished(EventArgs e)
        {
            if (Finished != null)
                Finished(returnNode, e);
        }

        public static event EventHandler PokemonAddedtoPKlist;
        static void OnPokemonAddedtoPKlist(EventArgs e)
        {
            if (PokemonAddedtoPKlist != null)
                PokemonAddedtoPKlist(nbloaded, e);
        }

        public static event EventHandler PKlistFull;
        static void OnListFull(EventArgs e)
        {
            if (PKlistFull != null)
                PKlistFull(null, e);
        }

        public static event EventHandler CapaciteAddedtoClist;
        static void OnCapaciteAddedtoClist(EventArgs e)
        {
            if (CapaciteAddedtoClist != null)
                CapaciteAddedtoClist(nbloaded, e);
        }

        public static event EventHandler ClistFull;
        static void OnClistFull(EventArgs e)
        {
            if (ClistFull != null)
                ClistFull(null, e);
        }

        public static event EventHandler CapSpeAddedtoClist;
        static void OnCapSpeAddedtoClist(EventArgs e)
        {
            if (CapSpeAddedtoClist != null)
                CapSpeAddedtoClist(nbloaded, e);
        }

        public static event EventHandler CSlistFull;
        static void OnCSlistFull(EventArgs e)
        {
            if (CSlistFull != null)
                CSlistFull(null, e);
        }

        #endregion

        // D�marre le thread de recherche d'accouplement
        public void StartThread()
        {
            leafs = 0;
            branches = 0;
            recordmax = 0;
            recordmin = 0;
            firstmin = true;
#if Bench
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            returnNode = ConstitueArbre(argPokemon, argCapacite, null, null, 0);
#if Bench
            sw.Stop();
            System.Windows.Forms.MessageBox.Show("total time " + sw.ElapsedMilliseconds.ToString() + " ms");
#endif
            OnFinished(new EventArgs());
        }

        // Remplit la liste statique des pok�mons
        public static void FillPKlist()
        {
            string[] files = Directory.GetFiles(@"DescriptionPokemon\", "*.xml");
            //tableau des pok�mons
            _PKlist = new Pokemon[files.Length];
            //tableau pour copier les pok�mons tri�s
            Pokemon[] sortarray = new Pokemon[files.Length];
            //Dictionnaire pour stocker les pairs nom/index
            Dictionary<string, int> dico = new Dictionary<string, int>(493);

            nbloaded = 0;
            foreach (string file in files)
            {
                _PKlist[nbloaded] = new Pokemon(file, FileType.Description);
                //On remplace l'espace par un underscore sinon seule la premi�re partie est utilis�e
                dico.Add(_PKlist[nbloaded].Nom, nbloaded);
                nbloaded++;

                OnPokemonAddedtoPKlist(new EventArgs());

            }

            //On cr�e un dictionnaire tri� � partir de dico
            _SDPokemon = new SortedDictionary<string, int>(dico);


            //tableau des index tri�s
            int[] sortedindexes = new int[files.Length];
            _SDPokemon.Values.CopyTo(sortedindexes, 0);

            //On bascule les valeurs tri�s dans le tableau inital
            for (int i = 0; i < sortedindexes.Length; i++)
            {
                sortarray[i] = _PKlist[sortedindexes[i]];
                _SDPokemon[sortarray[i].Nom] = i;
            }

            //On r�affecte le bon tableau
            _PKlist = sortarray;

            PKlistisFilled = true;
            OnListFull(new EventArgs());
        }

        // Remplit la liste statique des capacit�s
        public static void FillClist()
        {
            string[] files = Directory.GetFiles(@"DescriptionCapacites\", "*.xml");
            _Clist = new Capacite[files.Length];
            Capacite[] sortarray = new Capacite[files.Length];
            Dictionary<string, int> dico = new Dictionary<string, int>(files.Length);
            nbloaded = 0;
            foreach (string file in files)
            {
                _Clist[nbloaded] = new Capacite(file);
                //On remplace l'espace par un underscore sinon seule la premi�re partie est utilis�e
                dico.Add(_Clist[nbloaded].Nom, nbloaded);
                nbloaded++;
                OnCapaciteAddedtoClist(new EventArgs());
            }

            _SDCapacite = new SortedDictionary<string, int>(dico);

            int[] sortedindexes = new int[files.Length];
            _SDCapacite.Values.CopyTo(sortedindexes, 0);

            for (int i = 0; i < sortedindexes.Length; i++)
            {
                sortarray[i] = _Clist[sortedindexes[i]];
                _SDCapacite[sortarray[i].Nom] = i;
            }

            _Clist = sortarray;
            
            OnClistFull(new EventArgs());
        }

        public static void FillCSlist()
        {
            string[] files = Directory.GetFiles(@"DescriptionCapSpe\", "*.xml");
            CSlist = new CapSpe[files.Length];
            nbloaded = 0;
            foreach (string file in files)
            {
                CSlist[nbloaded] = new CapSpe(file);
                nbloaded++;
                OnCapSpeAddedtoClist(new EventArgs());
            }
            OnCSlistFull(new EventArgs());
        }

        // Remplit le tableau statique des types
        public static void FillTypes()
        {
            /*
            D�finition d'un tableau de faiblesse/r�sistance avec
            0 = neutre
            -2 = peu efficace
            2 = efficace
            7 = immunis�
            Premi�re valeur = attaque
            Deuxi�me valeur = type
            D'o� Tableau(attaque sur type) = Neutre/Faiblesse/R�sistance/Immunit�
            exemple: Tableau(3,2)=2 soit EAU sur FEU = efficace
            */
            _Types = new int[17, 17];
            _Types[0, 0] = 0;
            _Types[0, 1] = 0;
            _Types[0, 2] = 0;
            _Types[0, 3] = 0;
            _Types[0, 4] = 0;
            _Types[0, 5] = 0;
            _Types[0, 6] = 0;
            _Types[0, 7] = 0;
            _Types[0, 8] = 0;
            _Types[0, 9] = 0;
            _Types[0, 10] = 0;
            _Types[0, 11] = 0;
            _Types[0, 12] = -2;
            _Types[0, 13] = 7;
            _Types[0, 14] = 0;
            _Types[0, 15] = 0;
            _Types[0, 16] = -2;
            _Types[1, 0] = 0;
            _Types[1, 1] = -2;
            _Types[1, 2] = -2;
            _Types[1, 3] = 2;
            _Types[1, 4] = 0;
            _Types[1, 5] = 2;
            _Types[1, 6] = 0;
            _Types[1, 7] = 0;
            _Types[1, 8] = 0;
            _Types[1, 9] = 0;
            _Types[1, 10] = 0;
            _Types[1, 11] = 2;
            _Types[1, 12] = -2;
            _Types[1, 13] = 0;
            _Types[1, 14] = -2;
            _Types[1, 15] = 0;
            _Types[1, 16] = 2;
            _Types[2, 0] = 0;
            _Types[2, 1] = 2;
            _Types[2, 2] = -2;
            _Types[2, 3] = -2;
            _Types[2, 4] = 0;
            _Types[2, 5] = 0;
            _Types[2, 6] = 0;
            _Types[2, 7] = 0;
            _Types[2, 8] = 2;
            _Types[2, 9] = 0;
            _Types[2, 10] = 0;
            _Types[2, 11] = 0;
            _Types[2, 12] = 2;
            _Types[2, 13] = 0;
            _Types[2, 14] = -2;
            _Types[2, 15] = 0;
            _Types[2, 16] = 0;
            _Types[3, 0] = 0;
            _Types[3, 1] = -2;
            _Types[3, 2] = 2;
            _Types[3, 3] = -2;
            _Types[3, 4] = 0;
            _Types[3, 5] = 0;
            _Types[3, 6] = 0;
            _Types[3, 7] = -2;
            _Types[3, 8] = 2;
            _Types[3, 9] = -2;
            _Types[3, 10] = 0;
            _Types[3, 11] = -2;
            _Types[3, 12] = 2;
            _Types[3, 13] = 0;
            _Types[3, 14] = -2;
            _Types[3, 15] = 0;
            _Types[3, 16] = -2;
            _Types[4, 0] = 0;
            _Types[4, 1] = 0;
            _Types[4, 2] = 2;
            _Types[4, 3] = -2;
            _Types[4, 4] = -2;
            _Types[4, 5] = 0;
            _Types[4, 6] = 0;
            _Types[4, 7] = 0;
            _Types[4, 8] = 7;
            _Types[4, 9] = 2;
            _Types[4, 10] = 0;
            _Types[4, 11] = 0;
            _Types[4, 12] = 0;
            _Types[4, 13] = 0;
            _Types[4, 14] = -2;
            _Types[4, 15] = 0;
            _Types[4, 16] = 0;
            _Types[5, 0] = 0;
            _Types[5, 1] = -2;
            _Types[5, 2] = -2;
            _Types[5, 3] = 2;
            _Types[5, 4] = 0;
            _Types[5, 5] = -2;
            _Types[5, 6] = 0;
            _Types[5, 7] = 0;
            _Types[5, 8] = 2;
            _Types[5, 9] = 2;
            _Types[5, 10] = 0;
            _Types[5, 11] = 0;
            _Types[5, 12] = 0;
            _Types[5, 13] = 0;
            _Types[5, 14] = 2;
            _Types[5, 15] = 0;
            _Types[5, 16] = -2;
            _Types[6, 0] = 2;
            _Types[6, 1] = 0;
            _Types[6, 2] = 0;
            _Types[6, 3] = 0;
            _Types[6, 4] = 0;
            _Types[6, 5] = 2;
            _Types[6, 6] = 0;
            _Types[6, 7] = -2;
            _Types[6, 8] = 0;
            _Types[6, 9] = -2;
            _Types[6, 10] = -2;
            _Types[6, 11] = -2;
            _Types[6, 12] = 2;
            _Types[6, 13] = 7;
            _Types[6, 14] = 0;
            _Types[6, 15] = 2;
            _Types[6, 16] = 2;
            _Types[7, 0] = 0;
            _Types[7, 1] = 0;
            _Types[7, 2] = 0;
            _Types[7, 3] = 2;
            _Types[7, 4] = 0;
            _Types[7, 5] = 0;
            _Types[7, 6] = 0;
            _Types[7, 7] = -2;
            _Types[7, 8] = -2;
            _Types[7, 9] = 0;
            _Types[7, 10] = 0;
            _Types[7, 11] = 0;
            _Types[7, 12] = -2;
            _Types[7, 13] = -2;
            _Types[7, 14] = 0;
            _Types[7, 15] = 0;
            _Types[7, 16] = 7;
            _Types[8, 0] = 0;
            _Types[8, 1] = 2;
            _Types[8, 2] = 0;
            _Types[8, 3] = -2;
            _Types[8, 4] = 2;
            _Types[8, 5] = 0;
            _Types[8, 6] = 0;
            _Types[8, 7] = 2;
            _Types[8, 8] = 0;
            _Types[8, 9] = 7;
            _Types[8, 10] = 0;
            _Types[8, 11] = -2;
            _Types[8, 12] = 2;
            _Types[8, 13] = 0;
            _Types[8, 14] = 0;
            _Types[8, 15] = 0;
            _Types[8, 16] = 2;
            _Types[9, 0] = 0;
            _Types[9, 1] = 0;
            _Types[9, 2] = 0;
            _Types[9, 3] = 2;
            _Types[9, 4] = -2;
            _Types[9, 5] = 0;
            _Types[9, 6] = 2;
            _Types[9, 7] = 0;
            _Types[9, 8] = 0;
            _Types[9, 9] = 0;
            _Types[9, 10] = 0;
            _Types[9, 11] = 2;
            _Types[9, 12] = -2;
            _Types[9, 13] = 0;
            _Types[9, 14] = 0;
            _Types[9, 15] = 0;
            _Types[9, 16] = -2;
            _Types[10, 0] = 0;
            _Types[10, 1] = 0;
            _Types[10, 2] = 0;
            _Types[10, 3] = 0;
            _Types[10, 4] = 0;
            _Types[10, 5] = 0;
            _Types[10, 6] = 2;
            _Types[10, 7] = 2;
            _Types[10, 8] = 0;
            _Types[10, 9] = 0;
            _Types[10, 10] = -2;
            _Types[10, 11] = 0;
            _Types[10, 12] = 0;
            _Types[10, 13] = 0;
            _Types[10, 14] = 0;
            _Types[10, 15] = 7;
            _Types[10, 16] = -2;
            _Types[11, 0] = 0;
            _Types[11, 1] = -2;
            _Types[11, 2] = 0;
            _Types[11, 3] = 2;
            _Types[11, 4] = 0;
            _Types[11, 5] = 0;
            _Types[11, 6] = -2;
            _Types[11, 7] = -2;
            _Types[11, 8] = 0;
            _Types[11, 9] = -2;
            _Types[11, 10] = 2;
            _Types[11, 11] = 0;
            _Types[11, 12] = 0;
            _Types[11, 13] = -2;
            _Types[11, 14] = 0;
            _Types[11, 15] = 2;
            _Types[11, 16] = -2;
            _Types[12, 0] = 0;
            _Types[12, 1] = 2;
            _Types[12, 2] = 0;
            _Types[12, 3] = 0;
            _Types[12, 4] = 0;
            _Types[12, 5] = 2;
            _Types[12, 6] = -2;
            _Types[12, 7] = 0;
            _Types[12, 8] = -2;
            _Types[12, 9] = 2;
            _Types[12, 10] = 0;
            _Types[12, 11] = 2;
            _Types[12, 12] = 0;
            _Types[12, 13] = 0;
            _Types[12, 14] = 0;
            _Types[12, 15] = 0;
            _Types[12, 16] = -2;
            _Types[13, 0] = 7;
            _Types[13, 1] = 0;
            _Types[13, 2] = 0;
            _Types[13, 3] = 0;
            _Types[13, 4] = 0;
            _Types[13, 5] = 0;
            _Types[13, 6] = 0;
            _Types[13, 7] = 0;
            _Types[13, 8] = 0;
            _Types[13, 9] = 0;
            _Types[13, 10] = 2;
            _Types[13, 11] = 0;
            _Types[13, 12] = 0;
            _Types[13, 13] = 2;
            _Types[13, 14] = 0;
            _Types[13, 15] = -2;
            _Types[13, 16] = -2;
            _Types[14, 0] = 0;
            _Types[14, 1] = 0;
            _Types[14, 2] = 0;
            _Types[14, 3] = 0;
            _Types[14, 4] = 0;
            _Types[14, 5] = 0;
            _Types[14, 6] = 0;
            _Types[14, 7] = 0;
            _Types[14, 8] = 0;
            _Types[14, 9] = 0;
            _Types[14, 10] = 0;
            _Types[14, 11] = 0;
            _Types[14, 12] = 0;
            _Types[14, 13] = 0;
            _Types[14, 14] = 2;
            _Types[14, 15] = 0;
            _Types[14, 16] = -2;
            _Types[15, 0] = 0;
            _Types[15, 1] = 0;
            _Types[15, 2] = 0;
            _Types[15, 3] = 0;
            _Types[15, 4] = 0;
            _Types[15, 5] = 0;
            _Types[15, 6] = -2;
            _Types[15, 7] = 0;
            _Types[15, 8] = 0;
            _Types[15, 9] = 0;
            _Types[15, 10] = 2;
            _Types[15, 11] = 0;
            _Types[15, 12] = 0;
            _Types[15, 13] = 2;
            _Types[15, 14] = 0;
            _Types[15, 15] = -2;
            _Types[15, 16] = -2;
            _Types[16, 0] = 0;
            _Types[16, 1] = -2;
            _Types[16, 2] = -2;
            _Types[16, 3] = 0;
            _Types[16, 4] = -2;
            _Types[16, 5] = 2;
            _Types[16, 6] = 0;
            _Types[16, 7] = 0;
            _Types[16, 8] = 0;
            _Types[16, 9] = 0;
            _Types[16, 10] = 0;
            _Types[16, 11] = 0;
            _Types[16, 12] = 2;
            _Types[16, 13] = 0;
            _Types[16, 14] = 0;
            _Types[16, 15] = 0;
            _Types[16, 16] = -2;

            NomsTypes = new string[17];
            NomsTypes[0] = "NORMAL";
            NomsTypes[1] = "FEU";
            NomsTypes[2] = "EAU";
            NomsTypes[3] = "PLANTE";
            NomsTypes[4] = "ELECTRIK";
            NomsTypes[5] = "GLACE";
            NomsTypes[6] = "COMBAT";
            NomsTypes[7] = "POISON";
            NomsTypes[8] = "SOL";
            NomsTypes[9] = "VOL";
            NomsTypes[10] = "PSY";
            NomsTypes[11] = "INSECTE";
            NomsTypes[12] = "ROCHE";
            NomsTypes[13] = "SPECTRE";
            NomsTypes[14] = "DRAGON";
            NomsTypes[15] = "TENEBRES";
            NomsTypes[16] = "ACIER";
        }

        public static void FillTypesExistants()
        {
            TypesExistants = new bool[18, 18];

            foreach (Pokemon p in _PKlist)
            {
                TypesExistants[(int)p.Type1, (int)p.Type2] = true;
            }
        }

        // trie les capacit�s par niveau d'apprentissage
        public static Capacite[] SortLevel(Capacite[] tableau)
        {
            Capacite[] tableau2 = new Capacite[tableau.Length];
            for (int i = 0; i < tableau.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < tableau.Length; j++)
                {
                    if (tableau[i].NiveauApprentissage > tableau[j].NiveauApprentissage)
                        c++;
                }

                while (tableau2[c] != null && tableau2[c].NiveauApprentissage == tableau[i].NiveauApprentissage)
                    c++;

                tableau2[c] = tableau[i];
            }
            return tableau2;
        }

        // trie les capacit�s par num�ro de CT
        public static Capacite[] SortCT(Capacite[] tableau)
        {
            Capacite[] tableau2 = new Capacite[tableau.Length];
            for (int i = 0; i < tableau.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < tableau.Length; j++)
                {
                    if (tableau[i].numCT > tableau[j].numCT)
                        c++;
                }

                while (tableau2[c] != null && tableau2[c].numCT == tableau[i].numCT)
                    c++;

                tableau2[c] = tableau[i];
            }
            return tableau2;
        }

        // trie les capacit�s par num�ro de CS
        public static Capacite[] SortCS(Capacite[] tableau)
        {
            Capacite[] tableau2 = new Capacite[tableau.Length];
            for (int i = 0; i < tableau.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < tableau.Length; j++)
                {
                    if (tableau[i].numCS > tableau[j].numCS)
                        c++;
                }

                while (tableau2[c] != null && tableau2[c].numCS == tableau[i].numCS)
                    c++;

                tableau2[c] = tableau[i];
            }
            return tableau2;
        }

        // compl�te les informations d'une liste de capacit�s dans un nouveau tableau
        public static Capacite[] CompleteAClist(Capacite[] tab)
        {
            Capacite[] newtab = new Capacite[tab.Length];
            for (int i = 0; i < tab.Length; i++)
                newtab[i] = GetCapacite(tab[i]);
            return newtab;
        }

        // optient toutes les informations sur une capacit� avec un objet Capacite
        public static Capacite GetCapacite(Capacite src)
        {
            //foreach (Capacite c in _Clist)
            //{
            //    if (c.Nom == src.Nom)
            //        return c;
            //}
            if (src != null)
                return GetCapacite(src.Nom);
            else
                return null;
        }

        // optient toutes les informations sur une capacit� gr�ce � son nom
        public static Capacite GetCapacite(string nom)
        {
            //foreach (Capacite c in _Clist)
            //{
            //    if (c.Nom == nom)
            //        return c;
            //}
            if (!string.IsNullOrEmpty(nom))
            {
                int i;

                if (_SDCapacite.TryGetValue(nom, out i))
                    return _Clist[i];
            }
            return null;
        }

        public static CapSpe GetCapSpe(string nom)
        {
            if (!string.IsNullOrEmpty(nom))
            {
                foreach (CapSpe c in CSlist)
                {
                    if (c.nom == nom)
                        return c;
                }
            }
            return null;
        }

        // optient toutes les informations sur un pok�mon gr�ce � son nom
        public Pokemon GetPok�mon(string Nom)
        {
            //foreach (Pokemon p in PKlist)
            //{
            //    if (p.Nom == Nom)
            //        return p;
            //}

            if (!string.IsNullOrEmpty(Nom))
            {
                int i;
                if (SDPokemon.TryGetValue(Nom, out i))
                    return PKlist[i];
            }
            return null;
        }

        static Pokemon _GetPok�mon(string Nom)
        {
            //foreach (Pokemon p in _PKlist)
            //{
            //    if (p.Nom == Nom)
            //        return p;
            //}
            if (!string.IsNullOrEmpty(Nom))
            {
                int i;
                if (_SDPokemon.TryGetValue(Nom, out i))
                    return _PKlist[i];
            }
            return null;
        }


        /* parcourt tous les pok�mons compatibles d'un pok�mon, retourne l'arbre trouv�
         *
         * Fonction r�cursive; prend en param�tres le pok�mon auquel on veut donner les capacit�s,
         * lesdites capacit�s, un argument noeud parent mit � null � l'appel de la fonction servant dans la r�cursion
         * pour chainer les pok�mons, le nom d'un pok�mon interm�diaire ayant pour fonction 
         * d'occulter les anc�tres ne devant pas �tre pris en compte afin de calculer toutes les possibilit�s 
         * sous-jacente en cas de recherche avec capacit�s multiples, et un niveau indiquant la profondeur
         * de recherche actuelle, mis � 0 � l'appel.  
         * La profondeur de la recherche est limit� par la variable deepness.
         * 
         * Principe:
         * Utilise des noeuds pour constituer une arborescence.  Les pok�mons stock�s le sont dans un noeud r�f�rencant
         * leur parent direct et la liste des enfants direct.
         * 
         * Compare le pok�mon aux autres pok�mons.  S'ils sont du m�me groupe d'oeuf, que celui de la liste peut apprendre
         * la capacit� recherch� et qu'il n'est ni de l'esp�ce de l'un des anc�tres, ni le m�me pok�mon que l'actuel,
         * alors on v�rifie la fa�on dont il apprend le mouvement.  Si c'est par niveau, on stocke le pok�mon et
         * on passe au suivant.  Si c'est par accouplement ou par CT et que le pok�mon permet de relier un autre groupe 
         * d'oeuf, on rapelle la fonction r�cursivement.  Si le r�sultat est diff�rent de null, on le stocke.
         * Enfin, apr�s avoir it�r� chaque pok�mon de la liste, on renvoi le r�sultat si des enfants on �t� trouv�, sinon
         * on renvoi null.
         */
        Noeud ConstitueArbre(Pokemon pok�monParent, Capacite[] capacit�s, Noeud noeudParent, string interm�diaire, int LevelOfDepth)
        {
            bool found = false;
            
            // Cr�e un objet Noeud r�f�rencant le pok�mon et son parent
            Noeud noeudActuel = new Noeud();
            
            //affectation du parent
            noeudActuel.Nom = pok�monParent.Nom;
            //anc�tre du parent, null au premier appel
            noeudActuel.ParentNode = noeudParent;

            // Cr�e une liste des anc�tres
            Pokemon[] listeAncetres = ConstituerParents(noeudActuel, interm�diaire);

            //debug
            for (int i = 0; i < listeAncetres.Length; i++)
            {
                for (int j = 0; j < listeAncetres.Length; j++)
                {
                    if (i != j && listeAncetres[i].Nom == listeAncetres[j].Nom)
                        Debug.Assert(true);
                }
            }
            

            // V�rifie la profondeur de la recherche
            if (LevelOfDepth < deepness || deepness < 1)
            {
                // Parcour la liste des pok�mons
                foreach (Pokemon pk in PKlist)
                {
                    if (pk.Nom == pok�monParent.Nom)
                        continue;
                    
                    //Pok�mon candidat pour �tre enfant de la variable pok�mon
                    Pokemon candidat;
                    
                    //Si le pok�mon d�pend de son �volution, c'est � dire
                    //s'il est st�rile mais que son �vo peut se reproduire,
                    //on r�cup�re les groupes d'oeufs de l'�volution
                    if (pk.dependevo)
                    {
                        Pokemon evo = GetPok�mon(pk.evolution.ToArray()[0].nom);
                        candidat = new Pokemon();
                        CopyPokemon(pk, candidat);
                        candidat.Oeuf1 = evo.Oeuf1;
                        candidat.Oeuf2 = evo.Oeuf2;
                    }
                    else
                        candidat = pk;

                    //R�cup�re le mode d'apprentissage de chaque capacit�
                    Apprentissage[] appr = GetLearnModeOfMoves(candidat, capacit�s);
                    
                    if (MemeGroupeOeuf(pok�monParent, candidat) && HasMove(appr) && !MemeGroupeOeufSaufParentDirect(listeAncetres, pok�monParent, candidat, appr))
                    {
                        // Apprent le ou les mouvements par niveau, est donc une feuille.
                        if (MoveSetIsLevelOnly(appr))
                        {
                            // Cr�e un noeud r�f�ren�ant l'enfant candidat et le parent noeudActuel
                            Noeud noeudEnfant = new Noeud();
                            noeudEnfant.Nom = candidat.Nom;
                            noeudEnfant.ParentNode = noeudActuel;

                            // Rajoute l'enfant � la liste des enfants du noeud parent
                            noeudActuel.ChildNodes.Push(noeudEnfant);
                            leafs++;
                            // Balance des z�venements
                            //OnLeafFound(new EventArgs());
                            if (noeudParent == null)
                            {
                                branches++;
                                //OnBranchAdded(new EventArgs());
                            }
                            found = true;
                            // mini et maxi
                            if (firstmin)
                            {
                                recordmin = LevelOfDepth + 1;
                                firstmin = false;
                            }
                            else if (LevelOfDepth + 1 < recordmin)
                                recordmin = LevelOfDepth + 1;

                            if (LevelOfDepth + 1 > recordmax)
                                recordmax = LevelOfDepth + 1;
                        }
                        // n'est pas une evolution, n'apprend pas tout les mouvements mais peut les transmettres (learner interm�diaire)
                        // et relie un autre groupe d'oeuf (Linker)
                        // et n'est pas pr�sent dans les anc�tres
                        else if ((candidat.evo_de == null || candidat.forme_primaire) && (IsLinker(pok�monParent, candidat) || LearnerIntermediaire(appr)) && !ContientPoke(listeAncetres,pk))
                        {
                            if (!IsLinker(pok�monParent, candidat))
                                interm�diaire = candidat.Nom;
                            // reprend les capacit�s qui ne sont pas apprises par niveau
                            Capacite[] cap = GetCapacitesCTouOeuf(appr, capacit�s);
                            // Cherche les sous-noeuds de l'enfant potentiel
                            Noeud newnode = new Noeud();
                            
                            newnode = ConstitueArbre(candidat, cap, noeudActuel, interm�diaire, LevelOfDepth + 1);

                            if (newnode != null)
                            {
                                noeudActuel.ChildNodes.Push(newnode);
                                found = true;
                                if (noeudParent == null)
                                {
                                    branches++;
                                    // Lance un �venement
                                    //OnBranchAdded(new EventArgs());
                                }
                            }
                        }
                    }
                }
            }
            //Si rien trouv�, renvoi null sinon renvoi le r�sultat
            if (!found)
                return null;
            else
                return noeudActuel;
        }

        bool ContientPoke(Pokemon[] liste, Pokemon poke)
        {
            bool result = false;
            foreach (Pokemon p in liste)
            {
                if (p.Nom == poke.Nom)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        // Renvoi un tableau contenant tous les anc�tres d'un pok�mon
        Pokemon[] ConstituerParents(Noeud Ancetre, string interm�diaire)
        {
            Stack<Pokemon> parents = new Stack<Pokemon>();
            //if (Ancetre.ParentNode != null && (interm�diaire == null || interm�diaire != Ancetre.Nom))
            //{
            //    Pokemon[] result = ConstituerParents(Ancetre.ParentNode, interm�diaire);
            //    foreach (Pokemon p in result)
            //    {
            //        parents.Push(p);
                    
            //    }
            //}


            //Pokemon pk = GetPok�mon(Ancetre.Nom);
            //if(pk != null)
            //    parents.Push(pk);

            Noeud a =Ancetre;

            while (a != null)
            {
                Pokemon p = GetPok�mon(a.Nom);
                if(p != null)
                {
                    parents.Push(p);
                    a = a.ParentNode;
                }
            }
            
            return parents.ToArray();
        }

        

        public bool MemeGroupeOeuf(Pokemon pk1, Pokemon pk2)
        {
            if ((pk1.Oeuf1 == pk2.Oeuf1 || pk1.Oeuf1 == pk2.Oeuf2) && pk1.Oeuf1 != Esp�ce.Aucun && pk1.Oeuf1 != Esp�ce.St�rile)
                return true;
            else if ((pk1.Oeuf2 == pk2.Oeuf1 || pk1.Oeuf2 == pk2.Oeuf2) && pk1.Oeuf2 != Esp�ce.Aucun && pk1.Oeuf2 != Esp�ce.St�rile)
                return true;
            else
                return false;
        }

        // Compare une liste d'anc�tres avec un pok�mon, exclu le parent direct
        // retourne true si l'un des anc�tres est du m�me groupe d'oeuf ormis le parent direct
        public bool MemeGroupeOeufSaufParentDirect(Pokemon[] ancetres, Pokemon parentdirect, Pokemon pok�mon, Apprentissage[] appr)
        {
            foreach (Pokemon ancetre in ancetres)
            {
                //TODO expliquer le but de ces deux lignes! le parent direct n'est-il pas forc�ment dans les anc�tres?
                if (ancetre.Nom == parentdirect.Nom && LearnerIntermediaire(appr))
                    break;

                //si l'un des anc�tres est du m�me groupe d'oeuf ormis le parent direct
                if (MemeGroupeOeuf(ancetre, pok�mon) && ancetre.Nom != parentdirect.Nom)
                    return true;

            }
            return false;
        }

        public static bool HasMove(Pokemon pkm, Capacite capacite)
        {
            foreach (Capacite c in pkm.Capacit�sLevelUp)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.Capacit�sCT)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.Capacit�sCS)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.Capacit�sOeuf)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            return false;
        }

        //renvoi true si le pok�mon peut apprendre toutes les capacit�s
        public static bool HasAllMoves(Pokemon pkm, Capacite[] capacites)
        {
            foreach (Capacite c in capacites)
            {
                if (!HasMove(pkm, c))
                    return false;
            }
            return true;
        }

        public Apprentissage GetLearnModeOfMove(Pokemon pkm, Capacite capacite)
        {
            bool Level = false;
            bool CT = false;
            bool CS = false;
            bool Oeuf = false;

            foreach (Capacite c in pkm.Capacit�sLevelUp)
            {
                if (c.Nom == capacite.Nom)
                {
                    Level = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.Capacit�sCT)
            {
                if (c.Nom == capacite.Nom)
                {
                    CT = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.Capacit�sCS)
            {
                if (c.Nom == capacite.Nom)
                {
                    CS = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.Capacit�sOeuf)
            {
                if (c.Nom == capacite.Nom)
                {
                    Oeuf = true;
                    break;
                }
            }

            if (Level)
            {
                if (CT)
                    return Apprentissage.CTLevel;
                else if (CS)
                    return Apprentissage.CSLevel;
                else
                    return Apprentissage.Level;
            }
            else if (CT)
                return Apprentissage.CT;
            else if (CS)
                return Apprentissage.CS;
            else if (Oeuf)
                return Apprentissage.Oeuf;
            else
                return Apprentissage.Aucun;

        }

        public Apprentissage[] GetLearnModeOfMoves(Pokemon pkm, Capacite[] capacites)
        {
            Evolution[] evos = pkm.evolution.ToArray();
            Apprentissage[] A = new Apprentissage[capacites.Length];
            int i = 0;
            foreach (Capacite c in capacites)
            {
                A[i] = GetLearnModeOfMove(pkm, c);
                if (A[i] != Apprentissage.Level && A[i] != Apprentissage.Level && capacites.Length > 1)
                {
                    foreach (Evolution e in evos)
                    {
                        Pokemon p = GetPok�mon(e.nom);
                        Apprentissage ap = GetLearnModeOfMove(p, c);
                        if (ap == Apprentissage.Level || ap == Apprentissage.CTLevel)
                        {
                            A[i] = ap;
                            break;
                        }
                    }
                }
                i++;
            }
            return A;
        }

        public bool MoveSetIsLevelOnly(Apprentissage[] appr)
        {
            foreach (Apprentissage a in appr)
            {
                if (a == Apprentissage.CT || a == Apprentissage.Oeuf)
                    return false;
            }
            return true;
        }

        bool HasMove(Apprentissage[] moves)
        {
            foreach (Apprentissage a in moves)
            {
                if (a == Apprentissage.Aucun)
                    return false;
            }
            return true;
        }

        // renvoi true si un pok�mon permet de relier un autre groupe d'oeuf
        //parent: parent pour lequel l'autre pok� est �valu�
        //Linker: linker potentiel pour le parent
        bool IsLinker(Pokemon parent, Pokemon Linker)
        {
            if (parent.Oeuf1 == Linker.Oeuf1)
            {
                if (parent.Oeuf2 != Linker.Oeuf2 && Linker.Oeuf2 != Esp�ce.Aucun)
                    return true;
            }
            else if (parent.Oeuf2 == Linker.Oeuf1)
            {
                if (parent.Oeuf1 != Linker.Oeuf2 && Linker.Oeuf2 != Esp�ce.Aucun)
                    return true;
            }
            else if (parent.Oeuf2 == Linker.Oeuf2 && Linker.Oeuf2 != Esp�ce.Aucun)
            {
                if (parent.Oeuf1 != Linker.Oeuf1)
                    return true;
            }
            else if (parent.Oeuf1 == Linker.Oeuf2)
            {
                if (parent.Oeuf2 != Linker.Oeuf2)
                    return true;
            }
            return false;
        }

        //R�cup�re les capacit�s pouvant �tre apprisent par CT ou accouplement
        Capacite[] GetCapacitesCTouOeuf(Apprentissage[] appr, Capacite[] capacite)
        {
            Stack<Capacite> c = new Stack<Capacite>();
            for (int i = 0; i < appr.Length; i++)
            {
                if (appr[i] == Apprentissage.Oeuf || appr[i] == Apprentissage.CT)
                    c.Push(capacite[i]);
            }
            return c.ToArray();
        }

        //copie les propri�t�s de p1 vers p2
        public void CopyPokemon(Pokemon p1, Pokemon p2)
        {
            p2.Attaque = p1.Attaque;
            p2.AttaqueSp� = p1.AttaqueSp�;
            p2.Capacit�s_combat = p1.Capacit�s_combat;
            p2.Capacit�s_fiche = p1.Capacit�s_fiche;
            p2.Capacit�sCS = p1.Capacit�sCS;
            p2.Capacit�sCT = p1.Capacit�sCT;
            p2.Capacit�sLevelUp = p1.Capacit�sLevelUp;
            p2.Capacit�sOeuf = p1.Capacit�sOeuf;
            p2.Capacit�Sp� = p1.Capacit�Sp�;
            p2.Capacit�sSp� = p1.Capacit�sSp�;
            p2.current_Attaque = p1.current_Attaque;
            p2.current_AttaqueSp� = p1.current_AttaqueSp�;
            p2.current_D�fense = p1.current_D�fense;
            p2.current_D�fenseSp� = p1.current_D�fenseSp�;
            p2.current_Evasion = p1.current_Evasion;
            p2.current_Pr�cision = p1.current_Pr�cision;
            p2.current_PV = p1.current_PV;
            p2.current_Vitesse = p1.current_Vitesse;
            p2.D�fense = p1.D�fense;
            p2.D�fenseSp� = p1.D�fenseSp�;
            p2.dependevo = p1.dependevo;
            p2.DV_Attaque = p1.DV_Attaque;
            p2.DV_AttaqueSp� = p1.DV_AttaqueSp�;
            p2.DV_D�fense = p1.DV_D�fense;
            p2.DV_D�fenseSp� = p1.DV_D�fenseSp�;
            p2.DV_PV = p1.DV_PV;
            p2.DV_Vitesse = p1.DV_Vitesse;
            p2.evo_de = p1.evo_de;
            p2.evolution = p1.evolution;
            p2.forme_primaire = p1.forme_primaire;
            p2.nature = p1.nature;
            p2.Niveau = p1.Niveau;
            p2.Nom = p1.Nom;
            p2.Num�ro = p1.Num�ro;
            p2.Oeuf1 = p1.Oeuf1;
            p2.Oeuf2 = p1.Oeuf2;
            p2.PE = p1.PE;
            p2.PE_Attaque = p1.PE_Attaque;
            p2.PE_AttaqueSp� = p1.PE_AttaqueSp�;
            p2.PE_D�fense = p1.PE_D�fense;
            p2.PE_D�fenseSp� = p1.PE_D�fenseSp�;
            p2.PE_PV = p1.PE_PV;
            p2.PE_Vitesse = p1.PE_Vitesse;
            p2.Pseudo = p1.Pseudo;
            p2.PV = p1.PV;
            p2.sexe = p1.sexe;
            p2.Shiney = p1.Shiney;
            p2.Stat_Attaque = p1.Stat_Attaque;
            p2.Stat_AttaqueSp� = p1.Stat_AttaqueSp�;
            p2.Stat_D�fense = p1.Stat_D�fense;
            p2.Stat_D�fenseSp� = p1.Stat_D�fenseSp�;
            p2.Stat_PV = p1.Stat_PV;
            p2.Stat_Vitesse = p1.Stat_Vitesse;
            p2.Symboles = p1.Symboles;
            p2.Type1 = p1.Type1;
            p2.Type2 = p1.Type2;
            p2.Vitesse = p1.Vitesse;
        }

        public static Capacite[] ListofMoves(Pokemon p)
        {
            Stack<Capacite> c = new Stack<Capacite>();

            if (p.evo_de != null)
            {
                Pokemon former = _GetPok�mon(p.evo_de);
                Capacite[] c2 = ListofMoves(former);
                foreach (Capacite cap in c2)
                    c.Push(cap);
            }

            foreach (Capacite cap in p.Capacit�sCS)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.Capacit�sCT)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.Capacit�sLevelUp)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.Capacit�sOeuf)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }

            return c.ToArray();
        }
        static bool IsInList(Capacite cap, Stack<Capacite> c)
        {
            foreach (Capacite cp in c)
            {
                if (cp.Nom == cap.Nom)
                    return true;
            }
            return false;
        }

        //renvoi true si au moins un apprentissage se fait par niveau
        bool LearnerIntermediaire(Apprentissage[] appr)
        {
            foreach (Apprentissage a in appr)
            {
                if (a == Apprentissage.Level || a == Apprentissage.CTLevel)
                    return true;
            }
            return false;
        }
    }
}