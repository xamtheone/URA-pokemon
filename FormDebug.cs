using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace URA_Pokemon
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        private void btSerializer_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            Pokemon p = new Pokemon(@"DescriptionPokemon\Pikachu.xml", FileType.Description);
            sw.Start();
            XmlSerializer xs = null;
            try
            {
               xs  = new XmlSerializer(typeof(Pokemon));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return;
            }
            sw.Stop();
            MessageBox.Show("Instance XmlSerializer: " + sw.Elapsed.TotalMilliseconds.ToString());
            sw.Reset();
            Stream s = File.Create("pokétest.xml");
            sw.Start();
            xs.Serialize(s, p);
            sw.Stop();
            s.Close();
            MessageBox.Show("Serialization: " + sw.Elapsed.TotalMilliseconds.ToString());
        }

        private void btDéserializer_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Pokemon p = new Pokemon(@"DescriptionPokemon\Pikachu.xml", FileType.Description);
            sw.Stop();
            MessageBox.Show("Load classic: " + sw.Elapsed.TotalMilliseconds.ToString());
            sw.Reset();
            XmlSerializer xs = new XmlSerializer(typeof(Pokemon));
            sw.Stop();
            MessageBox.Show("Instance XmlSerializer: " + sw.Elapsed.TotalMilliseconds.ToString());
            sw.Reset();
            Stream s = File.OpenRead("pokétest.xml");
            sw.Start();
            Pokemon p2 = (Pokemon)xs.Deserialize(s);
            sw.Stop();
            s.Close();
            MessageBox.Show("Déserialization: " + sw.Elapsed.TotalMilliseconds.ToString());
        }
    }
}