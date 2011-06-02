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
        public Pokemon CurrentPokémon;

        Xblood xb;

        public FormDescription()
        {
            InitializeComponent();
        }

        private void FormDescription_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPokémon();
            FillComboNum();
        }

        void FillComboPokémon()
        {
            ComboPokémon.Text = "";
            ComboPokémon.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
                ComboPokémon.Items.Add(p.Nom);
        }

        void FillComboNum()
        {
            ComboNum.Text = "";
            ComboNum.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
            {
                string num = p.Numéro.ToString();
                while (num.Length < 3)
                    num = "0" + num;

                ComboNum.Items.Add(num + " - " + p.Nom);
            }
        }

        private void ComboPokémon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPokémon.Text == null)
                return;
            CurrentPokémon = xb.GetPokémon(ComboPokémon.Text);
            string num = CurrentPokémon.Numéro.ToString();
            while (num.Length < 3)
                num = "0" + num;
            ComboNum.SelectedIndexChanged -= new System.EventHandler(ComboNum_SelectedIndexChanged);
            ComboNum.Text = num + " - " + CurrentPokémon.Nom;
            ComboNum.SelectedIndexChanged += new System.EventHandler(ComboNum_SelectedIndexChanged);
            SetPage(CurrentPokémon);
            ComboCTCS.Text = "";
            ComboLevel.Text = "";
            ComboOeuf.Text = "";
            ComboPokémon.Visible = false;
        }

        public void SetPage(Pokemon p)
        {
            ComboPokémon.SelectedIndexChanged -= new System.EventHandler(ComboPokémon_SelectedIndexChanged);
            ComboNum.SelectedIndexChanged -= new System.EventHandler(ComboNum_SelectedIndexChanged);
            if (ComboPokémon.Text == "")
                ComboPokémon.Text = p.Nom;
            if (ComboNum.Text == "")
            {
                string num = p.Numéro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                ComboNum.Text = num + " - " + ComboPokémon.Text;
            }
            ComboPokémon.SelectedIndexChanged += new System.EventHandler(ComboPokémon_SelectedIndexChanged);
            ComboNum.SelectedIndexChanged += new System.EventHandler(ComboNum_SelectedIndexChanged);

            lbNum.Text = "N°" + p.Numéro.ToString();
            lbNom.Text = "NOM: " + p.Nom;
            lbType.Text = "TYPE: \r\n" + p.Type1.ToString();
            if (p.Type2 != Type.AUCUN)
                lbType.Text += "/" + p.Type2.ToString();

            lbOeuf.Text = "OEUF: \r\n" + p.Oeuf1.ToString();
            if (p.Oeuf2 != Espèce.Aucun)
                lbOeuf.Text += "\r\n" + p.Oeuf2.ToString();

            lbPE.Text = "Points d'efforts: \r\n";
            foreach (EffortPoints pe in p.PE)
                lbPE.Text += pe.Stat.ToString().ToUpper() + pe.Valeur.ToString() + ", ";
            lbPE.Text = lbPE.Text.Substring(0, lbPE.Text.Length - 2);

            lbPV.Text = "PV: " + p.Stat_PV.ToString();
            lbAttaque.Text = "A: " + p.Stat_Attaque.ToString();
            lbDefense.Text = "D: " + p.Stat_Défense.ToString();
            lbAS.Text = "AS: " + p.Stat_AttaqueSpé.ToString();
            lbDS.Text = "DS: " + p.Stat_DéfenseSpé.ToString();
            lbVitesse.Text = "V: " + p.Stat_Vitesse.ToString();

            lbCapacitésSpé.Text = "Capacités Spé: \r\n" + p.CapacitésSpé[0];
            if (p.CapacitésSpé[1] != "" && p.CapacitésSpé[1] != null)
                lbCapacitésSpé.Text += "\r\n" + p.CapacitésSpé[1];

            /*
            //ComboBox Level
            ComboLevel.Items.Clear();
            Capacite[] tabC = Xblood.SortLevel(p.CapacitésLevelUp);
            foreach (Capacite c in tabC)
                ComboLevel.Items.Add(c.NiveauApprentissage + " - " + c.Nom);
            */

            //Grid Niveau
            dgvNiveau.Rows.Clear();
            Capacite[] tabC = Xblood.SortLevel(p.CapacitésLevelUp);
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
            tabC = Xblood.CompleteAClist(p.CapacitésCT);
            tabC = Xblood.SortCT(tabC);
            foreach (Capacite c in tabC)
                ComboCTCS.Items.Add("CT" + c.numCT + " - " + c.Nom);
            tabC = Xblood.CompleteAClist(p.CapacitésCS);
            tabC = Xblood.SortCS(tabC);
            foreach (Capacite c in tabC)
                ComboCTCS.Items.Add("CS" + c.numCS + " - " + c.Nom);
            */

            //Grid CT/CS
            dgvCTCS.Rows.Clear();
            tabC = Xblood.CompleteAClist(p.CapacitésCT);
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
            tabC = Xblood.CompleteAClist(p.CapacitésCS);
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
            foreach (Capacite c in p.CapacitésOeuf)
                ComboOeuf.Items.Add(c.Nom);
            */

            //Grid Oeuf
            dgvOeuf.Rows.Clear();
            tabC = Xblood.CompleteAClist(p.CapacitésOeuf);
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

            string pic = p.Numéro.ToString();
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
                    DataGridViewTextBoxCell poké = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell o1 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell o2 = new DataGridViewTextBoxCell();
                    poké.Value = pk.Nom;
                    o1.Value = pk.Oeuf1.ToString();
                    o2.Value = pk.Oeuf2.ToString();
                    r.Cells.Add(poké);
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
                        cpar.Value += "échange";
                        break;
                    case EvoType.echange_avec_objet:
                        cpar.Value += "échange avec objet";
                        break;
                    case EvoType.beaute:
                        cpar.Value += "beauté";
                        break;
                    case EvoType.special:
                        cpar.Value += "spécial";
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
                            lbEvo_en.Text += "échange";
                            break;
                        case EvoType.echange_avec_objet:
                            lbEvo_en.Text += "échange avec objet";
                            break;
                        case EvoType.beaute:
                            lbEvo_en.Text += "beauté";
                            break;
                        case EvoType.special:
                            lbEvo_en.Text += "spécial";
                            break;
                        default:
                            lbEvo_en.Text += "???";
                            break;
                    }
                }
            }
             */

            ;// lbEvo_en.Text = "Evolue en:";



            CurrentPokémon = p;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPokémon.Text == "")
                return;
            if (rbNormal.Checked)
            {
                string num = CurrentPokémon.Numéro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                pictureBox1.ImageLocation = @"Images\Normal\pkrs" + num + ".gif";
            }
        }

        private void rbShiney_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPokémon.Text == "")
                return;
            if (rbShiney.Checked)
            {
                string num = CurrentPokémon.Numéro.ToString();
                while (num.Length < 3)
                    num = "0" + num;
                pictureBox1.ImageLocation = @"Images\Shiney\pkrssh" + num + ".gif";
            }
        }

        private void lbNom_Click(object sender, EventArgs e)
        {
            ComboNum.Visible = false;
            ComboPokémon.Visible = true;
        }

        private void ComboPokémon_Leave(object sender, EventArgs e)
        {
            ComboPokémon.Visible = false;
        }

        private void ComboNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboPokémon.SelectedIndexChanged -= new System.EventHandler(ComboPokémon_SelectedIndexChanged);
            ComboPokémon.Text = ComboNum.Text.Substring(6);
            ComboPokémon.SelectedIndexChanged += new System.EventHandler(ComboPokémon_SelectedIndexChanged);
            CurrentPokémon = xb.GetPokémon(ComboNum.Text.Substring(6));
            SetPage(CurrentPokémon);
            ComboNum.Visible = false;
        }

        private void lbNum_Click(object sender, EventArgs e)
        {
            ComboPokémon.Visible = false;
            ComboNum.Visible = true;
        }

        private void ComboNum_Leave(object sender, EventArgs e)
        {
            ComboNum.Visible = false;
        }

        private void lbType_Click(object sender, EventArgs e)
        {
            if (CurrentPokémon != null)
            {
                FormTypes f = new FormTypes(CurrentPokémon);
                f.Show();
            }
        }

        private void OeufList_DoubleClick(object sender, EventArgs e)
        {
            string val = OeufList.Rows[OeufList.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            Pokemon p = xb.GetPokémon(val);
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
                    Pokemon p = xb.GetPokémon(nom);
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