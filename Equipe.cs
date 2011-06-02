using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace URA_Pokemon
{
    public class Equipe
    {
        public string[] PokemonsFiles;

        [XmlIgnore]
        public Pokemon[] Pokemons;

        private string _file;
        [XmlIgnore]
        public string file
        { get { return _file; } }

        public void Save(string file)
        {
            Stream s = File.Open(file, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Equipe));
            xs.Serialize(s, this);
            s.Close();
            _file = file;
        }

        public void Load(string file)
        {
            Stream s = File.OpenRead(file);
            XmlSerializer xs = new XmlSerializer(typeof(Equipe));
            Equipe e = (Equipe)xs.Deserialize(s);
            s.Close();
            _file = file;

            this.PokemonsFiles = e.PokemonsFiles;
        }

        public void LoadPokemons()
        {
            if (PokemonsFiles != null)
            {
                Pokemons = new Pokemon[6];
                int i = 0;
                foreach (string file in PokemonsFiles)
                {
                    if (file != null && File.Exists(file))
                    {
                        Pokemon p = new Pokemon(file, FileType.Fiche);
                        Pokemons[i] = p;
                        
                    }
                    i++;
                }
            }
        }
    }
}
