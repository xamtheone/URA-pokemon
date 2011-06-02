using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace URA_Pokemon
{
    public class CapSpe
    {
        public string nom;
        public string description;

        public CapSpe(string file)
        {
            XmlDocument dom = new XmlDocument();
            dom.Load(file);
            XmlElement root = dom.DocumentElement;
            nom = root.Attributes["nom"].Value;
            description = root.Attributes["description"].Value;
        }
    }
}
