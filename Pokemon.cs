using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace URA_Pokemon
{
    [Serializable]
    public class Pokemon
    {
        public string Nom;
        [XmlIgnore]
        public int Numéro;
        [XmlIgnore]
        public PileEffortPoint PE = new PileEffortPoint(); // Points d'efforts que le pokémon rapporte quand il est battu

        [XmlIgnore]
        public Espèce Oeuf1;
        [XmlIgnore]
        public Espèce Oeuf2 = Espèce.Aucun;

        [XmlIgnore]
        public string evo_de;
        [XmlIgnore]
        public PileEvolution evolution = new PileEvolution();

        [XmlIgnore]
        public bool dependevo = false; // pour le groupe d'oeuf
        [XmlIgnore]
        public bool forme_primaire = false;

        [XmlIgnore]
        public Type Type1;
        [XmlIgnore]
        public Type Type2 = Type.AUCUN;

        // Stats de base
        [XmlIgnore]
        public double Stat_PV;
        [XmlIgnore]
        public double Stat_Attaque;
        [XmlIgnore]
        public double Stat_Défense;
        [XmlIgnore]
        public double Stat_Vitesse;
        [XmlIgnore]
        public double Stat_AttaqueSpé;
        [XmlIgnore]
        public double Stat_DéfenseSpé;

        // Listes des mouvements
        [XmlIgnore]
        public Capacite[] CapacitésLevelUp;
        [XmlIgnore]
        public Capacite[] CapacitésCT;
        [XmlIgnore]
        public Capacite[] CapacitésCS;
        [XmlIgnore]
        public Capacite[] CapacitésOeuf;

        Stack<Capacite> SCapacitésLevelUp = new Stack<Capacite>();
        Stack<Capacite> SCapacitésCT = new Stack<Capacite>();
        Stack<Capacite> SCapacitésCS = new Stack<Capacite>();
        Stack<Capacite> SCapacitésOeuf = new Stack<Capacite>();

        // Capacités spéciales
        [XmlIgnore]
        public string[] CapacitésSpé = new string[2];

        // Infos fiche
        public string Pseudo;
        public int Niveau;
        [XmlIgnore]
        public Sexe sexe;
        public Nature nature;
        // 0 carré, 1 rond, 2 triangle, 3 coeur, 4 étoile, 5 losange
        [XmlIgnore]
        public bool[] Symboles = new bool[6];
        public string CapacitéSpé;
        [XmlIgnore]
        public bool Shiney = false;

        // DV
        [XmlIgnore]
        public double DV_PV;
        [XmlIgnore]
        public double DV_Attaque;
        [XmlIgnore]
        public double DV_Défense;
        [XmlIgnore]
        public double DV_AttaqueSpé;
        [XmlIgnore]
        public double DV_DéfenseSpé;
        [XmlIgnore]
        public double DV_Vitesse;

        // Points d'efforts accumulés
        [XmlIgnore]
        public double PE_PV;
        [XmlIgnore]
        public double PE_Attaque;
        [XmlIgnore]
        public double PE_Défense;
        [XmlIgnore]
        public double PE_AttaqueSpé;
        [XmlIgnore]
        public double PE_DéfenseSpé;
        [XmlIgnore]
        public double PE_Vitesse;

        // Valeurs max quand le pokémon est soigné
        [XmlIgnore]
        public double PV;
        [XmlIgnore]
        public double Attaque;
        [XmlIgnore]
        public double Défense;
        [XmlIgnore]
        public double AttaqueSpé;
        [XmlIgnore]
        public double DéfenseSpé;
        [XmlIgnore]
        public double Vitesse;

        // Tableau des capacités actuellement connu du pokémon(pour fiche)
        public Capacite[] Capacités_fiche = new Capacite[4];


        // Valeurs spécifique au combat (peut être jamais utilisé)
        // Valeurs de combat comme 31/55PV
        [XmlIgnore]
        public double current_PV;
        [XmlIgnore]
        public double current_Attaque;
        [XmlIgnore]
        public double current_Défense;
        [XmlIgnore]
        public double current_AttaqueSpé;
        [XmlIgnore]
        public double current_DéfenseSpé;
        [XmlIgnore]
        public double current_Vitesse;
        [XmlIgnore]
        public double current_Précision;
        [XmlIgnore]
        public double current_Evasion;

        // Tableau des capacités pendant le combat
        [XmlIgnore]
        public Capacite[] Capacités_combat = new Capacite[4];

        // Tableau des faiblesses/résistances/neutralités/immunités
        int[] _TableauFaiblRes = null;
        [XmlIgnore]
        public int[] TableauFaiblRes
        {
            get
            {
                if (_TableauFaiblRes == null)
                    InitTableauVulnerabilite();
                return _TableauFaiblRes;
            }
        }

        public Pokemon()
        { }

        public Pokemon(XmlElement pokémon, FileType type_de_fichier)
        {
            Constructor(pokémon, type_de_fichier);
        }

        public Pokemon(string file, FileType type_de_fichier)
        {
            //if (type_de_fichier == FileType.Description)
            //{
                XmlDocument dom = new XmlDocument();
                dom.Load(file);

                XmlElement pokémon = dom.DocumentElement;
                Constructor(pokémon, type_de_fichier);
            //}// fin if Description
        }// fin constructeur

        public void OuvrirFiche(XmlElement root)
        {
            //XmlDocument dom = new XmlDocument();
            //dom.Load(filename);
            //XmlElement root = dom.DocumentElement;

            
            XmlElement DV = null;
            XmlElement PE = null;
            XmlElement Cap = null;
            XmlElement Symb = null;
            foreach (XmlElement el in root)
            {
                switch (el.Name)
                {
                    case "SYMBOLES":
                        Symb = el;
                        break;
                    case "CAPACITES":
                        Cap = el;
                        break;
                    case "PE":
                        PE = el;
                        break;
                    case "DV":
                        DV = el;
                        break;
                    default:
                        break;
                }
            }

            if (root.Attributes["couleur"].Value == "normal")
                Shiney = false;
            else
                Shiney = true;

            if (root.Attributes["espece"].Value != "")
                Nom = root.Attributes["espece"].Value;
            Pseudo = root.Attributes["pseudo"].Value;

            switch (root.Attributes["sexe"].Value)
            {
                case "Male":
                    sexe = Sexe.Mâle;
                    break;
                case "Femelle":
                    sexe = Sexe.Femelle;
                    break;
                case "Assexue":
                    sexe = Sexe.Assexué;
                    break;
                default:
                    sexe = Sexe.Mâle;
                    break;
            }

            if (root.Attributes["nature"].Value != "")
                switch (root.Attributes["nature"].Value)
                {
                    case "Assure":
                        nature = Nature.Assuré;
                        break;
                    case "Bizarre":
                        nature = Nature.Bizarre;
                        break;
                    case "Brave":
                        nature = Nature.Brave;
                        break;
                    case "Calme":
                        nature = Nature.Calme;
                        break;
                    case "Discret":
                        nature = Nature.Discret;
                        break;
                    case "Docile":
                        nature = Nature.Docile;
                        break;
                    case "Doux":
                        nature = Nature.Doux;
                        break;
                    case "Foufou":
                        nature = Nature.Foufou;
                        break;
                    case "Gentil":
                        nature = Nature.Gentil;
                        break;
                    case "Hardi":
                        nature = Nature.Hardi;
                        break;
                    case "Jovial":
                        nature = Nature.Jovial;
                        break;
                    case "Lache":
                        nature = Nature.Laché;
                        break;
                    case "Malin":
                        nature = Nature.Malin;
                        break;
                    case "Malpoli":
                        nature = Nature.Malpoli;
                        break;
                    case "Mauvais":
                        nature = Nature.Mauvais;
                        break;
                    case "Modeste":
                        nature = Nature.Modeste;
                        break;
                    case "Naif":
                        nature = Nature.Naïf;
                        break;
                    case "Presse":
                        nature = Nature.Pressé;
                        break;
                    case "Prudent":
                        nature = Nature.Prudent;
                        break;
                    case "Pudique":
                        nature = Nature.Pudique;
                        break;
                    case "Relax":
                        nature = Nature.Relax;
                        break;
                    case "Rigide":
                        nature = Nature.Rigide;
                        break;
                    case "Serieux":
                        nature = Nature.Sérieux;
                        break;
                    case "Solo":
                        nature = Nature.Solo;
                        break;
                    case "Timide":
                        nature = Nature.Timide;
                        break;
                }
            if (root.Attributes["capacitespe"].Value != "")
                CapacitéSpé = root.Attributes["capacitespe"].Value;

            Niveau = Convert.ToInt32(root.Attributes["niveau"].Value);

            Symboles[0] = Convert.ToBoolean(Symb.Attributes["carre"].Value);
            Symboles[1] = Convert.ToBoolean(Symb.Attributes["rond"].Value);
            Symboles[2] = Convert.ToBoolean(Symb.Attributes["triangle"].Value);
            Symboles[3] = Convert.ToBoolean(Symb.Attributes["coeur"].Value);

            if (Symb.HasAttribute("etoile"))
                Symboles[4] = Convert.ToBoolean(Symb.Attributes["etoile"].Value);
            if (Symb.HasAttribute("losange"))
                Symboles[5] = Convert.ToBoolean(Symb.Attributes["losange"].Value);


            if (Cap.HasAttribute("nom1"))  
                Capacités_fiche[0] = Xblood.GetCapacite(Cap.Attributes["nom1"].Value);
            
            if (Cap.HasAttribute("nom2"))
                Capacités_fiche[1] = Xblood.GetCapacite(Cap.Attributes["nom2"].Value);
            
            if (Cap.HasAttribute("nom3"))
                Capacités_fiche[2] = Xblood.GetCapacite(Cap.Attributes["nom3"].Value);
            
            if (Cap.HasAttribute("nom4"))
                Capacités_fiche[3] = Xblood.GetCapacite(Cap.Attributes["nom4"].Value);
            

            if (DV.Attributes["pv"].Value != "-1")
                DV_PV = Convert.ToDouble(DV.Attributes["pv"].Value);
            
            if (DV.Attributes["a"].Value != "-1")
                DV_Attaque = Convert.ToDouble(DV.Attributes["a"].Value);
            
            if (DV.Attributes["d"].Value != "-1")
                DV_Défense = Convert.ToDouble(DV.Attributes["d"].Value);
            
            if (DV.Attributes["as"].Value != "-1")
                DV_AttaqueSpé = Convert.ToDouble(DV.Attributes["as"].Value);
            
            if (DV.Attributes["ds"].Value != "-1")
                DV_DéfenseSpé = Convert.ToDouble(DV.Attributes["ds"].Value);
            
            if (DV.Attributes["v"].Value != "-1")
                DV_Vitesse = Convert.ToDouble(DV.Attributes["v"].Value);
            

            PE_PV = Convert.ToDouble(PE.Attributes["pv"].Value);
            PE_Attaque = Convert.ToDouble(PE.Attributes["a"].Value);
            PE_Défense = Convert.ToDouble(PE.Attributes["d"].Value);
            PE_AttaqueSpé = Convert.ToDouble(PE.Attributes["as"].Value);
            PE_DéfenseSpé = Convert.ToDouble(PE.Attributes["ds"].Value);
            PE_Vitesse = Convert.ToDouble(PE.Attributes["v"].Value);
        }

        void Constructor(XmlElement pokémon, FileType type_de_fichier)
        {
            #region Description
            if (type_de_fichier == FileType.Description)
            {
                Nom = pokémon.Attributes["nom"].Value;
                Numéro = Convert.ToInt32(pokémon.Attributes["num"].Value);

                switch (pokémon.Attributes["type1"].Value)
                {
                    case "NORMAL":
                        Type1 = Type.NORMAL;
                        break;
                    case "FEU":
                        Type1 = Type.FEU;
                        break;
                    case "EAU":
                        Type1 = Type.EAU;
                        break;
                    case "PLANTE":
                        Type1 = Type.PLANTE;
                        break;
                    case "ELECTRIK":
                        Type1 = Type.ELECTRIK;
                        break;
                    case "GLACE":
                        Type1 = Type.GLACE;
                        break;
                    case "COMBAT":
                        Type1 = Type.COMBAT;
                        break;
                    case "POISON":
                        Type1 = Type.POISON;
                        break;
                    case "SOL":
                        Type1 = Type.SOL;
                        break;
                    case "VOL":
                        Type1 = Type.VOL;
                        break;
                    case "PSY":
                        Type1 = Type.PSY;
                        break;
                    case "INSECTE":
                        Type1 = Type.INSECTE;
                        break;
                    case "ROCHE":
                        Type1 = Type.ROCHE;
                        break;
                    case "SPECTRE":
                        Type1 = Type.SPECTRE;
                        break;
                    case "DRAGON":
                        Type1 = Type.DRAGON;
                        break;
                    case "TENEBRES":
                        Type1 = Type.TENEBRES;
                        break;
                    case "ACIER":
                        Type1 = Type.ACIER;
                        break;
                }

                
                    if (pokémon.HasAttribute("type2"))
                    {
                        switch (pokémon.Attributes["type2"].Value)
                        {
                            case "NORMAL":
                                Type2 = Type.NORMAL;
                                break;
                            case "FEU":
                                Type2 = Type.FEU;
                                break;
                            case "EAU":
                                Type2 = Type.EAU;
                                break;
                            case "PLANTE":
                                Type2 = Type.PLANTE;
                                break;
                            case "ELECTRIK":
                                Type2 = Type.ELECTRIK;
                                break;
                            case "GLACE":
                                Type2 = Type.GLACE;
                                break;
                            case "COMBAT":
                                Type2 = Type.COMBAT;
                                break;
                            case "POISON":
                                Type2 = Type.POISON;
                                break;
                            case "SOL":
                                Type2 = Type.SOL;
                                break;
                            case "VOL":
                                Type2 = Type.VOL;
                                break;
                            case "PSY":
                                Type2 = Type.PSY;
                                break;
                            case "INSECTE":
                                Type2 = Type.INSECTE;
                                break;
                            case "ROCHE":
                                Type2 = Type.ROCHE;
                                break;
                            case "SPECTRE":
                                Type2 = Type.SPECTRE;
                                break;
                            case "DRAGON":
                                Type2 = Type.DRAGON;
                                break;
                            case "TENEBRES":
                                Type2 = Type.TENEBRES;
                                break;
                            case "ACIER":
                                Type2 = Type.ACIER;
                                break;
                            default:
                                Type2 = Type.AUCUN;
                                break;
                        }
                    }
                

                switch (pokémon.Attributes["oeuf1"].Value)
                {
                    case "amorphe":
                        Oeuf1 = Espèce.Amorphe;
                        break;
                    case "aquatique1":
                        Oeuf1 = Espèce.Aquatique1;
                        break;
                    case "aquatique2":
                        Oeuf1 = Espèce.Aquatique2;
                        break;
                    case "aquatique3":
                        Oeuf1 = Espèce.Aquatique3;
                        break;
                    case "aucun":
                        Oeuf1 = Espèce.Aucun;
                        break;
                    case "champetre":
                        Oeuf1 = Espèce.Champêtre;
                        break;
                    case "dragon":
                        Oeuf1 = Espèce.Dragon;
                        break;
                    case "feerique":
                        Oeuf1 = Espèce.Féerique;
                        break;
                    case "herbeux":
                        Oeuf1 = Espèce.Herbeux;
                        break;
                    case "humain":
                        Oeuf1 = Espèce.Humain;
                        break;
                    case "insecte":
                        Oeuf1 = Espèce.Insecte;
                        break;
                    case "mineral":
                        Oeuf1 = Espèce.Minéral;
                        break;
                    case "monstre":
                        Oeuf1 = Espèce.Monstre;
                        break;
                    case "sterile":
                        Oeuf1 = Espèce.Stérile;
                        break;
                    case "volant":
                        Oeuf1 = Espèce.Volant;
                        break;
                }
                if(pokémon.HasAttribute("oeuf2"))
                {
                    switch (pokémon.Attributes["oeuf2"].Value)
                    {
                        case "amorphe":
                            Oeuf2 = Espèce.Amorphe;
                            break;
                        case "aquatique1":
                            Oeuf2 = Espèce.Aquatique1;
                            break;
                        case "aquatique2":
                            Oeuf2 = Espèce.Aquatique2;
                            break;
                        case "aquatique3":
                            Oeuf2 = Espèce.Aquatique3;
                            break;
                        case "aucun":
                            Oeuf2 = Espèce.Aucun;
                            break;
                        case "champetre":
                            Oeuf2 = Espèce.Champêtre;
                            break;
                        case "dragon":
                            Oeuf2 = Espèce.Dragon;
                            break;
                        case "feerique":
                            Oeuf2 = Espèce.Féerique;
                            break;
                        case "herbeux":
                            Oeuf2 = Espèce.Herbeux;
                            break;
                        case "humain":
                            Oeuf2 = Espèce.Humain;
                            break;
                        case "insecte":
                            Oeuf2 = Espèce.Insecte;
                            break;
                        case "mineral":
                            Oeuf2 = Espèce.Minéral;
                            break;
                        case "monstre":
                            Oeuf2 = Espèce.Monstre;
                            break;
                        case "sterile":
                            Oeuf2 = Espèce.Stérile;
                            break;
                        case "volant":
                            Oeuf2 = Espèce.Volant;
                            break;
                    }
                }
                

                if(pokémon.HasAttribute("evode"))
                 evo_de = pokémon.Attributes["evode"].Value; 
                

                Stat_PV = Convert.ToDouble(pokémon.Attributes["pv"].Value);
                Stat_Attaque = Convert.ToDouble(pokémon.Attributes["atq"].Value);
                Stat_Défense = Convert.ToDouble(pokémon.Attributes["def"].Value);
                Stat_AttaqueSpé = Convert.ToDouble(pokémon.Attributes["as"].Value);
                Stat_DéfenseSpé = Convert.ToDouble(pokémon.Attributes["ds"].Value);
                Stat_Vitesse = Convert.ToDouble(pokémon.Attributes["vit"].Value);

                int NumCapSP = 0;

                foreach (XmlElement el in pokémon.ChildNodes)
                {
                    if (el.Name == "CAPACITE")
                    {
                        Capacite c = new Capacite(el);

                        switch (c.apprentissage)
                        {
                            case Apprentissage.Level:
                                SCapacitésLevelUp.Push(c);
                                break;
                            case Apprentissage.CT:
                                SCapacitésCT.Push(c);
                                break;
                            case Apprentissage.CTLevel:
                                SCapacitésLevelUp.Push(c);
                                SCapacitésCT.Push(c);
                                break;
                            case Apprentissage.CS:
                                SCapacitésCS.Push(c);
                                break;
                            case Apprentissage.CSLevel:
                                SCapacitésLevelUp.Push(c);
                                SCapacitésCS.Push(c);
                                break;
                            case Apprentissage.Oeuf:
                                SCapacitésOeuf.Push(c);
                                break;
                        }

                    }
                    else if (el.Name == "EFFORT_POINT")
                    {
                        EffortPoints pe = new EffortPoints(el);
                        PE.Push(pe);
                    }
                    else if (el.Name == "CAPACITESPE")
                    {
                        CapacitésSpé[NumCapSP] = el.Attributes["nom"].Value;
                        NumCapSP++;
                    }
                    else if (el.Name == "EVOLUTION")
                    {
                        Evolution e = new Evolution(el);
                        evolution.Push(e);
                    }
                    else if (el.Name == "DEPENDEVO")
                        dependevo = true;
                    else if (el.Name == "FORME_PRIMAIRE")
                        forme_primaire = true;
                }

                CapacitésLevelUp = SCapacitésLevelUp.ToArray();
                CapacitésCT = SCapacitésCT.ToArray();
                CapacitésCS = SCapacitésCS.ToArray();
                CapacitésOeuf = SCapacitésOeuf.ToArray();
            }// fin if Description
            #endregion
            #region Fiche
            else if (type_de_fichier == FileType.Fiche)
            {


                //XmlElement Cap = null;
                //XmlElement Symb = null;
                //bool breakout = false;
                //foreach (XmlElement el in pokémon)
                //{
                //    switch (el.Name)
                //    {

                //        case "CAPACITES":
                //            Cap = el;
                //            breakout = true;
                //            break;
                //        default:
                //            break;
                //    }
                //    if (breakout)
                //        break;
                //}

                //if (pokémon.Attributes["espece"].Value != "")
                //{

                //    Nom = pokémon.Attributes["espece"].Value;
                //    Pseudo = pokémon.Attributes["pseudo"].Value;

                //    if (pokémon.Attributes["capacitespe"].Value != "")
                //        CapacitéSpé = pokémon.Attributes["capacitespe"].Value;
                    
                //    if (Cap.HasAttribute("nom1"))
                //        Capacités_fiche[0] = Xblood.GetCapacite(Cap.Attributes["nom1"].Value);
                //    if (Cap.HasAttribute("nom2"))
                //        Capacités_fiche[1] = Xblood.GetCapacite(Cap.Attributes["nom2"].Value);
                //    if (Cap.HasAttribute("nom3"))
                //        Capacités_fiche[2] = Xblood.GetCapacite(Cap.Attributes["nom3"].Value);
                //    if (Cap.HasAttribute("nom4"))
                //        Capacités_fiche[3] = Xblood.GetCapacite(Cap.Attributes["nom4"].Value);

                //}

                OuvrirFiche(pokémon);

            }
            #endregion

        }

        private void InitTableauVulnerabilite()
        {
            if (Xblood.Types == null)
                Xblood.FillTypes();

            _TableauFaiblRes = new int[17];

            if (this.Type2 == Type.AUCUN)
            {
                for (int i = 0; i < 17; i++)
                {
                    _TableauFaiblRes[i] = Xblood.Types[i, (int)Type1];
                }
            }
            else
            {
                for (int i = 0; i < 17; i++)
                {

                    if (Xblood.Types[i, (int)Type1] == 7 || Xblood.Types[i, (int)Type2] == 7)
                        _TableauFaiblRes[i] = 7;
                    else
                        _TableauFaiblRes[i] = Xblood.Types[i, (int)Type1] + Xblood.Types[i, (int)Type2];
                }
            }
        }

        public override string ToString()
        {
            return Nom;
        }

    }



}
