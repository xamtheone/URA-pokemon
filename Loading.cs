using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace URA_Pokemon
{
    public partial class Loading : Form
    {
        Form f;

        delegate void IncrementCallBack();
        delegate void CloseForm();

        public Loading(Form FormToShow)
        {
            InitializeComponent();
            Xblood.PokemonAddedtoPKlist += new EventHandler(Xblood_PokemonAddedtoPKlist);
            Xblood.PKlistFull += new EventHandler(Xblood_ListFull);
            Xblood.CapaciteAddedtoClist += new EventHandler(Xblood_CapaciteAddedtoClist);
            Xblood.ClistFull += new EventHandler(Xblood_ClistFull);
            Xblood.CapSpeAddedtoClist += new EventHandler(Xblood_CapSpeAddedtoClist);
            Xblood.CSlistFull += new EventHandler(Xblood_CSlistFull);
            f = FormToShow;
        }

        void Xblood_CSlistFull(object sender, EventArgs e)
        {
            CloseForm cf = new CloseForm(CloseThis);
            this.Invoke(cf);
        }

        void Xblood_CapSpeAddedtoClist(object sender, EventArgs e)
        {
            IncrementCallBack i = new IncrementCallBack(IncrementProgressBar);
            this.Invoke(i);
        }

        void Xblood_ClistFull(object sender, EventArgs e)
        {
            Xblood.FillCSlist();
        }

        void Xblood_CapaciteAddedtoClist(object sender, EventArgs e)
        {
            IncrementCallBack i = new IncrementCallBack(IncrementProgressBar);
            this.Invoke(i);
        }

        void Xblood_ListFull(object sender, EventArgs e)
        {
            Xblood.FillTypesExistants();
            Xblood.FillClist();
        }

        void CloseThis()
        {
            this.Close();
        }

        void Xblood_PokemonAddedtoPKlist(object sender, EventArgs e)
        {
            IncrementCallBack i = new IncrementCallBack(IncrementProgressBar);
            this.Invoke(i);
        }

        void IncrementProgressBar()
        {
            progressBar1.Value++;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"DescriptionPokemon\", "*.xml");
            progressBar1.Maximum = files.Length;
            files = Directory.GetFiles(@"DescriptionCapacites\", "*.xml");
            progressBar1.Maximum += files.Length;
            files = Directory.GetFiles(@"DescriptionCapSpe\", "*.xml");
            progressBar1.Maximum += files.Length;
            Thread t = new Thread(new ThreadStart(Xblood.FillPKlist));
            t.Priority = ThreadPriority.BelowNormal;
            t.Start();
        }

        private void Loading_FormClosed(object sender, FormClosedEventArgs e)
        {

            f.Show();
        }

    }
}