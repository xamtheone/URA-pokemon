using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormStats : Form
    {
        string[] NatureNoms = new string[25];
        double[][] NatureValeurs = new double[25][];
        Xblood xb;
        public FormStats()
        {
            InitializeComponent();
        }

        private void ComboPokémon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //TODO modifier l'accès par l'index du combo
                Pokemon p = xb.PKlist[ComboPokémon.SelectedIndex];
                txtPV.Text = p.Stat_PV.ToString();
                txtAttaque.Text = p.Stat_Attaque.ToString();
                txtDéfense.Text = p.Stat_Défense.ToString();
                txtAS.Text = p.Stat_AttaqueSpé.ToString();
                txtDS.Text = p.Stat_DéfenseSpé.ToString();
                txtVitesse.Text = p.Stat_Vitesse.ToString();
            }
            catch { }
        }

        void FillComboPokémon()
        {
            ComboPokémon.Text = "";
            ComboPokémon.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
                ComboPokémon.Items.Add(p.Nom);
        }

        void FillComboNature()
        {
            //Valeurs (A, D, V, AS, DS)
            NatureValeurs[0] = new double[] { 0.9, 1.1, 1, 1, 1 };
            NatureValeurs[1] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[2] = new double[] { 1.1, 1, 0.9, 1, 1 };
            NatureValeurs[3] = new double[] { 0.9, 1, 1, 1, 1.1 };
            NatureValeurs[4] = new double[] { 1, 1, 0.9, 1.1, 1 };
            NatureValeurs[5] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[6] = new double[] { 1, 0.9, 1, 1.1, 1 };
            NatureValeurs[7] = new double[] { 1, 1, 1, 1.1, 0.9 };
            NatureValeurs[8] = new double[] { 1, 0.9, 1, 1, 1.1 };
            NatureValeurs[9] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[10] = new double[] { 1, 1, 1.1, 0.9, 1 };
            NatureValeurs[11] = new double[] { 1, 1.1, 1, 1, 0.9 };
            NatureValeurs[12] = new double[] { 1, 1.1, 1, 0.9, 1 };
            NatureValeurs[13] = new double[] { 1, 1, 0.9, 1, 1.1 };
            NatureValeurs[14] = new double[] { 1.1, 1, 1, 1, 0.9 };
            NatureValeurs[15] = new double[] { 0.9, 1, 1, 1.1, 1 };
            NatureValeurs[16] = new double[] { 1, 1, 1.1, 1, 0.9 };
            NatureValeurs[17] = new double[] { 1, 0.9, 1.1, 1, 1 };
            NatureValeurs[18] = new double[] { 1, 1, 1, 0.9, 1.1 };
            NatureValeurs[19] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[20] = new double[] { 1, 1.1, 0.9, 1, 1 };
            NatureValeurs[21] = new double[] { 1.1, 1, 1, 0.9, 1 };
            NatureValeurs[22] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[23] = new double[] { 1.1, 0.9, 1, 1, 1 };
            NatureValeurs[24] = new double[] { 0.9, 1, 1.1, 1, 1 };

            //Noms
            NatureNoms[0] = "Assuré(A-, D+)";
            NatureNoms[1] = "Bizarre";
            NatureNoms[2] = "Brave(A+, V-)";
            NatureNoms[3] = "Calme(A-, DS+)";
            NatureNoms[4] = "Discret(V-, AS+)";
            NatureNoms[5] = "Docile";
            NatureNoms[6] = "Doux(AS+, D-)";
            NatureNoms[7] = "Foufou(DS-, AS+)";
            NatureNoms[8] = "Gentil(D-, DS+)";
            NatureNoms[9] = "Hardi";
            NatureNoms[10] = "Jovial(AS-, V+)";
            NatureNoms[11] = "Laché(D+, DS-)";
            NatureNoms[12] = "Malin(AS-, D+)";
            NatureNoms[13] = "Malpoli(V-, DS+)";
            NatureNoms[14] = "Mauvais(A+, DS-)";
            NatureNoms[15] = "Modeste(A-, AS+)";
            NatureNoms[16] = "Naïf(DS-, V+)";
            NatureNoms[17] = "Pressé(V+, D-)";
            NatureNoms[18] = "Prudent(AS-, DS+)";
            NatureNoms[19] = "Pudique";
            NatureNoms[20] = "Relax(D+, V-)";
            NatureNoms[21] = "Rigide(A+, AS-)";
            NatureNoms[22] = "Sérieux";
            NatureNoms[23] = "Solo(A+, D-)";
            NatureNoms[24] = "Timide(A-, V+)";

            foreach (string str in NatureNoms)
                ComboNature.Items.Add(str);
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            Calculer();
        }

        void Calculer()
        {
            dataGridView1.Rows.Clear();
            double PV;
            double A;
            double D;
            double AS;
            double DS;
            double V;
            double[] Nature = new double[] { 1, 1, 1, 1, 1 };
            double PE;
            double PEpv;
            double PEa;
            double PEd;
            double PEas;
            double PEds;
            double PEv;
            double Niveau;
            try { PV = Convert.ToDouble(txtPV.Text); }
            catch { PV = 0; }
            try { A = Convert.ToDouble(txtAttaque.Text); }
            catch { A = 0; }
            try { D = Convert.ToDouble(txtDéfense.Text); }
            catch { D = 0; }
            try { AS = Convert.ToDouble(txtAS.Text); }
            catch { AS = 0; }
            try { DS = Convert.ToDouble(txtDS.Text); }
            catch { DS = 0; }
            try { V = Convert.ToDouble(txtVitesse.Text); }
            catch { V = 0; }
            try
            {
                if (ComboNature.Text != "")
                    Nature = NatureValeurs[ComboNature.SelectedIndex];
            }
            catch{}

            if (chkPEmax.Checked)
            {
                PE = 255;
                PEpv = PE;
                PEa = PE;
                PEd = PE;
                PEas = PE;
                PEds = PE;
                PEv = PE;
            }
            else if (!chkParStat.Checked)
            {
                PE = Convert.ToDouble(NumUDPEgeneral.Value);
                PEpv = PE;
                PEa = PE;
                PEd = PE;
                PEas = PE;
                PEds = PE;
                PEv = PE;
            }
            else
            {
                PEpv = Convert.ToDouble(NumUDPV.Value);
                PEa = Convert.ToDouble(NumUDAttaque.Value);
                PEd = Convert.ToDouble(NumUDDéfense.Value);
                PEas = Convert.ToDouble(NumUDAS.Value);
                PEds = Convert.ToDouble(NumUDDS.Value);
                PEv = Convert.ToDouble(NumUDVitesse.Value);
            }
            try
            {
                if (txtNiveau.Text != "")
                    Niveau = Convert.ToDouble(txtNiveau.Text);
                else
                    Niveau = 0;
            }
            catch
            {
                Niveau = 0;
            }
            
            for (int dv = 0; dv <= 31; dv++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.Height = 18;
                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                c.Value = dv;
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (PV != 0)
                {
                    double pv = Math.Truncate(((2 * PV + dv + Math.Truncate(PEpv / 4)) * Niveau / 100 + 10 + Niveau));
                    c.Value = pv;
                }
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (A != 0)
                {
                    double a = Math.Truncate(Math.Truncate((2 * A + dv + Math.Truncate(PEa / 4)) * Niveau / 100 + 5) * Nature[0]);
                    c.Value = a;
                }
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (D != 0)
                {
                    double d = Math.Truncate(Math.Truncate((2 * D + dv + Math.Truncate(PEd / 4)) * Niveau / 100 + 5) * Nature[1]);
                    c.Value = d;
                }
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (AS != 0)
                {
                    double a = Math.Truncate(Math.Truncate((2 * AS + dv + Math.Truncate(PEas / 4)) * Niveau / 100 + 5) * Nature[3]);
                    c.Value = a;
                }
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (DS != 0)
                {
                    double ds = Math.Truncate(Math.Truncate((2 * DS + dv + Math.Truncate(PEds / 4)) * Niveau / 100 + 5) * Nature[4]);
                    c.Value = ds;
                }
                r.Cells.Add(c);
                c = new DataGridViewTextBoxCell();
                if (V != 0)
                {
                    double v = Math.Truncate(Math.Truncate((2 * V + dv + Math.Truncate(PEv / 4)) * Niveau / 100 + 5) * Nature[2]);
                    c.Value = v;
                }
                r.Cells.Add(c);
                dataGridView1.Rows.Add(r);
            }
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPokémon();
            FillComboNature();
        }

        private void chkPEmax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPEmax.Checked)
            {
                NumUDPEgeneral.Enabled = false;
                chkParStat.Enabled = false;
                NumUDPV.Enabled = false;
                NumUDAttaque.Enabled = false;
                NumUDDéfense.Enabled = false;
                NumUDAS.Enabled = false;
                NumUDDS.Enabled = false;
                NumUDVitesse.Enabled = false;
            }
            else
            {
                NumUDPEgeneral.Enabled = true;
                chkParStat.Enabled = true;
            }
        }

        private void chkParStat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParStat.Checked)
            {
                chkPEmax.Enabled = false;
                NumUDPEgeneral.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = true;
                label13.Enabled = true;
                label14.Enabled = true;
                label15.Enabled = true;
                label16.Enabled = true;
                NumUDAS.Enabled = true;
                NumUDAttaque.Enabled = true;
                NumUDDéfense.Enabled = true;
                NumUDDS.Enabled = true;
                NumUDPV.Enabled = true;
                NumUDVitesse.Enabled = true;

            }
            else
            {
                chkPEmax.Enabled = true;
                NumUDPEgeneral.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                NumUDAS.Enabled = false;
                NumUDAttaque.Enabled = false;
                NumUDDéfense.Enabled = false;
                NumUDDS.Enabled = false;
                NumUDPV.Enabled = false;
                NumUDVitesse.Enabled = false;
            }
        }

        private void txtNiveau_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtNiveau.Text);
            }
            catch
            {
                txtNiveau.Text = "";
            }
        }
    }
}