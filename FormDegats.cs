using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormDegats : Form
    {
        public FormDegats()
        {
            InitializeComponent();
            ComboEfficacite.SelectedIndex = 2;
        }

        private void txtNiveau_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtNiveau.Text);
                if (i > 100)
                    txtNiveau.Text = "100";
            }
            catch { txtNiveau.Text = ""; }
        }

        private void txtAttaque_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtAttaque.Text);
            }
            catch { txtAttaque.Text = ""; }
        }

        private void txtDéfense_Leave(object sender, EventArgs e)
        {
            try { Convert.ToInt32(txtDéfense.Text); }
            catch { txtDéfense.Text = ""; }
        }

        private void txtPuissance_Leave(object sender, EventArgs e)
        {
            try { Convert.ToInt32(txtPuissance.Text); }
            catch { txtPuissance.Text = ""; }
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                double N = Convert.ToDouble(txtNiveau.Text);
                double A = Convert.ToDouble(txtAttaque.Text);
                double E = Convert.ToDouble(ComboEfficacite.Text.Substring(1));
                double D = Convert.ToDouble(txtDéfense.Text);
                double F = Convert.ToDouble(txtPuissance.Text);
                double S;
                if (chkSTAB.Checked)
                    S = 1.5;
                else
                    S = 1;
                double C;
                if (chkCritique.Checked)
                    C = 2;
                else
                    C = 1;
                double R = Convert.ToDouble(NudRandom.Value);
                lbResultat.Text = Convert.ToString(Math.Truncate(((((2 * N * C / 5 + 2) * A * F / D) / 50 + 2) * S * E * R / 255)));
            }
            catch { }
        }
    }
}