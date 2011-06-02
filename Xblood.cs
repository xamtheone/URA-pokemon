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
        #region Déclatations
        // nombres de pokémons chargés
        static int nbloaded = 0;
        // liste des pokémons
        static Pokemon[] _PKlist;
        public Pokemon[] PKlist;
        static SortedDictionary<string, int> _SDPokemon;
        SortedDictionary<string, int> SDPokemon;
        // liste des mouvements
        static Capacite[] _Clist;
        public Capacite[] Clist;
        static SortedDictionary<string, int> _SDCapacite;
        SortedDictionary<string, int> SDCapacite;
        // liste des capacités spé
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
        //Tableau des types existants réelement dans le jeu
        public static bool[,] TypesExistants;
        // nombres de branches trouvées
        public int branches = 0;
        // nombres de feuilles trouvées
        public int leafs = 0;
        // Agruments pour le thread
        public Pokemon argPokemon;
        public Capacite[] argCapacite;
        // Résultat du thread
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

        #region Les zévenements

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

        // Démarre le thread de recherche d'accouplement
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

        // Remplit la liste statique des pokémons
        public static void FillPKlist()
        {
            string[] files = Directory.GetFiles(@"DescriptionPokemon\", "*.xml");
            //tableau des pokémons
            _PKlist = new Pokemon[files.Length];
            //tableau pour copier les pokémons triés
            Pokemon[] sortarray = new Pokemon[files.Length];
            //Dictionnaire pour stocker les pairs nom/index
            Dictionary<string, int> dico = new Dictionary<string, int>(493);

            nbloaded = 0;
            foreach (string file in files)
            {
                _PKlist[nbloaded] = new Pokemon(file, FileType.Description);
                //On remplace l'espace par un underscore sinon seule la première partie est utilisée
                dico.Add(_PKlist[nbloaded].Nom, nbloaded);
                nbloaded++;

                OnPokemonAddedtoPKlist(new EventArgs());

            }

            //On crée un dictionnaire trié à partir de dico
            _SDPokemon = new SortedDictionary<string, int>(dico);


            //tableau des index triés
            int[] sortedindexes = new int[files.Length];
            _SDPokemon.Values.CopyTo(sortedindexes, 0);

            //On bascule les valeurs triés dans le tableau inital
            for (int i = 0; i < sortedindexes.Length; i++)
            {
                sortarray[i] = _PKlist[sortedindexes[i]];
                _SDPokemon[sortarray[i].Nom] = i;
            }

            //On réaffecte le bon tableau
            _PKlist = sortarray;

            PKlistisFilled = true;
            OnListFull(new EventArgs());
        }

        // Remplit la liste statique des capacités
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
                //On remplace l'espace par un underscore sinon seule la première partie est utilisée
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
            Définition d'un tableau de faiblesse/résistance avec
            0 = neutre
            -2 = peu efficace
            2 = efficace
            7 = immunisé
            Première valeur = attaque
            Deuxième valeur = type
            D'où Tableau(attaque sur type) = Neutre/Faiblesse/Résistance/Immunité
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

        // trie les capacités par niveau d'apprentissage
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

        // trie les capacités par numéro de CT
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

        // trie les capacités par numéro de CS
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

        // complète les informations d'une liste de capacités dans un nouveau tableau
        public static Capacite[] CompleteAClist(Capacite[] tab)
        {
            Capacite[] newtab = new Capacite[tab.Length];
            for (int i = 0; i < tab.Length; i++)
                newtab[i] = GetCapacite(tab[i]);
            return newtab;
        }

        // optient toutes les informations sur une capacité avec un objet Capacite
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

        // optient toutes les informations sur une capacité grâce à son nom
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

        // optient toutes les informations sur un pokémon grâce à son nom
        public Pokemon GetPokémon(string Nom)
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

        static Pokemon _GetPokémon(string Nom)
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


        /* parcourt tous les pokémons compatibles d'un pokémon, retourne l'arbre trouvé
         *
         * Fonction récursive; prend en paramètres le pokémon auquel on veut donner les capacités,
         * lesdites capacités, un argument noeud parent mit à null à l'appel de la fonction servant dans la récursion
         * pour chainer les pokémons, le nom d'un pokémon intermédiaire ayant pour fonction 
         * d'occulter les ancêtres ne devant pas être pris en compte afin de calculer toutes les possibilités 
         * sous-jacente en cas de recherche avec capacités multiples, et un niveau indiquant la profondeur
         * de recherche actuelle, mis à 0 à l'appel.  
         * La profondeur de la recherche est limité par la variable deepness.
         * 
         * Principe:
         * Utilise des noeuds pour constituer une arborescence.  Les pokémons stockés le sont dans un noeud référencant
         * leur parent direct et la liste des enfants direct.
         * 
         * Compare le pokémon aux autres pokémons.  S'ils sont du même groupe d'oeuf, que celui de la liste peut apprendre
         * la capacité recherché et qu'il n'est ni de l'espèce de l'un des ancètres, ni le même pokémon que l'actuel,
         * alors on vérifie la façon dont il apprend le mouvement.  Si c'est par niveau, on stocke le pokémon et
         * on passe au suivant.  Si c'est par accouplement ou par CT et que le pokémon permet de relier un autre groupe 
         * d'oeuf, on rapelle la fonction récursivement.  Si le résultat est différent de null, on le stocke.
         * Enfin, après avoir itéré chaque pokémon de la liste, on renvoi le résultat si des enfants on été trouvé, sinon
         * on renvoi null.
         */
        Noeud ConstitueArbre(Pokemon pokémonParent, Capacite[] capacités, Noeud noeudParent, string intermédiaire, int LevelOfDepth)
        {
            bool found = false;
            
            // Crée un objet Noeud référencant le pokémon et son parent
            Noeud noeudActuel = new Noeud();
            
            //affectation du parent
            noeudActuel.Nom = pokémonParent.Nom;
            //ancètre du parent, null au premier appel
            noeudActuel.ParentNode = noeudParent;

            // Crée une liste des ancètres
            Pokemon[] listeAncetres = ConstituerParents(noeudActuel, intermédiaire);

            //debug
            for (int i = 0; i < listeAncetres.Length; i++)
            {
                for (int j = 0; j < listeAncetres.Length; j++)
                {
                    if (i != j && listeAncetres[i].Nom == listeAncetres[j].Nom)
                        Debug.Assert(true);
                }
            }
            

            // Vérifie la profondeur de la recherche
            if (LevelOfDepth < deepness || deepness < 1)
            {
                // Parcour la liste des pokémons
                foreach (Pokemon pk in PKlist)
                {
                    if (pk.Nom == pokémonParent.Nom)
                        continue;
                    
                    //Pokémon candidat pour être enfant de la variable pokémon
                    Pokemon candidat;
                    
                    //Si le pokémon dépend de son évolution, c'est à dire
                    //s'il est stérile mais que son évo peut se reproduire,
                    //on récupère les groupes d'oeufs de l'évolution
                    if (pk.dependevo)
                    {
                        Pokemon evo = GetPokémon(pk.evolution.ToArray()[0].nom);
                        candidat = new Pokemon();
                        CopyPokemon(pk, candidat);
                        candidat.Oeuf1 = evo.Oeuf1;
                        candidat.Oeuf2 = evo.Oeuf2;
                    }
                    else
                        candidat = pk;

                    //Récupère le mode d'apprentissage de chaque capacité
                    Apprentissage[] appr = GetLearnModeOfMoves(candidat, capacités);
                    
                    if (MemeGroupeOeuf(pokémonParent, candidat) && HasMove(appr) && !MemeGroupeOeufSaufParentDirect(listeAncetres, pokémonParent, candidat, appr))
                    {
                        // Apprent le ou les mouvements par niveau, est donc une feuille.
                        if (MoveSetIsLevelOnly(appr))
                        {
                            // Crée un noeud référençant l'enfant candidat et le parent noeudActuel
                            Noeud noeudEnfant = new Noeud();
                            noeudEnfant.Nom = candidat.Nom;
                            noeudEnfant.ParentNode = noeudActuel;

                            // Rajoute l'enfant à la liste des enfants du noeud parent
                            noeudActuel.ChildNodes.Push(noeudEnfant);
                            leafs++;
                            // Balance des zévenements
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
                        // n'est pas une evolution, n'apprend pas tout les mouvements mais peut les transmettres (learner intermédiaire)
                        // et relie un autre groupe d'oeuf (Linker)
                        // et n'est pas présent dans les ancêtres
                        else if ((candidat.evo_de == null || candidat.forme_primaire) && (IsLinker(pokémonParent, candidat) || LearnerIntermediaire(appr)) && !ContientPoke(listeAncetres,pk))
                        {
                            if (!IsLinker(pokémonParent, candidat))
                                intermédiaire = candidat.Nom;
                            // reprend les capacités qui ne sont pas apprises par niveau
                            Capacite[] cap = GetCapacitesCTouOeuf(appr, capacités);
                            // Cherche les sous-noeuds de l'enfant potentiel
                            Noeud newnode = new Noeud();
                            
                            newnode = ConstitueArbre(candidat, cap, noeudActuel, intermédiaire, LevelOfDepth + 1);

                            if (newnode != null)
                            {
                                noeudActuel.ChildNodes.Push(newnode);
                                found = true;
                                if (noeudParent == null)
                                {
                                    branches++;
                                    // Lance un évenement
                                    //OnBranchAdded(new EventArgs());
                                }
                            }
                        }
                    }
                }
            }
            //Si rien trouvé, renvoi null sinon renvoi le résultat
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

        // Renvoi un tableau contenant tous les ancètres d'un pokémon
        Pokemon[] ConstituerParents(Noeud Ancetre, string intermédiaire)
        {
            Stack<Pokemon> parents = new Stack<Pokemon>();
            //if (Ancetre.ParentNode != null && (intermédiaire == null || intermédiaire != Ancetre.Nom))
            //{
            //    Pokemon[] result = ConstituerParents(Ancetre.ParentNode, intermédiaire);
            //    foreach (Pokemon p in result)
            //    {
            //        parents.Push(p);
                    
            //    }
            //}


            //Pokemon pk = GetPokémon(Ancetre.Nom);
            //if(pk != null)
            //    parents.Push(pk);

            Noeud a =Ancetre;

            while (a != null)
            {
                Pokemon p = GetPokémon(a.Nom);
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
            if ((pk1.Oeuf1 == pk2.Oeuf1 || pk1.Oeuf1 == pk2.Oeuf2) && pk1.Oeuf1 != Espèce.Aucun && pk1.Oeuf1 != Espèce.Stérile)
                return true;
            else if ((pk1.Oeuf2 == pk2.Oeuf1 || pk1.Oeuf2 == pk2.Oeuf2) && pk1.Oeuf2 != Espèce.Aucun && pk1.Oeuf2 != Espèce.Stérile)
                return true;
            else
                return false;
        }

        // Compare une liste d'ancètres avec un pokémon, exclu le parent direct
        // retourne true si l'un des ancêtres est du même groupe d'oeuf ormis le parent direct
        public bool MemeGroupeOeufSaufParentDirect(Pokemon[] ancetres, Pokemon parentdirect, Pokemon pokémon, Apprentissage[] appr)
        {
            foreach (Pokemon ancetre in ancetres)
            {
                //TODO expliquer le but de ces deux lignes! le parent direct n'est-il pas forcément dans les ancêtres?
                if (ancetre.Nom == parentdirect.Nom && LearnerIntermediaire(appr))
                    break;

                //si l'un des ancêtres est du même groupe d'oeuf ormis le parent direct
                if (MemeGroupeOeuf(ancetre, pokémon) && ancetre.Nom != parentdirect.Nom)
                    return true;

            }
            return false;
        }

        public static bool HasMove(Pokemon pkm, Capacite capacite)
        {
            foreach (Capacite c in pkm.CapacitésLevelUp)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.CapacitésCT)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.CapacitésCS)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            foreach (Capacite c in pkm.CapacitésOeuf)
            {
                if (c.Nom == capacite.Nom)
                    return true;
            }
            return false;
        }

        //renvoi true si le pokémon peut apprendre toutes les capacités
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

            foreach (Capacite c in pkm.CapacitésLevelUp)
            {
                if (c.Nom == capacite.Nom)
                {
                    Level = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.CapacitésCT)
            {
                if (c.Nom == capacite.Nom)
                {
                    CT = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.CapacitésCS)
            {
                if (c.Nom == capacite.Nom)
                {
                    CS = true;
                    break;
                }
            }
            foreach (Capacite c in pkm.CapacitésOeuf)
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
                        Pokemon p = GetPokémon(e.nom);
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

        // renvoi true si un pokémon permet de relier un autre groupe d'oeuf
        //parent: parent pour lequel l'autre poké est évalué
        //Linker: linker potentiel pour le parent
        bool IsLinker(Pokemon parent, Pokemon Linker)
        {
            if (parent.Oeuf1 == Linker.Oeuf1)
            {
                if (parent.Oeuf2 != Linker.Oeuf2 && Linker.Oeuf2 != Espèce.Aucun)
                    return true;
            }
            else if (parent.Oeuf2 == Linker.Oeuf1)
            {
                if (parent.Oeuf1 != Linker.Oeuf2 && Linker.Oeuf2 != Espèce.Aucun)
                    return true;
            }
            else if (parent.Oeuf2 == Linker.Oeuf2 && Linker.Oeuf2 != Espèce.Aucun)
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

        //Récupère les capacités pouvant être apprisent par CT ou accouplement
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

        //copie les propriétés de p1 vers p2
        public void CopyPokemon(Pokemon p1, Pokemon p2)
        {
            p2.Attaque = p1.Attaque;
            p2.AttaqueSpé = p1.AttaqueSpé;
            p2.Capacités_combat = p1.Capacités_combat;
            p2.Capacités_fiche = p1.Capacités_fiche;
            p2.CapacitésCS = p1.CapacitésCS;
            p2.CapacitésCT = p1.CapacitésCT;
            p2.CapacitésLevelUp = p1.CapacitésLevelUp;
            p2.CapacitésOeuf = p1.CapacitésOeuf;
            p2.CapacitéSpé = p1.CapacitéSpé;
            p2.CapacitésSpé = p1.CapacitésSpé;
            p2.current_Attaque = p1.current_Attaque;
            p2.current_AttaqueSpé = p1.current_AttaqueSpé;
            p2.current_Défense = p1.current_Défense;
            p2.current_DéfenseSpé = p1.current_DéfenseSpé;
            p2.current_Evasion = p1.current_Evasion;
            p2.current_Précision = p1.current_Précision;
            p2.current_PV = p1.current_PV;
            p2.current_Vitesse = p1.current_Vitesse;
            p2.Défense = p1.Défense;
            p2.DéfenseSpé = p1.DéfenseSpé;
            p2.dependevo = p1.dependevo;
            p2.DV_Attaque = p1.DV_Attaque;
            p2.DV_AttaqueSpé = p1.DV_AttaqueSpé;
            p2.DV_Défense = p1.DV_Défense;
            p2.DV_DéfenseSpé = p1.DV_DéfenseSpé;
            p2.DV_PV = p1.DV_PV;
            p2.DV_Vitesse = p1.DV_Vitesse;
            p2.evo_de = p1.evo_de;
            p2.evolution = p1.evolution;
            p2.forme_primaire = p1.forme_primaire;
            p2.nature = p1.nature;
            p2.Niveau = p1.Niveau;
            p2.Nom = p1.Nom;
            p2.Numéro = p1.Numéro;
            p2.Oeuf1 = p1.Oeuf1;
            p2.Oeuf2 = p1.Oeuf2;
            p2.PE = p1.PE;
            p2.PE_Attaque = p1.PE_Attaque;
            p2.PE_AttaqueSpé = p1.PE_AttaqueSpé;
            p2.PE_Défense = p1.PE_Défense;
            p2.PE_DéfenseSpé = p1.PE_DéfenseSpé;
            p2.PE_PV = p1.PE_PV;
            p2.PE_Vitesse = p1.PE_Vitesse;
            p2.Pseudo = p1.Pseudo;
            p2.PV = p1.PV;
            p2.sexe = p1.sexe;
            p2.Shiney = p1.Shiney;
            p2.Stat_Attaque = p1.Stat_Attaque;
            p2.Stat_AttaqueSpé = p1.Stat_AttaqueSpé;
            p2.Stat_Défense = p1.Stat_Défense;
            p2.Stat_DéfenseSpé = p1.Stat_DéfenseSpé;
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
                Pokemon former = _GetPokémon(p.evo_de);
                Capacite[] c2 = ListofMoves(former);
                foreach (Capacite cap in c2)
                    c.Push(cap);
            }

            foreach (Capacite cap in p.CapacitésCS)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.CapacitésCT)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.CapacitésLevelUp)
            {
                if (!IsInList(cap, c))
                    c.Push(cap);
            }
            foreach (Capacite cap in p.CapacitésOeuf)
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