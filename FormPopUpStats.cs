using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormPopUpStats : Form
    {
        FormFiltrer _Parent;
        Filtre2 _Parent2;
        public FormPopUpStats(FormFiltrer parent)
        {
            InitializeComponent();
            _Parent = parent;
            chkPV.Checked = _Parent.PV;
            chkAttaque.Checked = _Parent.Attaque;
            chkDéfense.Checked = _Parent.Défense;
            chkAS.Checked = _Parent.AS;
            chkDS.Checked = _Parent.DS;
            chkVitesse.Checked = _Parent.Vitesse;
        }
        public FormPopUpStats(Filtre2 parent)
        {
            InitializeComponent();
            _Parent2 = parent;
            chkPV.Checked = _Parent2.PV;
            chkAttaque.Checked = _Parent2.Attaque;
            chkDéfense.Checked = _Parent2.Défense;
            chkAS.Checked = _Parent2.AS;
            chkDS.Checked = _Parent2.DS;
            chkVitesse.Checked = _Parent2.Vitesse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_Parent!= null)
        {
            _Parent.PV = chkPV.Checked;
            _Parent.Attaque = chkAttaque.Checked;
            _Parent.Défense = chkDéfense.Checked;
            _Parent.AS = chkAS.Checked;
            _Parent.DS = chkDS.Checked;
            _Parent.Vitesse = chkVitesse.Checked;
        }
        else if (_Parent2 != null)
        {
            _Parent2.PV = chkPV.Checked;
            _Parent2.Attaque = chkAttaque.Checked;
            _Parent2.Défense = chkDéfense.Checked;
            _Parent2.AS = chkAS.Checked;
            _Parent2.DS = chkDS.Checked;
            _Parent2.Vitesse = chkVitesse.Checked;
        }
            this.Close();
        }
    }
}