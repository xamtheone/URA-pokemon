using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormDescription : Form
    {
        public Pokemon CurrentPok�mon;

        Xblood xb;

        public FormDescription()
        {
            InitializeComponent();
        }

        private void FormDescription_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPok�mon();
            FillComboNum();
        }

        void FillComboPok�mon()
        {
            ComboPok�mon.Text = "";
            ComboPok�mon.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
                ComboPok�mon.Items.Add(p.Nom);
        }

        void FillComboNum()
        {
            ComboNum.Text = "";
            ComboNum.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
            {
                string num = p.Num�ro.ToString();
                while (num.Length < 3)
                    num = "0" + num;

                ComboNum.Items.Add(num + " - " + p.Nom);
            }
        }

        private void ComboPok�mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text == null)
                return;
            CurrentPok�mon = xb.GetPok�mon(ComboPok�mon.Text);
            string num = CurrentPok�mon.Num�ro.ToString();
            while (num.Length < 3)
                num = "0" + num;
            ComboNum.SelectedIndexChanged -= new System.EventHandler(ComboNum_SelectedIndexChanged);
            ComboNum.Text = num + " - " + CurrentPok�mon.Nom;
            ComboNum.SelectedIndexChanged += new System.EventHandler(ComboNum_SelectedIndexChanged);
            SetPage(CurrentPok�mon);
            ComboCTCS.Text = "";
            ComboLevel.Text = "";
            ComboOeuf.Text = "";
            ComboPok�mon.Visible = false;
        }

        public void SetPage(Pokemon p)
        {
            ComboPok�mon.SelectedIndexChanged -= new System.EventHandler(ComboPok�mon_SelectedIndexChanged);
            ComboNum.SelectedIndexChanged -= new System.EventHandler(ComboNum_SelectedIndexChanged);
            if (ComboPok�mon.Text == "")
                ComboPok�mon.Text = p.Nom;
            if (ComboNum.Text == "")
            {
                string num = p.Num�ro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                ComboNum.Text = num + " - " + ComboPok�mon.Text;
            }
            ComboPok�mon.SelectedIndexChanged += new System.EventHandler(ComboPok�mon_SelectedIndexChanged);
            ComboNum.SelectedIndexChanged += new System.EventHandler(ComboNum_SelectedIndexChanged);

            lbNum.Text = "N�" + p.Num�ro.ToString();
            lbNom.Text = "NOM: " + p.Nom;
            lbType.Text = "TYPE: \r\n" + p.Type1.ToString();
            if (p.Type2 != Type.AUCUN)
                lbType.Text += "/" + p.Type2.ToString();

            lbOeuf.Text = "OEUF: \r\n" + p.Oeuf1.ToString();
            if (p.Oeuf2 != Esp�ce.Aucun)
                lbOeuf.Text += "\r\n" + p.Oeuf2.ToString();

            lbPE.Text = "Points d'efforts: \r\n";
            foreach (EffortPoints pe in p.PE)
                lbPE.Text += pe.Stat.ToString().ToUpper() + pe.Valeur.ToString() + ", ";
            lbPE.Text = lbPE.Text.Substring(0, lbPE.Text.Length - 2);

            lbPV.Text = "PV: " + p.Stat_PV.ToString();
            lbAttaque.Text = "A: " + p.Stat_Attaque.ToString();
            lbDefense.Text = "D: " + p.Stat_D�fense.ToString();
            lbAS.Text = "AS: " + p.Stat_AttaqueSp�.ToString();
            lbDS.Text = "DS: " + p.Stat_D�fenseSp�.ToString();
            lbVitesse.Text = "V: " + p.Stat_Vitesse.ToString();

            lbCapacit�sSp�.Text = "Capacit�s Sp�: \r\n" + p.Capacit�sSp�[0];
            if (p.Capacit�sSp�[1] != "" && p.Capacit�sSp�[1] != null)
                lbCapacit�sSp�.Text += "\r\n" + p.Capacit�sSp�[1];

            /*
            //ComboBox Level
            ComboLevel.Items.Clear();
            Capacite[] tabC = Xblood.SortLevel(p.Capacit�sLevelUp);
            foreach (Capacite c in tabC)
                ComboLevel.Items.Add(c.NiveauApprentissage + " - " + c.Nom);
            */

            //Grid Niveau
            dgvNiveau.Rows.Clear();
            Capacite[] tabC = Xblood.SortLevel(p.Capacit�sLevelUp);
            Capacite[] ctabC = Xblood.CompleteAClist(tabC);
            int i = 0;
            foreach (Capacite c in tabC)
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = c.Nom;
                cnom.ToolTipText = ctabC[i].Description;
                r.Tag = c;
                DataGridViewTextBoxCell cniveau = new DataGridViewTextBoxCell();
                cniveau.Value = c.NiveauApprentissage;
                DataGridViewTextBoxCell cnature = new DataGridViewTextBoxCell();
                if (ctabC[i].NatureDegat != NatureDegat.NULL)
                    cnature.Value = ctabC[i].NatureDegat.ToString();

                r.Cells.Add(cniveau);
                r.Cells.Add(cnom);
                r.Cells.Add(cnature);

                dgvNiveau.Rows.Add(r);
                i++;
            }

            //ListBox CTCS
            /*
            ComboCTCS.Items.Clear();
            tabC = Xblood.CompleteAClist(p.Capacit�sCT);
            tabC = Xblood.SortCT(tabC);
            foreach (Capacite c in tabC)
                ComboCTCS.Items.Add("CT" + c.numCT + " - " + c.Nom);
            tabC = Xblood.CompleteAClist(p.Capacit�sCS);
            tabC = Xblood.SortCS(tabC);
            foreach (Capacite c in tabC)
                ComboCTCS.Items.Add("CS" + c.numCS + " - " + c.Nom);
            */

            //Grid CT/CS
            dgvCTCS.Rows.Clear();
            tabC = Xblood.CompleteAClist(p.Capacit�sCT);
            tabC = Xblood.SortCT(tabC);
            
            foreach (Capacite c in tabC)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.Tag = c;
                DataGridViewTextBoxCell cnum = new DataGridViewTextBoxCell();
                cnum.Value = "CT" + c.numCT;
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = c.Nom;
                cnom.ToolTipText = c.Description;
                DataGridViewTextBoxCell cnature = new DataGridViewTextBoxCell();
                if (c.NatureDegat != NatureDegat.NULL)
                    cnature.Value = c.NatureDegat.ToString();

                r.Cells.Add(cnum);
                r.Cells.Add(cnom);
                r.Cells.Add(cnature);

                dgvCTCS.Rows.Add(r);
                
            }
            tabC = Xblood.CompleteAClist(p.Capacit�sCS);
            tabC = Xblood.SortCS(tabC);
            foreach (Capacite c in tabC)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.Tag = c;
                DataGridViewTextBoxCell cnum = new DataGridViewTextBoxCell();
                cnum.Value = "CS" + c.numCS;
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = c.Nom;
                cnom.ToolTipText = c.Description;
                DataGridViewTextBoxCell cnature = new DataGridViewTextBoxCell();
                if (c.NatureDegat != NatureDegat.NULL)
                    cnature.Value = c.NatureDegat.ToString();

                r.Cells.Add(cnum);
                r.Cells.Add(cnom);
                r.Cells.Add(cnature);

                dgvCTCS.Rows.Add(r);
            }

            //ListBox Oeuf
            /*
            ComboOeuf.Items.Clear();
            foreach (Capacite c in p.Capacit�sOeuf)
                ComboOeuf.Items.Add(c.Nom);
            */

            //Grid Oeuf
            dgvOeuf.Rows.Clear();
            tabC = Xblood.CompleteAClist(p.Capacit�sOeuf);
            foreach (Capacite c in tabC)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.Tag = c;
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = c.Nom;
                cnom.ToolTipText = c.Description;
                DataGridViewTextBoxCell cnature = new DataGridViewTextBoxCell();
                if (c.NatureDegat != NatureDegat.NULL)
                    cnature.Value = c.NatureDegat.ToString();

                r.Cells.Add(cnom);
                r.Cells.Add(cnature);

                dgvOeuf.Rows.Add(r);
            }

            string pic = p.Num�ro.ToString();
            while (pic.Length < 3)
                pic = "0" + pic;

            string apparence;
            if (rbNormal.Checked)
                apparence = @"Normal\pkrs";
            else
                apparence = @"Shiney\pkrssh";

            pic = @"Images\" + apparence + pic + ".gif";
            pictureBox1.ImageLocation = pic;

            OeufList.Rows.Clear();
            foreach (Pokemon pk in xb.PKlist)
            {
                if (xb.MemeGroupeOeuf(pk, p) && pk.Nom != p.Nom)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.Height = 20;
                    DataGridViewTextBoxCell pok� = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell o1 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell o2 = new DataGridViewTextBoxCell();
                    pok�.Value = pk.Nom;
                    o1.Value = pk.Oeuf1.ToString();
                    o2.Value = pk.Oeuf2.ToString();
                    r.Cells.Add(pok�);
                    r.Cells.Add(o1);
                    r.Cells.Add(o2);
                    OeufList.Rows.Add(r);
                }
            }


            dgvEvo.Rows.Clear();
            if (p.evo_de != null)
            {
                //lbEvo_de.Text = "Evolue de:\r\n" + p.evo_de;
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = "Evolue DE";

                DataGridViewCellStyle style = new DataGridViewCellStyle(dgvEvo.DefaultCellStyle);
                style.Font = new Font(style.Font, FontStyle.Bold);
                cnom.Style = style;

                r.Cells.Add(cnom);

                dgvEvo.Rows.Add(r);

                 r = new DataGridViewRow();
                 cnom = new DataGridViewTextBoxCell();
                cnom.Value = p.evo_de;
                r.Tag = p.evo_de;

                r.Cells.Add(cnom);

                dgvEvo.Rows.Add(r);
            }

            if (p.evolution.Count > 0)
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = "Evolue EN";

                DataGridViewCellStyle style = new DataGridViewCellStyle(dgvEvo.DefaultCellStyle);
                style.Font = new Font(style.Font, FontStyle.Bold);
                cnom.Style = style;

                r.Cells.Add(cnom);

                dgvEvo.Rows.Add(r);
            }

            foreach (Evolution e in p.evolution)
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell cnom = new DataGridViewTextBoxCell();
                cnom.Value = e.nom;
                r.Tag = e.nom;
                DataGridViewTextBoxCell cpar = new DataGridViewTextBoxCell();

                switch (e.evotype)
                {
                    case EvoType.niveau:
                        cpar.Value = "niveau " + e.level;
                        break;
                    case EvoType.pierre_feu:
                        cpar.Value += "pierre feu";
                        break;
                    case EvoType.pierre_eau:
                        cpar.Value += "pierre eau";
                        break;
                    case EvoType.pierre_foudre:
                        cpar.Value += "pierre foudre";
                        break;
                    case EvoType.pierre_plante:
                        cpar.Value += "pierre plante";
                        break;
                    case EvoType.pierre_soleil:
                        cpar.Value += "pierre soleil";
                        break;
                    case EvoType.pierre_lune:
                        cpar.Value += "pierre lune";
                        break;
                    case EvoType.bonheur:
                        cpar.Value += "bonheur";
                        break;
                    case EvoType.malheur:
                        cpar.Value += "malheur";
                        break;
                    case EvoType.echange:
                        cpar.Value += "�change";
                        break;
                    case EvoType.echange_avec_objet:
                        cpar.Value += "�change avec objet";
                        break;
                    case EvoType.beaute:
                        cpar.Value += "beaut�";
                        break;
                    case EvoType.special:
                        cpar.Value += "sp�cial";
                        break;
                    default:
                        cpar.Value += "???";
                        break;
                }

                r.Cells.Add(cnom);
                r.Cells.Add(cpar);

                dgvEvo.Rows.Add(r);
            }

            /*
            lbEvo_en.Text = "Evolue en:";
            foreach (Evolution e in p.evolution)
            {
                lbEvo_en.Text += "\r\n" + e.nom;
                if (e.evotype == EvoType.niveau)
                    lbEvo_en.Text += "\r\nau " + e.evotype.ToString() + " " + e.level.ToString();
                else
                {
                    lbEvo_en.Text += " par\r\n";
                    switch (e.evotype)
                    {
                        case EvoType.pierre_feu:
                            lbEvo_en.Text += "pierre feu";
                            break;
                        case EvoType.pierre_eau:
                            lbEvo_en.Text += "pierre eau";
                            break;
                        case EvoType.pierre_foudre:
                            lbEvo_en.Text += "pierre foudre";
                            break;
                        case EvoType.pierre_plante:
                            lbEvo_en.Text += "pierre plante";
                            break;
                        case EvoType.pierre_soleil:
                            lbEvo_en.Text += "pierre soleil";
                            break;
                        case EvoType.pierre_lune:
                            lbEvo_en.Text += "pierre lune";
                            break;
                        case EvoType.bonheur:
                            lbEvo_en.Text += "bonheur";
                            break;
                        case EvoType.malheur:
                            lbEvo_en.Text += "malheur";
                            break;
                        case EvoType.echange:
                            lbEvo_en.Text += "�change";
                            break;
                        case EvoType.echange_avec_objet:
                            lbEvo_en.Text += "�change avec objet";
                            break;
                        case EvoType.beaute:
                            lbEvo_en.Text += "beaut�";
                            break;
                        case EvoType.special:
                            lbEvo_en.Text += "sp�cial";
                            break;
                        default:
                            lbEvo_en.Text += "???";
                            break;
                    }
                }
            }
             */

            ;// lbEvo_en.Text = "Evolue en:";



            CurrentPok�mon = p;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text == "")
                return;
            if (rbNormal.Checked)
            {
                string num = CurrentPok�mon.Num�ro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                pictureBox1.ImageLocation = @"Images\Normal\pkrs" + num + ".gif";
            }
        }

        private void rbShiney_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text == "")
                return;
            if (rbShiney.Checked)
            {
                string num = CurrentPok�mon.Num�ro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                pictureBox1.ImageLocation = @"Images\Shiney\pkrssh" + num + ".gif";
            }
        }

        private void lbNom_Click(object sender, EventArgs e)
        {
            ComboNum.Visible = false;
            ComboPok�mon.Visible = true;
        }

        private void ComboPok�mon_Leave(object sender, EventArgs e)
        {
            ComboPok�mon.Visible = false;
        }

        private void ComboNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboPok�mon.SelectedIndexChanged -= new System.EventHandler(ComboPok�mon_SelectedIndexChanged);
            ComboPok�mon.Text = ComboNum.Text.Substring(6);
            ComboPok�mon.SelectedIndexChanged += new System.EventHandler(ComboPok�mon_SelectedIndexChanged);
            CurrentPok�mon = xb.GetPok�mon(ComboNum.Text.Substring(6));
            SetPage(CurrentPok�mon);
            ComboNum.Visible = false;
        }

        private void lbNum_Click(object sender, EventArgs e)
        {
            ComboPok�mon.Visible = false;
            ComboNum.Visible = true;
        }

        private void ComboNum_Leave(object sender, EventArgs e)
        {
            ComboNum.Visible = false;
        }

        private void lbType_Click(object sender, EventArgs e)
        {
            if (CurrentPok�mon != null)
            {
                FormTypes f = new FormTypes(CurrentPok�mon);
                f.Show();
            }
        }

        private void OeufList_DoubleClick(object sender, EventArgs e)
        {
            string val = OeufList.Rows[OeufList.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            Pokemon p = xb.GetPok�mon(val);
            FormDescription f = new FormDescription();
            f.Show();
            f.SetPage(p);
        }

        private void dgvEvo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEvo.SelectedCells.Count > 0)
            {
                if (dgvEvo.Rows[dgvEvo.SelectedCells[0].RowIndex].Tag != null)
                {
                    string nom = (string)dgvEvo.Rows[dgvEvo.SelectedCells[0].RowIndex].Tag;
                    Pokemon p = xb.GetPok�mon(nom);
                    FormDescription f = new FormDescription();
                    f.Show();
                    f.SetPage(p);
                }
            }
        }

        private void dgvNiveau_DoubleClick(object sender, EventArgs e)
        {
            if (dgvNiveau.SelectedCells.Count > 0)
            {
                if (dgvNiveau.Rows[dgvNiveau.SelectedCells[0].RowIndex].Tag != null)
                {
                    Capacite cap = (Capacite)dgvNiveau.Rows[dgvNiveau.SelectedCells[0].RowIndex].Tag;
                    FormCapacites f = new FormCapacites(cap);
                    f.Show();
                }
            }
        }

        private void dgvCTCS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTCS.SelectedCells.Count > 0)
            {
                if (dgvCTCS.Rows[dgvCTCS.SelectedCells[0].RowIndex].Tag != null)
                {
                    Capacite cap = (Capacite)dgvCTCS.Rows[dgvCTCS.SelectedCells[0].RowIndex].Tag;
                    FormCapacites f = new FormCapacites(cap);
                    f.Show();
                }
            }
        }

        private void dgvOeuf_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOeuf.SelectedCells.Count > 0)
            {
                if (dgvOeuf.Rows[dgvOeuf.SelectedCells[0].RowIndex].Tag != null)
                {
                    Capacite cap = (Capacite)dgvOeuf.Rows[dgvOeuf.SelectedCells[0].RowIndex].Tag;
                    FormCapacites f = new FormCapacites(cap);
                    f.Show();
                }
            }
        }

    }
}