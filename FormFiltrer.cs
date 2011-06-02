using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormFiltrer : Form
    {
        public bool PV;
        public bool Attaque;
        public bool Défense;
        public bool AS;
        public bool DS;
        public bool Vitesse;
        Xblood xb;
        int i = 0;

        public FormFiltrer()
        {
            InitializeComponent();
        }

        private void btStats_Click(object sender, EventArgs e)
        {
            FormPopUpStats f = new FormPopUpStats(this);
            f.ShowDialog();
        }

        private void FormFiltrer_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboType();
            FillComboCapacites();
            FillComboOeuf();
            FillComboEvo();
            FillComboCapSpe();
        }

        void FillComboCapSpe()
        {
            foreach (CapSpe c in Xblood.CSlist)
                ComboCapSpe.Items.Add(c.nom);
        }

        void FillComboType()
        {
            if (Xblood.Types == null)
                Xblood.FillTypes();
            foreach (string type in Xblood.NomsTypes)
            {
                ComboType1.Items.Add(type);
                ComboType2.Items.Add(type);
                ComboType3.Items.Add(type);
            }
        }

        void FillComboCapacites()
        {
            foreach (Capacite c in xb.Clist)
                ComboCapacites.Items.Add(c.Nom);
        }

        void FillComboOeuf()
        {
            ComboOeuf1.Items.Add("Amorphe");
            ComboOeuf1.Items.Add("Aquatique1");
            ComboOeuf1.Items.Add("Aquatique2");
            ComboOeuf1.Items.Add("Aquatique3");
            ComboOeuf1.Items.Add("Aucun");
            ComboOeuf1.Items.Add("Champêtre");
            ComboOeuf1.Items.Add("Dragon");
            ComboOeuf1.Items.Add("Féerique");
            ComboOeuf1.Items.Add("Herbeux");
            ComboOeuf1.Items.Add("Humain");
            ComboOeuf1.Items.Add("Insecte");
            ComboOeuf1.Items.Add("Minéral");
            ComboOeuf1.Items.Add("Monstre");
            ComboOeuf1.Items.Add("Stérile");
            ComboOeuf1.Items.Add("Volant");

            ComboOeuf2.Items.Add("Amorphe");
            ComboOeuf2.Items.Add("Aquatique1");
            ComboOeuf2.Items.Add("Aquatique2");
            ComboOeuf2.Items.Add("Aquatique3");
            ComboOeuf2.Items.Add("Aucun");
            ComboOeuf2.Items.Add("Champêtre");
            ComboOeuf2.Items.Add("Dragon");
            ComboOeuf2.Items.Add("Féerique");
            ComboOeuf2.Items.Add("Herbeux");
            ComboOeuf2.Items.Add("Humain");
            ComboOeuf2.Items.Add("Insecte");
            ComboOeuf2.Items.Add("Minéral");
            ComboOeuf2.Items.Add("Monstre");
            ComboOeuf2.Items.Add("Stérile");
            ComboOeuf2.Items.Add("Volant");
        }

        void FillComboEvo()
        {
            ComboEvo.Items.Add("Niveau");
            ComboEvo.Items.Add("Pierre feu");
            ComboEvo.Items.Add("Pierre eau");
            ComboEvo.Items.Add("Pierre plante");
            ComboEvo.Items.Add("Pierre foudre");
            ComboEvo.Items.Add("Pierre soleil");
            ComboEvo.Items.Add("Pierre lune");
            ComboEvo.Items.Add("Bonheur");
            ComboEvo.Items.Add("Malheur");
            ComboEvo.Items.Add("Echange");
            ComboEvo.Items.Add("Echange avec objet");
            ComboEvo.Items.Add("Beauté");
            ComboEvo.Items.Add("Spécial");
        }

        private void btFiltrer_Click(object sender, EventArgs e)
        {
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



                        if (chkMoy.Checked)
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
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenu! Les données saisient sont elles correct?");
                dgvListePK.Rows.Clear();
            }
            
        }

        bool CheckPokemon(Pokemon p)
        {
            if (!CheckType1(p))
                return false;
            if (!CheckType2(p))
                return false;
            if (!CheckStats(p))
                return false;
            if (!CheckPE(p))
                return false;
            if (!CheckCapacite(p))
                return false;
            if (!CheckOeuf1(p))
                return false;
            if (!CheckOeuf2(p))
                return false;
            if (!CheckModeEvo(p))
                return false;
            if (!CheckVulnerabilite(p))
                return false;
            if (!CheckMoyenne(p))
                return false;
            if (!CheckCapSpe(p))
                return false;
            
            return true;
        }

        private bool CheckCapSpe(Pokemon p)
        {
            if (chkCapSpe.Checked)
            {
                bool valid = false;
                foreach (string str in p.CapacitésSpé)
                {
                    if (str == ComboCapSpe.Text)
                        valid = true;
                }

                if (!valid)
                    return false;
            }
            return true;
        }

        private bool CheckMoyenne(Pokemon p)
        {
            if (chkMoy.Checked && txtMoyenne.Text != "")
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

                if (moyenne < Convert.ToDouble(txtMoyenne.Text))
                    return false;
            }
            return true;
        }

        private bool CheckVulnerabilite(Pokemon p)
        {

            if (chkVulnerable.Checked && ComboType3.Text != "" && ComboVulnerable.Text != "")
            {
                int t0 = ComboType3.SelectedIndex;
                int t1 = (int)p.Type1;
                int t2 = (int)p.Type2;

                switch (ComboVulnerable.Text)
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
                    case "Résistant":
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

        private bool CheckModeEvo(Pokemon p)
        {
            if (chkEvo.Checked && ComboEvo.Text != "")
            {
                if (p.evolution.Count == 0)
                    return false;

                EvoType e;

                switch (ComboEvo.Text)
                {
                    case "Niveau":
                        e = EvoType.niveau;
                        break;
                    case "Pierre feu":
                        e = EvoType.pierre_feu;
                        break;
                    case "Pierre eau":
                        e = EvoType.pierre_eau;
                        break;
                    case "Pierre plante":
                        e = EvoType.pierre_plante;
                        break;
                    case "Pierre foudre":
                        e = EvoType.pierre_foudre;
                        break;
                    case "Pierre soleil":
                        e = EvoType.pierre_soleil;
                        break;
                    case "Pierre lune":
                        e = EvoType.pierre_lune;
                        break;
                    case "Bonheur":
                        e = EvoType.bonheur;
                        break;
                    case "Malheur":
                        e = EvoType.malheur;
                        break;
                    case "Echange":
                        e = EvoType.echange;
                        break;
                    case "Echange avec objet":
                        e = EvoType.echange_avec_objet;
                        break;
                    case "Beauté":
                        e = EvoType.beaute;
                        break;
                    case "Spécial":
                        e = EvoType.special;
                        break;
                    default:
                        e = EvoType.special;
                        break;
                }

                bool evotype = false;
                foreach (Evolution evo in p.evolution)
                {
                    if (evo.evotype == e)
                        evotype = true;
                }

                if (!evotype)
                    return false;
            }
            return true;
        }

        private bool CheckOeuf2(Pokemon p)
        {
            if (chkOeuf2.Checked && ComboOeuf2.Text != "")
            {
                if (ComboOeuf2.Text != p.Oeuf1.ToString() && ComboOeuf2.Text != p.Oeuf2.ToString())
                    return false;
            }
            return true;
        }

        private bool CheckOeuf1(Pokemon p)
        {
            if (chkOeuf1.Checked && ComboOeuf1.Text != "")
            {
                if (ComboOeuf1.Text != p.Oeuf1.ToString() && ComboOeuf1.Text != p.Oeuf2.ToString())
                    return false;
            }
            return true;
        }

        private bool CheckCapacite(Pokemon p)
        {
            if (chkApprenant.Checked && ComboCapacites.Text != "")
            {
                Capacite c = new Capacite();
                c.Nom = ComboCapacites.Text;

                if (!Xblood.HasMove(p, c))
                    return false;
            }
            return true;
        }

        private bool CheckPE(Pokemon p)
        {
            if (chkPE.Checked)
            {
                int pv = 0;
                int a = 0;
                int d = 0;
                int As = 0;
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
                            As = pe.Valeur;
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

                if (txtpePV.Text != "")
                {
                    switch (CombopePVCondition.Text)
                    {
                        case "<":
                            if (pv >= Convert.ToInt32(txtpePV.Text))
                                return false;
                            break;
                        case "<=":
                            if (pv > Convert.ToInt32(txtpePV.Text))
                                return false;
                            break;
                        case "=":
                            if (pv != Convert.ToInt32(txtpePV.Text))
                                return false;
                            break;
                        case ">=":
                            if (pv < Convert.ToInt32(txtpePV.Text))
                                return false;
                            break;
                        case ">":
                            if (pv <= Convert.ToInt32(txtpePV.Text))
                                return false;
                            break;
                    }
                }

                if (txtpeAttaque.Text != "")
                {
                    switch (CombopeACondition.Text)
                    {
                        case "<":
                            if (a >= Convert.ToInt32(txtpeAttaque.Text))
                                return false;
                            break;
                        case "<=":
                            if (a > Convert.ToInt32(txtpeAttaque.Text))
                                return false;
                            break;
                        case "=":
                            if (a != Convert.ToInt32(txtpeAttaque.Text))
                                return false;
                            break;
                        case ">=":
                            if (a < Convert.ToInt32(txtpeAttaque.Text))
                                return false;
                            break;
                        case ">":
                            if (a <= Convert.ToInt32(txtpeAttaque.Text))
                                return false;
                            break;
                    }
                }

                if (txtpeDéfense.Text != "")
                {
                    switch (CombopeDCondition.Text)
                    {
                        case "<":
                            if (d >= Convert.ToInt32(txtpeDéfense.Text))
                                return false;
                            break;
                        case "<=":
                            if (d > Convert.ToInt32(txtpeDéfense.Text))
                                return false;
                            break;
                        case "=":
                            if (d != Convert.ToInt32(txtpeDéfense.Text))
                                return false;
                            break;
                        case ">=":
                            if (d < Convert.ToInt32(txtpeDéfense.Text))
                                return false;
                            break;
                        case ">":
                            if (d <= Convert.ToInt32(txtpeDéfense.Text))
                                return false;
                            break;
                    }
                }

                if (txtpeAS.Text != "")
                {
                    switch (CombopeASCondition.Text)
                    {
                        case "<":
                            if (As >= Convert.ToInt32(txtpeAS.Text))
                                return false;
                            break;
                        case "<=":
                            if (As > Convert.ToInt32(txtpeAS.Text))
                                return false;
                            break;
                        case "=":
                            if (As != Convert.ToInt32(txtpeAS.Text))
                                return false;
                            break;
                        case ">=":
                            if (As < Convert.ToInt32(txtpeAS.Text))
                                return false;
                            break;
                        case ">":
                            if (As <= Convert.ToInt32(txtpeAS.Text))
                                return false;
                            break;
                    }
                }

                if (txtpeDS.Text != "")
                {
                    switch (CombopeDSCondition.Text)
                    {
                        case "<":
                            if (ds >= Convert.ToInt32(txtpeDS.Text))
                                return false;
                            break;
                        case "<=":
                            if (ds > Convert.ToInt32(txtpeDS.Text))
                                return false;
                            break;
                        case "=":
                            if (ds != Convert.ToInt32(txtpeDS.Text))
                                return false;
                            break;
                        case ">=":
                            if (ds < Convert.ToInt32(txtpeDS.Text))
                                return false;
                            break;
                        case ">":
                            if (ds <= Convert.ToInt32(txtpeDS.Text))
                                return false;
                            break;
                    }
                }

                if (txtpeVitesse.Text != "")
                {
                    switch (CombopeVCondition.Text)
                    {
                        case "<":
                            if (v >= Convert.ToInt32(txtpeVitesse.Text))
                                return false;
                            break;
                        case "<=":
                            if (v > Convert.ToInt32(txtpeVitesse.Text))
                                return false;
                            break;
                        case "=":
                            if (v != Convert.ToInt32(txtpeVitesse.Text))
                                return false;
                            break;
                        case ">=":
                            if (v < Convert.ToInt32(txtpeVitesse.Text))
                                return false;
                            break;
                        case ">":
                            if (v <= Convert.ToInt32(txtpeVitesse.Text))
                                return false;
                            break;
                    }
                }
            }
            return true;
        }

        private bool CheckStats(Pokemon p)
        {
            if (chkStats.Checked)
            {
                if (txtPV.Text != "")
                {
                    switch (ComboPVCondition.Text)
                    {
                        case "<":
                            if (p.Stat_PV >= Convert.ToDouble(txtPV.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_PV > Convert.ToDouble(txtPV.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_PV != Convert.ToDouble(txtPV.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_PV < Convert.ToDouble(txtPV.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_PV <= Convert.ToDouble(txtPV.Text))
                                return false;
                            break;
                    }
                }


                if (txtAttaque.Text != "")
                {
                    switch (ComboACondition.Text)
                    {
                        case "<":
                            if (p.Stat_Attaque >= Convert.ToDouble(txtAttaque.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_Attaque > Convert.ToDouble(txtAttaque.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_Attaque != Convert.ToDouble(txtAttaque.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_Attaque < Convert.ToDouble(txtAttaque.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_Attaque <= Convert.ToDouble(txtAttaque.Text))
                                return false;
                            break;
                    }
                }

                if (txtDéfense.Text != "")
                {
                    switch (ComboDCondition.Text)
                    {
                        case "<":
                            if (p.Stat_Défense >= Convert.ToDouble(txtDéfense.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_Défense > Convert.ToDouble(txtDéfense.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_Défense != Convert.ToDouble(txtDéfense.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_Défense < Convert.ToDouble(txtDéfense.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_Défense <= Convert.ToDouble(txtDéfense.Text))
                                return false;
                            break;
                    }
                }

                if (txtAS.Text != "")
                {
                    switch (ComboASCondition.Text)
                    {
                        case "<":
                            if (p.Stat_AttaqueSpé >= Convert.ToDouble(txtAS.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_AttaqueSpé > Convert.ToDouble(txtAS.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_AttaqueSpé != Convert.ToDouble(txtAS.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_AttaqueSpé < Convert.ToDouble(txtAS.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_AttaqueSpé <= Convert.ToDouble(txtAS.Text))
                                return false;
                            break;
                    }
                }

                if (txtDS.Text != "")
                {
                    switch (ComboDSCondition.Text)
                    {
                        case "<":
                            if (p.Stat_DéfenseSpé >= Convert.ToDouble(txtDS.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_DéfenseSpé > Convert.ToDouble(txtDS.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_DéfenseSpé != Convert.ToDouble(txtDS.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_DéfenseSpé < Convert.ToDouble(txtDS.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_DéfenseSpé <= Convert.ToDouble(txtDS.Text))
                                return false;
                            break;
                    }
                }

                if (txtVitesse.Text != "")
                {
                    switch (ComboVCondition.Text)
                    {
                        case "<":
                            if (p.Stat_Vitesse >= Convert.ToDouble(txtVitesse.Text))
                                return false;
                            break;
                        case "<=":
                            if (p.Stat_Vitesse > Convert.ToDouble(txtVitesse.Text))
                                return false;
                            break;
                        case "=":
                            if (p.Stat_Vitesse != Convert.ToDouble(txtVitesse.Text))
                                return false;
                            break;
                        case ">=":
                            if (p.Stat_Vitesse < Convert.ToDouble(txtVitesse.Text))
                                return false;
                            break;
                        case ">":
                            if (p.Stat_Vitesse <= Convert.ToDouble(txtVitesse.Text))
                                return false;
                            break;
                    }
                }

            }
            return true;
        }

        private bool CheckType2(Pokemon p)
        {
            if (chkType2.Checked && ComboType2.Text != "")
            {
                if(ComboType2.Text != p.Type1.ToString() && ComboType2.Text != p.Type2.ToString())
                    return false;

            }
            return true;
        }

        private bool CheckType1(Pokemon p)
        {
            if (chkType1.Checked && ComboType1.Text != "")
            {
                if (ComboType1.Text != p.Type1.ToString() && ComboType1.Text != p.Type2.ToString())
                    return false;

            }
            return true;
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnNum.Visible = item.Checked;
        }

        private void nomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnNom.Visible = item.Checked;
        }

        private void type1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnType1.Visible = item.Checked;
        }

        private void type2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnType2.Visible = item.Checked;
        }

        private void pVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPV.Visible = item.Checked;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnAttaque.Visible = item.Checked;
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnDefense.Visible = item.Checked;
        }

        private void aSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnAS.Visible = item.Checked;
        }

        private void dSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnDS.Visible = item.Checked;
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnVitesse.Visible = item.Checked;
        }

        private void moyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnMoyenne.Visible = item.Checked;
        }

        private void moyRéelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnMoyenneReel.Visible = item.Checked;
        }

        private void oeuf1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnOeuf1.Visible = item.Checked;
        }

        private void oeuf2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnOeuf2.Visible = item.Checked;
        }

        private void pEPVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEPV.Visible = item.Checked;
        }

        private void pEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEAttaque.Visible = item.Checked;
        }

        private void pEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEDefense.Visible = item.Checked;
        }

        private void pEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEAS.Visible = item.Checked;
        }

        private void pEDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEDS.Visible = item.Checked;
        }

        private void pEVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ColumnPEVitesse.Visible = item.Checked;
        }

        private void dgvListePK_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvListePK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string val = dgvListePK.Rows[dgvListePK.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                Pokemon p = xb.GetPokémon(val);
                FormDescription f = new FormDescription();
                f.Show();
                f.SetPage(p);
            }
        }
    }
}