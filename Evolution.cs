using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace URA_Pokemon
{
    public class Evolution
    {
        public string nom;
        public EvoType evotype;
        public int level;

        public Evolution() { }
        public Evolution(XmlElement evo)
        {
            nom = evo.Attributes["nom"].Value;
            switch (evo.Attributes["evo"].Value)
            {
                case "niveau":
                    evotype = EvoType.niveau;
                    break;
                case "pierre_feu":
                    evotype = EvoType.pierre_feu;
                    break;
                case "pierre_eau":
                    evotype = EvoType.pierre_eau;
                    break;
                case "pierre_foudre":
                    evotype = EvoType.pierre_foudre;
                    break;
                case "pierre_plante":
                    evotype = EvoType.pierre_plante;
                    break;
                case "pierre_soleil":
                    evotype = EvoType.pierre_soleil;
                    break;
                case "pierre_lune":
                    evotype = EvoType.pierre_lune;
                    break;
                case "bonheur":
                    evotype = EvoType.bonheur;
                    break;
                case "malheur":
                    evotype = EvoType.malheur;
                    break;
                case "echange":
                    evotype = EvoType.echange;
                    break;
                case "echange_avec_objet":
                    evotype = EvoType.echange_avec_objet;
                    break;
                case "beaute":
                    evotype = EvoType.beaute;
                    break;
                case "special":
                    evotype = EvoType.special;
                    break;
                default:
                    break;
            }
            if (evotype == EvoType.niveau)
                level = Convert.ToInt32(evo.Attributes["niveau"].Value);
        }
    }
}
