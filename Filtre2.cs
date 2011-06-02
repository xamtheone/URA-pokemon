using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class Filtre2 : Form
    {
        public bool PV;
        public bool Attaque;
        public bool Défense;
        public bool AS;
        public bool DS;
        public bool Vitesse;
        Xblood xb;

        int nbpoke = 0;

        public Filtre2()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPopUpStats f = new FormPopUpStats(this);
            f.ShowDialog();
        }

        private void type1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudattspé_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btfiltre_Click(object sender, EventArgs e)
        {
            nbpoke = 0;
            dgvListePK.Rows.Clear();
            try
            {
                foreach (Pokemon p in xb.PKlist)
                {
                    if (CheckPokemon(p))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell cellNum = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellNom = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellType1 = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellType2 = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellPV = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellA = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellD = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellAS = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellDS = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellV = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellMoyR = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellMoy = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellOeuf1 = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellOeuf2 = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpePV = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpeA = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpeD = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpeAS = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpeDS = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell cellpeV = new DataGridViewTextBoxCell();

                        cellNum.Value = p.Numéro;
                        cellNom.Value = p.Nom;

                        cellType1.Value = p.Type1;
                        cellType2.Value = p.Type2;

                        cellPV.Value = p.Stat_PV;
                        cellA.Value = p.Stat_Attaque;
                        cellD.Value = p.Stat_Défense;
                        cellAS.Value = p.Stat_AttaqueSpé;
                        cellDS.Value = p.Stat_DéfenseSpé;
                        cellV.Value = p.Stat_Vitesse;

                        string moy = Convert.ToString((p.Stat_PV + p.Stat_Attaque + p.Stat_Défense + p.Stat_AttaqueSpé + p.Stat_DéfenseSpé + p.Stat_Vitesse) / 6);
                        string[] t = moy.Split(",".ToCharArray());
                        if (t.Length > 1 && t[1].Length > 2)
                            moy = t[0] + "," + t[1].Substring(0, 2);
                        cellMoy.Value = Convert.ToDouble(moy);



                        if (txtmoy.Text != "")
                        {
                            double moyenne = 0;
                            double div = 0;

                            if (PV)
                            {
                                moyenne += p.Stat_PV;
                                div++;
                            }
                            if (Attaque)
                            {
                                moyenne += p.Stat_Attaque;
                                div++;
                            }
                            if (Défense)
                            {
                                moyenne += p.Stat_Défense;
                                div++;
                            }
                            if (AS)
                            {
                                moyenne += p.Stat_AttaqueSpé;
                                div++;
                            }
                            if (DS)
                            {
                                moyenne += p.Stat_DéfenseSpé;
                                div++;
                            }
                            if (Vitesse)
                            {
                                moyenne += p.Stat_Vitesse;
                                div++;
                            }

                            moy = Convert.ToString(moyenne / div);
                            t = moy.Split(",".ToCharArray());
                            if (t.Length > 1 && t[1].Length > 2)
                                moy = t[0] + "," + t[1].Substring(0, 2);
                            cellMoyR.Value = Convert.ToDouble(moy);

                        }
                        else
                        {
                            cellMoyR.Value = Convert.ToDouble(moy);
                        }

                        cellOeuf1.Value = p.Oeuf1;
                        cellOeuf2.Value = p.Oeuf2;

                        cellpeA.Value = 0;
                        cellpeD.Value = 0;
                        cellpeAS.Value = 0;
                        cellpeDS.Value = 0;
                        cellpeV.Value = 0;
                        cellpePV.Value = 0;

                        foreach (EffortPoints pe in p.PE)
                        {
                            switch (pe.Stat)
                            {
                                case EffortPointType.Atq:
                                    cellpeA.Value = pe.Valeur;
                                    break;
                                case EffortPointType.Def:
                                    cellpeD.Value = pe.Valeur;
                                    break;
                                case EffortPointType.AS:
                                    cellpeAS.Value = pe.Valeur;
                                    break;
                                case EffortPointType.DS:
                                    cellpeDS.Value = pe.Valeur;
                                    break;
                                case EffortPointType.Vit:
                                    cellpeV.Value = pe.Valeur;
                                    break;
                                case EffortPointType.PV:
                                    cellpePV.Value = pe.Valeur;
                                    break;
                                default:
                                    break;
                            }
                        }

                        row.Cells.Add(cellNum);
                        row.Cells.Add(cellNom);
                        row.Cells.Add(cellType1);
                        row.Cells.Add(cellType2);
                        row.Cells.Add(cellPV);
                        row.Cells.Add(cellA);
                        row.Cells.Add(cellD);
                        row.Cells.Add(cellAS);
                        row.Cells.Add(cellDS);
                        row.Cells.Add(cellV);
                        row.Cells.Add(cellMoyR);
                        row.Cells.Add(cellMoy);
                        row.Cells.Add(cellOeuf1);
                        row.Cells.Add(cellOeuf2);
                        row.Cells.Add(cellpePV);
                        row.Cells.Add(cellpeA);
                        row.Cells.Add(cellpeD);
                        row.Cells.Add(cellpeAS);
                        row.Cells.Add(cellpeDS);
                        row.Cells.Add(cellpeV);

                        dgvListePK.Rows.Add(row);
                    }
                } Console.WriteLine("nbpoke =" + nbpoke);
                Console.WriteLine("total =" + dgvListePK.Rows.Count);
            }

            catch
            {
                MessageBox.Show("Une erreur est survenu! Les données saisient sont elles correct?");
                dgvListePK.Rows.Clear();
            }
        }

        bool CheckPokemon(Pokemon p)
        {
            if (!CheckType1(p)) return false;
            if (!CheckType2(p)) return false;
            if (!CheckPV(p)) return false;
            if (!CheckAtt(p)) return false;
            if (!CheckDef(p)) return false;
            if (!CheckAttSpe(p)) return false;
            if (!CheckDefSpe(p)) return false;
            if (!CheckVit(p)) return false;

            int pv = 0;
            int a = 0;
            int d = 0;
            int asp = 0;
            int ds = 0;
            int v = 0;

            foreach (EffortPoints pe in p.PE)
            {
                switch (pe.Stat)
                {
                    case EffortPointType.Atq:
                        a = pe.Valeur;
                        break;
                    case EffortPointType.Def:
                        d = pe.Valeur;
                        break;
                    case EffortPointType.AS:
                        asp = pe.Valeur;
                        break;
                    case EffortPointType.DS:
                        ds = pe.Valeur;
                        break;
                    case EffortPointType.Vit:
                        v = pe.Valeur;
                        break;
                    case EffortPointType.PV:
                        pv = pe.Valeur;
                        break;
                    default:
                        break;
                }
            }

            if (!CheckEVPV(pv)) return false;
            if (!CheckEVAtt(a)) return false;
            if (!CheckEVDef(d)) return false;
            if (!CheckEVAttSpe(asp)) return false;
            if (!CheckEVDefSpe(ds)) return false;
            if (!CheckEVVit(v)) return false;
            if (!CheckCapacite1(p)) return false;
            if (!CheckCapacite2(p)) return false;
            if (!CheckCapacite3(p)) return false;
            if (!CheckCapacite4(p)) return false;
            if (!CheckOeuf1(p)) return false;
            if (!CheckOeuf2(p)) return false;
            if (!CheckVulnerabilite(p)) return false;
            if (!CheckMoyenne(p)) return false;
            if (!CheckCapaciteSpe(p)) return false;

            nbpoke++;
            return true;

        }

        private bool CheckCapaciteSpe(Pokemon p)
        {
            if (cbcapspé.SelectedIndex != -1)
            {
                bool valid = false;
                foreach (string str in p.CapacitésSpé)
                {
                    if (str == cbcapspé.Text)
                        valid = true;
                }

                if (!valid)
                    return false;
            }
            return true;
        }

        private bool CheckMoyenne(Pokemon p)
        {
            if (txtmoy.Text != "")
            {
                double moyenne = 0;
                double div = 0;

                if (PV)
                {
                    moyenne += p.Stat_PV;
                    div++;
                }
                if (Attaque)
                {
                    moyenne += p.Stat_Attaque;
                    div++;
                }
                if (Défense)
                {
                    moyenne += p.Stat_Défense;
                    div++;
                }
                if (AS)
                {
                    moyenne += p.Stat_AttaqueSpé;
                    div++;
                }
                if (DS)
                {
                    moyenne += p.Stat_DéfenseSpé;
                    div++;
                }
                if (Vitesse)
                {
                    moyenne += p.Stat_Vitesse;
                    div++;
                }

                moyenne = moyenne / div;

                double var = Convert.ToDouble(txtmoy.Text);
                if (moyenne < Convert.ToDouble(txtmoy.Text))
                    return false;
            }
            return true;
        }

        private bool CheckVulnerabilite(Pokemon p)
        {
            if (cbvul1.SelectedIndex != -1 && cbvul2.Text != "-" && cbvul1.Text != "-" && cbvul2.SelectedIndex != -1)
            {
                int t0 = cbvul2.SelectedIndex - 1;
                int t1 = (int)p.Type1;
                int t2 = (int)p.Type2;

                switch (cbvul1.Text)
                {
                    case "Neutre":
                        if (p.Type2 == Type.AUCUN)
                        {
                            if (Xblood.Types[t0, t1] != 0)
                                return false;
                        }
                        else
                        {
                            if (Xblood.Types[t0, t1] + Xblood.Types[t0, t2] != 0)
                                return false;
                        }
                        break;
                    case "Faible":
                        if (p.Type2 == Type.AUCUN)
                        {
                            if (Xblood.Types[t0, t1] < 2 || Xblood.Types[t0, t1] == 7)
                                return false;
                        }
                        else
                        {
                            if (Xblood.Types[t0, t1] + Xblood.Types[t0, t2] < 2 || Xblood.Types[t0, t1] == 7 || Xblood.Types[t0, t2] == 7)
                                return false;
                        }
                        break;
                    case "Resistant":
                        if (p.Type2 == Type.AUCUN)
                        {
                            if (Xblood.Types[t0, t1] > -2 && Xblood.Types[t0, t1] != 7)
                                return false;
                        }
                        else
                        {
                            if (Xblood.Types[t0, t1] + Xblood.Types[t0, t2] > -2 && Xblood.Types[t0, t1] != 7 && Xblood.Types[t0, t2] != 7)
                                return false;
                        }
                        break;
                    case "Immunisé":
                        if (p.Type2 == Type.AUCUN)
                        {
                            if (Xblood.Types[t0, t1] != 7)
                                return false;
                        }
                        else
                        {
                            if (Xblood.Types[t0, t1] != 7 && Xblood.Types[t0, t2] != 7)
                                return false;
                        }
                        break;
                }
            }
            return true;
        }

        private bool CheckOeuf2(Pokemon p)
        {
            if (cboeuf2.SelectedIndex != -1 && cboeuf2.Text != "-")
            {
                if (cboeuf2.Text != p.Oeuf1.ToString() && cboeuf2.Text != p.Oeuf2.ToString())
                    return false;
            }
            return true;
        }

        private bool CheckOeuf1(Pokemon p)
        {
            if (cboeuf1.SelectedIndex != -1 && cboeuf1.Text != "-")
            {
                if (cboeuf1.Text != p.Oeuf1.ToString() && cboeuf1.Text != p.Oeuf2.ToString())
                    return false;
            }
            return true;
        }

        private bool CheckCapacite4(Pokemon p)
        {
            if (cbcap4.SelectedIndex != -1 && cbcap4.Text != "-")
            {
                Capacite c = new Capacite();
                c.Nom = cbcap4.Text;

                if (!Xblood.HasMove(p, c))
                    return false;
            }
            return true;
        }

        private bool CheckCapacite3(Pokemon p)
        {
            if (cbcap3.SelectedIndex != -1 && cbcap3.Text != "-")
            {
                Capacite c = new Capacite();
                c.Nom = cbcap3.Text;

                if (!Xblood.HasMove(p, c))
                    return false;
            }
            return true;
        }

        private bool CheckCapacite2(Pokemon p)
        {
            if (cbcap2.SelectedIndex != -1 && cbcap2.Text != "-")
            {
                Capacite c = new Capacite();
                c.Nom = cbcap2.Text;

                if (!Xblood.HasMove(p, c))
                    return false;
            }
            return true;
        }

        private bool CheckCapacite1(Pokemon p)
        {
            if (cbcap1.SelectedIndex != -1 && cbcap1.Text != "-")
            {
                Capacite c = new Capacite();
                c.Nom = cbcap1.Text;

                if (!Xblood.HasMove(p, c))
                    return false;
            }
            return true;
        }

        private bool CheckEVVit(int v)
        {
            if (cbevvit.SelectedIndex != -1 && cbevvit.Text != "-")
            {
                switch (cbevvit.Text)
                {
                    case "<":
                        if (v >= Convert.ToInt32(nudevvit.Text))
                            return false;
                        break;
                    case "<=":
                        if (v > Convert.ToInt32(nudevvit.Text))
                            return false;
                        break;
                    case "=":
                        if (v != Convert.ToInt32(nudevvit.Text))
                            return false;
                        break;
                    case ">=":
                        if (v < Convert.ToInt32(nudevvit.Text))
                            return false;
                        break;
                    case ">":
                        if (v <= Convert.ToInt32(nudevvit.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckEVDefSpe(int ds)
        {
            if (cbevdefspé.SelectedIndex != -1 && cbevdefspé.Text != "-")
            {
                switch (cbevdefspé.Text)
                {
                    case "<":
                        if (ds >= Convert.ToInt32(nudevdefspé.Text))
                            return false;
                        break;
                    case "<=":
                        if (ds > Convert.ToInt32(nudevdefspé.Text))
                            return false;
                        break;
                    case "=":
                        if (ds != Convert.ToInt32(nudevdefspé.Text))
                            return false;
                        break;
                    case ">=":
                        if (ds < Convert.ToInt32(nudevdefspé.Text))
                            return false;
                        break;
                    case ">":
                        if (ds <= Convert.ToInt32(nudevdefspé.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckEVAttSpe(int attspe)
        {
            if (cbevattspé.SelectedIndex != -1 && cbevattspé.Text != "-")
            {
                switch (cbevattspé.Text)
                {
                    case "<":
                        if (attspe >= Convert.ToInt32(nudevattspé.Text))
                            return false;
                        break;
                    case "<=":
                        if (attspe > Convert.ToInt32(nudevattspé.Text))
                            return false;
                        break;
                    case "=":
                        if (attspe != Convert.ToInt32(nudevattspé.Text))
                            return false;
                        break;
                    case ">=":
                        if (attspe < Convert.ToInt32(nudevattspé.Text))
                            return false;
                        break;
                    case ">":
                        if (attspe <= Convert.ToInt32(nudevattspé.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckEVDef(int d)
        {
            if (cbevdef.SelectedIndex != -1 && cbevdef.Text != "-")
            {
                switch (cbevdef.Text)
                {
                    case "<":
                        if (d >= Convert.ToInt32(nudevdef.Text))
                            return false;
                        break;
                    case "<=":
                        if (d > Convert.ToInt32(nudevdef.Text))
                            return false;
                        break;
                    case "=":
                        if (d != Convert.ToInt32(nudevdef.Text))
                            return false;
                        break;
                    case ">=":
                        if (d < Convert.ToInt32(nudevdef.Text))
                            return false;
                        break;
                    case ">":
                        if (d <= Convert.ToInt32(nudevdef.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckEVAtt(int a)
        {
            if (cbevatt.SelectedIndex != -1 && cbevatt.Text != "-")
            {
                switch (cbevatt.Text)
                {
                    case "<":
                        if (a >= Convert.ToInt32(nudevatt.Text))
                            return false;
                        break;
                    case "<=":
                        if (a > Convert.ToInt32(nudevatt.Text))
                            return false;
                        break;
                    case "=":
                        if (a != Convert.ToInt32(nudevatt.Text))
                            return false;
                        break;
                    case ">=":
                        if (a < Convert.ToInt32(nudevatt.Text))
                            return false;
                        break;
                    case ">":
                        if (a <= Convert.ToInt32(nudevatt.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckEVPV(int pv)
        {
            if (cbevpv.SelectedIndex != -1 && cbevpv.Text != "-")
            {
                switch (cbevpv.Text)
                {
                    case "<":
                        if (pv >= Convert.ToInt32(nudevpv.Value))
                            return false;
                        break;
                    case "<=":
                        if (pv > Convert.ToInt32(nudevpv.Text))
                            return false;
                        break;
                    case "=":
                        if (pv != Convert.ToInt32(nudevpv.Text))
                            return false;
                        break;
                    case ">=":
                        if (pv < Convert.ToInt32(nudevpv.Text))
                            return false;
                        break;
                    case ">":
                        if (pv <= Convert.ToInt32(nudevpv.Text))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckVit(Pokemon p)
        {
            if (nudvit.Value != 0)
            {
                switch (cbvit.Text)
                {
                    case "<":
                        if (p.Stat_Vitesse >= Convert.ToDouble(nudvit.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_Vitesse > Convert.ToDouble(nudvit.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_Vitesse != Convert.ToDouble(nudvit.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_Vitesse < Convert.ToDouble(nudvit.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_Vitesse <= Convert.ToDouble(nudvit.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckDefSpe(Pokemon p)
        {
            if (nuddefspé.Value != 0)
            {
                switch (cbdefspé.Text)
                {
                    case "<":
                        if (p.Stat_DéfenseSpé >= Convert.ToDouble(nuddefspé.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_DéfenseSpé > Convert.ToDouble(nuddefspé.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_DéfenseSpé != Convert.ToDouble(nuddefspé.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_DéfenseSpé < Convert.ToDouble(nuddefspé.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_DéfenseSpé <= Convert.ToDouble(nuddefspé.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckAttSpe(Pokemon p)
        {
            if (nudattspé.Value != 0)
            {
                switch (cbattspé.Text)
                {
                    case "<":
                        if (p.Stat_AttaqueSpé >= Convert.ToDouble(nudattspé.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_AttaqueSpé > Convert.ToDouble(nudattspé.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_AttaqueSpé != Convert.ToDouble(nudattspé.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_AttaqueSpé < Convert.ToDouble(nudattspé.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_AttaqueSpé <= Convert.ToDouble(nudattspé.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckDef(Pokemon p)
        {
            if (nuddef.Value != 0)
            {
                switch (cbdef.Text)
                {
                    case "<":
                        if (p.Stat_Défense >= Convert.ToDouble(nuddef.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_Défense > Convert.ToDouble(nuddef.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_Défense != Convert.ToDouble(nuddef.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_Défense < Convert.ToDouble(nuddef.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_Défense <= Convert.ToDouble(nuddef.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckAtt(Pokemon p)
        {
            if (nudatt.Value != 0)
            {
                switch (cbatt.Text)
                {
                    case "<":
                        if (p.Stat_Attaque >= Convert.ToDouble(nudatt.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_Attaque > Convert.ToDouble(nudatt.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_Attaque != Convert.ToDouble(nudatt.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_Attaque < Convert.ToDouble(nudatt.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_Attaque <= Convert.ToDouble(nudatt.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckPV(Pokemon p)
        {
            if (nudpv.Value != 0)
            {
                switch (cbpv.Text)
                {
                    case "<":
                        if (p.Stat_PV >= Convert.ToDouble(nudpv.Value))
                            return false;
                        break;
                    case "<=":
                        if (p.Stat_PV > Convert.ToDouble(nudpv.Value))
                            return false;
                        break;
                    case "=":
                        if (p.Stat_PV != Convert.ToDouble(nudpv.Value))
                            return false;
                        break;
                    case ">=":
                        if (p.Stat_PV < Convert.ToDouble(nudpv.Value))
                            return false;
                        break;
                    case ">":
                        if (p.Stat_PV <= Convert.ToDouble(nudpv.Value))
                            return false;
                        break;
                }
            }
            return true;
        }

        private bool CheckType2(Pokemon p)
        {
            if (cbtype2.SelectedIndex != -1 && cbtype2.Text != "-")
            {
                if (cbtype2.Text != p.Type1.ToString() && cbtype2.Text != p.Type2.ToString())
                    return false;
            }
            return true;
        }

        private bool CheckType1(Pokemon p)
        {
            if (cbtype1.SelectedIndex != -1 && cbtype1.Text != "-")
            {
                if (cbtype1.Text != p.Type1.ToString() && cbtype1.Text != p.Type2.ToString())
                    return false;
            }
            return true;
        }

        private void Filtre2_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboType();
            FillComboCapacites(cbcap2);
            FillComboCapacites(cbcap1);
            FillComboCapacites(cbcap3);
            FillComboCapacites(cbcap4);
            FillComboOeuf();
            FillComboCapSpe();
        }

        void FillComboCapSpe()
        {
            cbcapspé.Items.Add("-");
            foreach (CapSpe c in Xblood.CSlist)
                cbcapspé.Items.Add(c.nom);
        }

        void FillComboType()
        {
            cbtype1.Items.Add("-");
            cbtype2.Items.Add("-");
            cbvul2.Items.Add("-");
            if (Xblood.Types == null)
                Xblood.FillTypes();
            foreach (string type in Xblood.NomsTypes)
            {
                cbtype1.Items.Add(type);
                cbtype2.Items.Add(type);
                cbvul2.Items.Add(type);
            }
        }

        void FillComboCapacites(ComboBox Combo)
        {
            Combo.Items.Add("-");
            foreach (Capacite c in xb.Clist)
                Combo.Items.Add(c.Nom);
        }

        void FillComboOeuf()
        {
            cboeuf1.Items.Add("-");
            cboeuf1.Items.Add("Amorphe");
            cboeuf1.Items.Add("Aquatique1");
            cboeuf1.Items.Add("Aquatique2");
            cboeuf1.Items.Add("Aquatique3");
            cboeuf1.Items.Add("Aucun");
            cboeuf1.Items.Add("Champêtre");
            cboeuf1.Items.Add("Dragon");
            cboeuf1.Items.Add("Féerique");
            cboeuf1.Items.Add("Herbeux");
            cboeuf1.Items.Add("Humain");
            cboeuf1.Items.Add("Insecte");
            cboeuf1.Items.Add("Minéral");
            cboeuf1.Items.Add("Monstre");
            cboeuf1.Items.Add("Stérile");
            cboeuf1.Items.Add("Volant");

            cboeuf2.Items.Add("-");
            cboeuf2.Items.Add("Amorphe");
            cboeuf2.Items.Add("Aquatique1");
            cboeuf2.Items.Add("Aquatique2");
            cboeuf2.Items.Add("Aquatique3");
            cboeuf2.Items.Add("Aucun");
            cboeuf2.Items.Add("Champêtre");
            cboeuf2.Items.Add("Dragon");
            cboeuf2.Items.Add("Féerique");
            cboeuf2.Items.Add("Herbeux");
            cboeuf2.Items.Add("Humain");
            cboeuf2.Items.Add("Insecte");
            cboeuf2.Items.Add("Minéral");
            cboeuf2.Items.Add("Monstre");
            cboeuf2.Items.Add("Stérile");
            cboeuf2.Items.Add("Volant");
        }

        private void txtmoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < (int)'0' || (int)e.KeyChar > (int)'9')
            {
                e.Handled = true;
            }
        }



    }
}