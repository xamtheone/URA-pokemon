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
        public int Num�ro;
        [XmlIgnore]
        public PileEffortPoint PE = new PileEffortPoint(); // Points d'efforts que le pok�mon rapporte quand il est battu

        [XmlIgnore]
        public Esp�ce Oeuf1;
        [XmlIgnore]
        public Esp�ce Oeuf2 = Esp�ce.Aucun;

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
        public double Stat_D�fense;
        [XmlIgnore]
        public double Stat_Vitesse;
        [XmlIgnore]
        public double Stat_AttaqueSp�;
        [XmlIgnore]
        public double Stat_D�fenseSp�;

        // Listes des mouvements
        [XmlIgnore]
        public Capacite[] Capacit�sLevelUp;
        [XmlIgnore]
        public Capacite[] Capacit�sCT;
        [XmlIgnore]
        public Capacite[] Capacit�sCS;
        [XmlIgnore]
        public Capacite[] Capacit�sOeuf;

        Stack<Capacite> SCapacit�sLevelUp = new Stack<Capacite>();
        Stack<Capacite> SCapacit�sCT = new Stack<Capacite>();
        Stack<Capacite> SCapacit�sCS = new Stack<Capacite>();
        Stack<Capacite> SCapacit�sOeuf = new Stack<Capacite>();

        // Capacit�s sp�ciales
        [XmlIgnore]
        public string[] Capacit�sSp� = new string[2];

        // Infos fiche
        public string Pseudo;
        public int Niveau;
        [XmlIgnore]
        public Sexe sexe;
        public Nature nature;
        // 0 carr�, 1 rond, 2 triangle, 3 coeur, 4 �toile, 5 losange
        [XmlIgnore]
        public bool[] Symboles = new bool[6];
        public string Capacit�Sp�;
        [XmlIgnore]
        public bool Shiney = false;

        // DV
        [XmlIgnore]
        public double DV_PV;
        [XmlIgnore]
        public double DV_Attaque;
        [XmlIgnore]
        public double DV_D�fense;
        [XmlIgnore]
        public double DV_AttaqueSp�;
        [XmlIgnore]
        public double DV_D�fenseSp�;
        [XmlIgnore]
        public double DV_Vitesse;

        // Points d'efforts accumul�s
        [XmlIgnore]
        public double PE_PV;
        [XmlIgnore]
        public double PE_Attaque;
        [XmlIgnore]
        public double PE_D�fense;
        [XmlIgnore]
        public double PE_AttaqueSp�;
        [XmlIgnore]
        public double PE_D�fenseSp�;
        [XmlIgnore]
        public double PE_Vitesse;

        // Valeurs max quand le pok�mon est soign�
        [XmlIgnore]
        public double PV;
        [XmlIgnore]
        public double Attaque;
        [XmlIgnore]
        public double D�fense;
        [XmlIgnore]
        public double AttaqueSp�;
        [XmlIgnore]
        public double D�fenseSp�;
        [XmlIgnore]
        public double Vitesse;

        // Tableau des capacit�s actuellement connu du pok�mon(pour fiche)
        public Capacite[] Capacit�s_fiche = new Capacite[4];


        // Valeurs sp�cifique au combat (peut �tre jamais utilis�)
        // Valeurs de combat comme 31/55PV
        [XmlIgnore]
        public double current_PV;
        [XmlIgnore]
        public double current_Attaque;
        [XmlIgnore]
        public double current_D�fense;
        [XmlIgnore]
        public double current_AttaqueSp�;
        [XmlIgnore]
        public double current_D�fenseSp�;
        [XmlIgnore]
        public double current_Vitesse;
        [XmlIgnore]
        public double current_Pr�cision;
        [XmlIgnore]
        public double current_Evasion;

        // Tableau des capacit�s pendant le combat
        [XmlIgnore]
        public Capacite[] Capacit�s_combat = new Capacite[4];

        // Tableau des faiblesses/r�sistances/neutralit�s/immunit�s
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

        public Pokemon(XmlElement pok�mon, FileType type_de_fichier)
        {
            Constructor(pok�mon, type_de_fichier);
        }

        public Pokemon(string file, FileType type_de_fichier)
        {
            //if (type_de_fichier == FileType.Description)
            //{
                XmlDocument dom = new XmlDocument();
                dom.Load(file);

                XmlElement pok�mon = dom.DocumentElement;
                Constructor(pok�mon, type_de_fichier);
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
                    sexe = Sexe.M�le;
                    break;
                case "Femelle":
                    sexe = Sexe.Femelle;
                    break;
                case "Assexue":
                    sexe = Sexe.Assexu�;
                    break;
                default:
                    sexe = Sexe.M�le;
                    break;
            }

            if (root.Attributes["nature"].Value != "")
                switch (root.Attributes["nature"].Value)
                {
                    case "Assure":
                        nature = Nature.Assur�;
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
                        nature = Nature.Lach�;
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
                        nature = Nature.Na�f;
                        break;
                    case "Presse":
                        nature = Nature.Press�;
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
                        nature = Nature.S�rieux;
                        break;
                    case "Solo":
                        nature = Nature.Solo;
                        break;
                    case "Timide":
                        nature = Nature.Timide;
                        break;
                }
            if (root.Attributes["capacitespe"].Value != "")
                Capacit�Sp� = root.Attributes["capacitespe"].Value;

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
                Capacit�s_fiche[0] = Xblood.GetCapacite(Cap.Attributes["nom1"].Value);
            
            if (Cap.HasAttribute("nom2"))
                Capacit�s_fiche[1] = Xblood.GetCapacite(Cap.Attributes["nom2"].Value);
            
            if (Cap.HasAttribute("nom3"))
                Capacit�s_fiche[2] = Xblood.GetCapacite(Cap.Attributes["nom3"].Value);
            
            if (Cap.HasAttribute("nom4"))
                Capacit�s_fiche[3] = Xblood.GetCapacite(Cap.Attributes["nom4"].Value);
            

            if (DV.Attributes["pv"].Value != "-1")
                DV_PV = Convert.ToDouble(DV.Attributes["pv"].Value);
            
            if (DV.Attributes["a"].Value != "-1")
                DV_Attaque = Convert.ToDouble(DV.Attributes["a"].Value);
            
            if (DV.Attributes["d"].Value != "-1")
                DV_D�fense = Convert.ToDouble(DV.Attributes["d"].Value);
            
            if (DV.Attributes["as"].Value != "-1")
                DV_AttaqueSp� = Convert.ToDouble(DV.Attributes["as"].Value);
            
            if (DV.Attributes["ds"].Value != "-1")
                DV_D�fenseSp� = Convert.ToDouble(DV.Attributes["ds"].Value);
            
            if (DV.Attributes["v"].Value != "-1")
                DV_Vitesse = Convert.ToDouble(DV.Attributes["v"].Value);
            

            PE_PV = Convert.ToDouble(PE.Attributes["pv"].Value);
            PE_Attaque = Convert.ToDouble(PE.Attributes["a"].Value);
            PE_D�fense = Convert.ToDouble(PE.Attributes["d"].Value);
            PE_AttaqueSp� = Convert.ToDouble(PE.Attributes["as"].Value);
            PE_D�fenseSp� = Convert.ToDouble(PE.Attributes["ds"].Value);
            PE_Vitesse = Convert.ToDouble(PE.Attributes["v"].Value);
        }

        void Constructor(XmlElement pok�mon, FileType type_de_fichier)
        {
            #region Description
            if (type_de_fichier == FileType.Description)
            {
                Nom = pok�mon.Attributes["nom"].Value;
                Num�ro = Convert.ToInt32(pok�mon.Attributes["num"].Value);

                switch (pok�mon.Attributes["type1"].Value)
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

                
                    if (pok�mon.HasAttribute("type2"))
                    {
                        switch (pok�mon.Attributes["type2"].Value)
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
                

                switch (pok�mon.Attributes["oeuf1"].Value)
                {
                    case "amorphe":
                        Oeuf1 = Esp�ce.Amorphe;
                        break;
                    case "aquatique1":
                        Oeuf1 = Esp�ce.Aquatique1;
                        break;
                    case "aquatique2":
                        Oeuf1 = Esp�ce.Aquatique2;
                        break;
                    case "aquatique3":
                        Oeuf1 = Esp�ce.Aquatique3;
                        break;
                    case "aucun":
                        Oeuf1 = Esp�ce.Aucun;
                        break;
                    case "champetre":
                        Oeuf1 = Esp�ce.Champ�tre;
                        break;
                    case "dragon":
                        Oeuf1 = Esp�ce.Dragon;
                        break;
                    case "feerique":
                        Oeuf1 = Esp�ce.F�erique;
                        break;
                    case "herbeux":
                        Oeuf1 = Esp�ce.Herbeux;
                        break;
                    case "humain":
                        Oeuf1 = Esp�ce.Humain;
                        break;
                    case "insecte":
                        Oeuf1 = Esp�ce.Insecte;
                        break;
                    case "mineral":
                        Oeuf1 = Esp�ce.Min�ral;
                        break;
                    case "monstre":
                        Oeuf1 = Esp�ce.Monstre;
                        break;
                    case "sterile":
                        Oeuf1 = Esp�ce.St�rile;
                        break;
                    case "volant":
                        Oeuf1 = Esp�ce.Volant;
                        break;
                }
                if(pok�mon.HasAttribute("oeuf2"))
                {
                    switch (pok�mon.Attributes["oeuf2"].Value)
                    {
                        case "amorphe":
                            Oeuf2 = Esp�ce.Amorphe;
                            break;
                        case "aquatique1":
                            Oeuf2 = Esp�ce.Aquatique1;
                            break;
                        case "aquatique2":
                            Oeuf2 = Esp�ce.Aquatique2;
                            break;
                        case "aquatique3":
                            Oeuf2 = Esp�ce.Aquatique3;
                            break;
                        case "aucun":
                            Oeuf2 = Esp�ce.Aucun;
                            break;
                        case "champetre":
                            Oeuf2 = Esp�ce.Champ�tre;
                            break;
                        case "dragon":
                            Oeuf2 = Esp�ce.Dragon;
                            break;
                        case "feerique":
                            Oeuf2 = Esp�ce.F�erique;
                            break;
                        case "herbeux":
                            Oeuf2 = Esp�ce.Herbeux;
                            break;
                        case "humain":
                            Oeuf2 = Esp�ce.Humain;
                            break;
                        case "insecte":
                            Oeuf2 = Esp�ce.Insecte;
                            break;
                        case "mineral":
                            Oeuf2 = Esp�ce.Min�ral;
                            break;
                        case "monstre":
                            Oeuf2 = Esp�ce.Monstre;
                            break;
                        case "sterile":
                            Oeuf2 = Esp�ce.St�rile;
                            break;
                        case "volant":
                            Oeuf2 = Esp�ce.Volant;
                            break;
                    }
                }
                

                if(pok�mon.HasAttribute("evode"))
                 evo_de = pok�mon.Attributes["evode"].Value; 
                

                Stat_PV = Convert.ToDouble(pok�mon.Attributes["pv"].Value);
                Stat_Attaque = Convert.ToDouble(pok�mon.Attributes["atq"].Value);
                Stat_D�fense = Convert.ToDouble(pok�mon.Attributes["def"].Value);
                Stat_AttaqueSp� = Convert.ToDouble(pok�mon.Attributes["as"].Value);
                Stat_D�fenseSp� = Convert.ToDouble(pok�mon.Attributes["ds"].Value);
                Stat_Vitesse = Convert.ToDouble(pok�mon.Attributes["vit"].Value);

                int NumCapSP = 0;

                foreach (XmlElement el in pok�mon.ChildNodes)
                {
                    if (el.Name == "CAPACITE")
                    {
                        Capacite c = new Capacite(el);

                        switch (c.apprentissage)
                        {
                            case Apprentissage.Level:
                                SCapacit�sLevelUp.Push(c);
                                break;
                            case Apprentissage.CT:
                                SCapacit�sCT.Push(c);
                                break;
                            case Apprentissage.CTLevel:
                                SCapacit�sLevelUp.Push(c);
                                SCapacit�sCT.Push(c);
                                break;
                            case Apprentissage.CS:
                                SCapacit�sCS.Push(c);
                                break;
                            case Apprentissage.CSLevel:
                                SCapacit�sLevelUp.Push(c);
                                SCapacit�sCS.Push(c);
                                break;
                            case Apprentissage.Oeuf:
                                SCapacit�sOeuf.Push(c);
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
                        Capacit�sSp�[NumCapSP] = el.Attributes["nom"].Value;
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

                Capacit�sLevelUp = SCapacit�sLevelUp.ToArray();
                Capacit�sCT = SCapacit�sCT.ToArray();
                Capacit�sCS = SCapacit�sCS.ToArray();
                Capacit�sOeuf = SCapacit�sOeuf.ToArray();
            }// fin if Description
            #endregion
            #region Fiche
            else if (type_de_fichier == FileType.Fiche)
            {


                //XmlElement Cap = null;
                //XmlElement Symb = null;
                //bool breakout = false;
                //foreach (XmlElement el in pok�mon)
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

                //if (pok�mon.Attributes["espece"].Value != "")
                //{

                //    Nom = pok�mon.Attributes["espece"].Value;
                //    Pseudo = pok�mon.Attributes["pseudo"].Value;

                //    if (pok�mon.Attributes["capacitespe"].Value != "")
                //        Capacit�Sp� = pok�mon.Attributes["capacitespe"].Value;
                    
                //    if (Cap.HasAttribute("nom1"))
                //        Capacit�s_fiche[0] = Xblood.GetCapacite(Cap.Attributes["nom1"].Value);
                //    if (Cap.HasAttribute("nom2"))
                //        Capacit�s_fiche[1] = Xblood.GetCapacite(Cap.Attributes["nom2"].Value);
                //    if (Cap.HasAttribute("nom3"))
                //        Capacit�s_fiche[2] = Xblood.GetCapacite(Cap.Attributes["nom3"].Value);
                //    if (Cap.HasAttribute("nom4"))
                //        Capacit�s_fiche[3] = Xblood.GetCapacite(Cap.Attributes["nom4"].Value);

                //}

                OuvrirFiche(pok�mon);

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
