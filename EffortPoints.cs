using System;
using System.Xml;

namespace URA_Pokemon
{
	public class EffortPoints
	{
        public EffortPoints() { }
		public EffortPoints(XmlElement PE)
		{
			switch (PE.Attributes["stat"].Value)
			{
				case "attaque":
					Stat = EffortPointType.Atq;
					break;
				case "defense":
					Stat = EffortPointType.Def;
					break;
				case "attaquespe":
					Stat = EffortPointType.AS;
					break;
				case "defensespe":
					Stat = EffortPointType.DS;
					break;
				case "vitesse":
					Stat = EffortPointType.Vit;
					break;
				case "pv":
					Stat = EffortPointType.PV;
					break;
			}

			Valeur = Convert.ToInt32(PE.Attributes["valeur"].Value);
		}

		public EffortPointType Stat;
		public int Valeur;
	}
}
