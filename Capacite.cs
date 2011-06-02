using System;
using System.Xml;
using System.Xml.Serialization;

namespace URA_Pokemon
{
    public class Capacite
    {
        public string Nom;
        [XmlIgnore]
        public Type TypeAttaque = Type.AUCUN;
        [XmlIgnore]
        public double Force;
        [XmlIgnore]
        public double Précision;
        [XmlIgnore]
        public int pp;
        [XmlIgnore]
        public int numCT;
        [XmlIgnore]
        public int numCS;
        [XmlIgnore]
        public string Description;
        [XmlIgnore]
        public NatureDegat NatureDegat = NatureDegat.NULL; //Attaque physique, spéciale, ou aucune

        [XmlIgnore]
        public Apprentissage apprentissage;
        [XmlIgnore]
        public int NiveauApprentissage;

        [XmlIgnore]
        public double effect_Attaque;
        [XmlIgnore]
        public double effect_Défense;
        [XmlIgnore]
        public double effect_Vitesse;
        [XmlIgnore]
        public double effect_AttaqueSpé;
        [XmlIgnore]
        public double effect_DéfenseSpé;

        [XmlIgnore]
        public double self_PV;
        [XmlIgnore]
        public double self_Attaque;
        [XmlIgnore]
        public double self_Défense;
        [XmlIgnore]
        public double self_Vitesse;
        [XmlIgnore]
        public double self_AttaqueSpé;
        [XmlIgnore]
        public double self_DéfenseSpé;

        public Capacite() { }
        public Capacite(XmlElement capacite)
        {
            Nom = capacite.Attributes["nom"].Value;

            switch (capacite.Attributes["apprentissage"].Value)
            {
                case "Level":
                    apprentissage = Apprentissage.Level;
                    break;
                case "CTLevel":
                    apprentissage = Apprentissage.CTLevel;
                    break;
                case "CT":
                    apprentissage = Apprentissage.CT;
                    break;
                case "CSLevel":
                    apprentissage = Apprentissage.CSLevel;
                    break;
                case "CS":
                    apprentissage = Apprentissage.CS;
                    break;
                case "Oeuf":
                    apprentissage = Apprentissage.Oeuf;
                    break;
            }

            try
            {
                NiveauApprentissage = Convert.ToInt32(capacite.Attributes["niveau"].Value);
            }
            catch { }


        }

        public Capacite(string file)
        {
            XmlDocument dom = new XmlDocument();
            dom.Load(file);
            XmlElement root = dom.DocumentElement;
            Nom = root.Attributes["nom"].Value;
            switch (root.Attributes["type"].Value)
            {
                case "ACIER":
                    TypeAttaque = Type.ACIER;
                    break;
                case "COMBAT":
                    TypeAttaque = Type.COMBAT;
                    break;
                case "DRAGON":
                    TypeAttaque = Type.DRAGON;
                    break;
                case "EAU":
                    TypeAttaque = Type.EAU;
                    break;
                case "ELECTRIK":
                    TypeAttaque = Type.ELECTRIK;
                    break;
                case "FEU":
                    TypeAttaque = Type.FEU;
                    break;
                case "GLACE":
                    TypeAttaque = Type.GLACE;
                    break;
                case "INSECTE":
                    TypeAttaque = Type.INSECTE;
                    break;
                case "NORMAL":
                    TypeAttaque = Type.NORMAL;
                    break;
                case "PLANTE":
                    TypeAttaque = Type.PLANTE;
                    break;
                case "POISON":
                    TypeAttaque = Type.POISON;
                    break;
                case "PSY":
                    TypeAttaque = Type.PSY;
                    break;
                case "ROCHE":
                    TypeAttaque = Type.ROCHE;
                    break;
                case "SOL":
                    TypeAttaque = Type.SOL;
                    break;
                case "SPECTRE":
                    TypeAttaque = Type.SPECTRE;
                    break;
                case "TENEBRES":
                    TypeAttaque = Type.TENEBRES;
                    break;
                case "VOL":
                    TypeAttaque = Type.VOL;
                    break;
            }
            Force = Convert.ToDouble(root.Attributes["force"].Value);
            Précision = Convert.ToDouble(root.Attributes["precision"].Value);
            pp = Convert.ToInt32(root.Attributes["pp"].Value);
            try { numCT = Convert.ToInt32(root.Attributes["numct"].Value); }
            catch { }
            try { numCS = Convert.ToInt32(root.Attributes["numcs"].Value); }
            catch { }
            Description = root.Attributes["description"].Value;

            try
            {
                if (!root.HasAttribute("naturedegat"))
                    NatureDegat = NatureDegat.NULL;
                else
                {

                    switch (root.Attributes["naturedegat"].Value)
                    {
                        case "Physique":
                            NatureDegat = NatureDegat.Physique;
                            break;
                        case "Special":
                            NatureDegat = NatureDegat.Special;
                            break;
                        case "Aucun":
                            NatureDegat = NatureDegat.Aucun;
                            break;
                        default:
                            NatureDegat = NatureDegat.NULL;
                            break;
                    }
                }
            }
            catch { }
        }

        public Capacite GetComplete()
        {
            return Xblood.GetCapacite(this);
        }
    }
}
