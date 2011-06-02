using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace URA_Pokemon
{
    public class EquipeExport
    {
        
        public Pokemon[] Pokemons;

        private string _file;
        [XmlIgnore]
        public string file
        { get { return _file; } }

        public void Save(string file)
        {
            Stream s = File.Open(file, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(EquipeExport));
            xs.Serialize(s, this);
            s.Close();
            _file = file;
        }

        public void Load(string file)
        {
            Stream s = File.OpenRead(file);
            XmlSerializer xs = new XmlSerializer(typeof(EquipeExport));
            EquipeExport e = (EquipeExport)xs.Deserialize(s);
            s.Close();
            _file = file;

            this.Pokemons = e.Pokemons;
            foreach (Pokemon p in this.Pokemons)
            {
                if (p != null)
                {
                    for (int i = 0; i < p.Capacités_fiche.Length;i++)
                    {

                        if (p.Capacités_fiche[i] != null)
                            p.Capacités_fiche[i] = p.Capacités_fiche[i].GetComplete();
                    }
                }
            }
        }
    }
}
