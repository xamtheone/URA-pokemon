using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace URA_Pokemon
{
    public partial class FormPokéFiche : Form
    {
        string[] NatureNoms = new string[25];
        double[][] NatureValeurs = new double[25][];
        Pokemon CurrentPokemon;
        Xblood xb;
        bool enregistre = false;
        string TitreFenetre;

        public FormPokéFiche()
        {
            InitializeComponent();
            TitreFenetre = this.Text;
        }

        void StatutEnregitrement(bool est_enregistre)
        {
            if (est_enregistre != enregistre)
            {
                if (est_enregistre)
                    this.Text = TitreFenetre;
                else
                    this.Text = TitreFenetre + "*";
            }
            enregistre = est_enregistre;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFicheSave f = new FormFicheSave();
            if (txtPseudo.Text == "")
                f.Filename = ComboPokémon.Text;
            else
                f.Filename = txtPseudo.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlDocument dom = new XmlDocument();
                XmlElement root = dom.CreateElement("POKEMON");
                dom.AppendChild(root);

                root.SetAttribute("espece", ComboPokémon.Text);
                root.SetAttribute("pseudo", txtPseudo.Text);
                string s = "";
                if (rbMale.Checked)
                    s = "Male";
                else if (rbFemelle.Checked)
                    s = "Femelle";
                else
                    s = "Assexue";
                root.SetAttribute("sexe", s);
                root.SetAttribute("nature", ComboNature.Text);
                root.SetAttribute("capacitespe", ComboCapacitéSpé.Text);
                string c = "";
                if (rbShiney.Checked)
                    c = "shiney";
                else
                    c = "normal";
                root.SetAttribute("couleur", c);
                if (NumUDNiveau.Text != "")
                    root.SetAttribute("niveau", NumUDNiveau.Value.ToString());
                
                XmlElement Symboles = dom.CreateElement("SYMBOLES");
                Symboles.SetAttribute("carre", chkCarré.Checked.ToString().ToLower());
                Symboles.SetAttribute("rond", chkRond.Checked.ToString().ToLower());
                Symboles.SetAttribute("triangle", chkTriangle.Checked.ToString().ToLower());
                Symboles.SetAttribute("coeur", chkCoeur.Checked.ToString().ToLower());
                Symboles.SetAttribute("etoile", chketoile.Checked.ToString().ToLower());
                Symboles.SetAttribute("losange", chklosange.Checked.ToString().ToLower());

                root.AppendChild(Symboles);
                XmlElement Capacites = dom.CreateElement("CAPACITES");
                if (ComboC1.Text == "(vide)" || ComboC1.Text == "")
                    Capacites.SetAttribute("nom1", "");
                else
                    Capacites.SetAttribute("nom1", ComboC1.Text);
                if (ComboC2.Text == "(vide)" || ComboC2.Text == "")
                    Capacites.SetAttribute("nom2", "");
                else
                    Capacites.SetAttribute("nom2", ComboC2.Text);
                if (ComboC3.Text == "(vide)" || ComboC3.Text == "")
                    Capacites.SetAttribute("nom3", "");
                else
                    Capacites.SetAttribute("nom3", ComboC3.Text);
                if (ComboC4.Text == "(vide)" || ComboC4.Text == "")
                    Capacites.SetAttribute("nom4", "");
                else
                    Capacites.SetAttribute("nom4", ComboC4.Text);
                root.AppendChild(Capacites);
                XmlElement DV = dom.CreateElement("DV");
                if (txtPV.Text != "")
                    DV.SetAttribute("pv", txtPV.Text);
                else
                    DV.SetAttribute("pv", "-1");
                if (txtAttaque.Text != "")
                    DV.SetAttribute("a", txtAttaque.Text);
                else
                    DV.SetAttribute("a", "-1");
                if (txtDéfense.Text != "")
                    DV.SetAttribute("d", txtDéfense.Text);
                else
                    DV.SetAttribute("d", "-1");
                if (txtAS.Text != "")
                    DV.SetAttribute("as", txtAS.Text);
                else
                    DV.SetAttribute("as", "-1");
                if (txtDS.Text != "")
                    DV.SetAttribute("ds", txtDS.Text);
                else
                    DV.SetAttribute("ds", "-1");
                if (txtVitesse.Text != "")
                    DV.SetAttribute("v", txtVitesse.Text);
                else
                    DV.SetAttribute("v", "-1");
                root.AppendChild(DV);
                XmlElement PE = dom.CreateElement("PE");
                PE.SetAttribute("pv", NumUDPV.Value.ToString());
                PE.SetAttribute("a", NumUDAttaque.Value.ToString());
                PE.SetAttribute("d", NumUDDéfense.Value.ToString());
                PE.SetAttribute("as", NumUDAS.Value.ToString());
                PE.SetAttribute("ds", NumUDDS.Value.ToString());
                PE.SetAttribute("v", NumUDVitesse.Value.ToString());
                root.AppendChild(PE);

                dom.Save(saveFileDialog1.FileName);
            }
            Directory.SetCurrentDirectory(Xblood.CurrentDirectory);
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
            NatureNoms[0] = "Assure";
            NatureNoms[1] = "Bizarre";
            NatureNoms[2] = "Brave";
            NatureNoms[3] = "Calme";
            NatureNoms[4] = "Discret";
            NatureNoms[5] = "Docile";
            NatureNoms[6] = "Doux";
            NatureNoms[7] = "Foufou";
            NatureNoms[8] = "Gentil";
            NatureNoms[9] = "Hardi";
            NatureNoms[10] = "Jovial";
            NatureNoms[11] = "Lache";
            NatureNoms[12] = "Malin";
            NatureNoms[13] = "Malpoli";
            NatureNoms[14] = "Mauvais";
            NatureNoms[15] = "Modeste";
            NatureNoms[16] = "Naif";
            NatureNoms[17] = "Presse";
            NatureNoms[18] = "Prudent";
            NatureNoms[19] = "Pudique";
            NatureNoms[20] = "Relax";
            NatureNoms[21] = "Rigide";
            NatureNoms[22] = "Serieux";
            NatureNoms[23] = "Solo";
            NatureNoms[24] = "Timide";

            foreach (string str in NatureNoms)
                ComboNature.Items.Add(str);
        }

        private void FormPokéFiche_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPokémon();
            FillComboNature();

            ComboC1.Items.Add("(vide)");
            ComboC2.Items.Add("(vide)");
            ComboC3.Items.Add("(vide)");
            ComboC4.Items.Add("(vide)");

            ComboC1.SelectedIndex = 0;
            ComboC2.SelectedIndex = 0;
            ComboC3.SelectedIndex = 0;
            ComboC4.SelectedIndex = 0;
        }

        private void ComboPokémon_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatutEnregitrement(false);
            
            ComboCapacitéSpé.Items.Clear();
            ComboC1.Items.Clear();
            ComboC2.Items.Clear();
            ComboC3.Items.Clear();
            ComboC4.Items.Clear();

            ComboC1.Items.Add("(vide)");
            ComboC2.Items.Add("(vide)");
            ComboC3.Items.Add("(vide)");
            ComboC4.Items.Add("(vide)");

            ComboC1.SelectedIndex = 0;
            ComboC2.SelectedIndex = 0;
            ComboC3.SelectedIndex = 0;
            ComboC4.SelectedIndex = 0;

            Pokemon p = xb.GetPokémon(ComboPokémon.Text);
            CurrentPokemon = p;
            foreach (string str in p.CapacitésSpé)
            {
                if (str != null)
                    ComboCapacitéSpé.Items.Add(str);
            }

            ComboCapacitéSpé.SelectedIndex = 0;
            Capacite[] cap = Xblood.ListofMoves(p);
            foreach (Capacite c in cap)
            {
                ComboC1.Items.Add(c.Nom);
                ComboC2.Items.Add(c.Nom);
                ComboC3.Items.Add(c.Nom);
                ComboC4.Items.Add(c.Nom);
            }
            
            string pic = p.Numéro.ToString();
            while (pic.Length < 3)
                pic = "0" + pic;

            string apparence;
            if (rbNormal.Checked)
                apparence = @"Normal\pkrs";
            else
                apparence = @"Shiney\pkrssh";

            pic = Application.StartupPath + @"\Images\" + apparence + pic + ".gif";
            pictureBox1.ImageLocation = pic;
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            if (NumUDNiveau.Value != 0)
            {
                double[] Nature = new double[] { 1, 1, 1, 1, 1 };
                if (ComboNature.Text != "")
                    Nature = NatureValeurs[ComboNature.SelectedIndex];

                double N = Convert.ToDouble(NumUDNiveau.Value);
                double dvpv = 0;
                if (txtPV.Text != "")
                    dvpv = Convert.ToDouble(txtPV.Text);
                double pepv = Convert.ToDouble(NumUDPV.Value);
                double dva = 0;
                if (txtAttaque.Text != "")
                    dva = Convert.ToDouble(txtAttaque.Text);
                double pea = Convert.ToDouble(NumUDAttaque.Value);
                double dvd = 0;
                if (txtDéfense.Text != "")
                    dvd = Convert.ToDouble(txtDéfense.Text);
                double ped = Convert.ToDouble(NumUDDéfense.Value);
                double dvas = 0;
                if (txtAS.Text != "")
                    dvas = Convert.ToDouble(txtAS.Text);
                double peas = Convert.ToDouble(NumUDAS.Value);
                double dvds = 0;
                if (txtDS.Text != "")
                    dvds = Convert.ToDouble(txtDS.Text);
                double peds = Convert.ToDouble(NumUDDS.Value);
                double dvv = 0;
                if (txtVitesse.Text != "")
                    dvv = Convert.ToDouble(txtVitesse.Text);
                double pev = Convert.ToDouble(NumUDVitesse.Value);

                if (txtPV.Text != "")
                    lbPV.Text = "PV: " + Convert.ToString(Math.Truncate(((2 * CurrentPokemon.Stat_PV + dvpv + Math.Truncate(pepv / 4)) * N / 100 + 10 + N)));
                if (txtAttaque.Text != "")
                    lbAttaque.Text = "A: " + Convert.ToString(Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Attaque + dva + Math.Truncate(pea / 4)) * N / 100 + 5) * Nature[0]));
                if (txtDéfense.Text != "")
                    lbDéfense.Text = "D: " + Convert.ToString(Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Défense + dvd + Math.Truncate(ped / 4)) * N / 100 + 5) * Nature[1]));
                if (txtAS.Text != "")
                    lbAS.Text = "AS: " + Convert.ToString(Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_AttaqueSpé + dvas + Math.Truncate(peas / 4)) * N / 100 + 5) * Nature[3]));
                if (txtDS.Text != "")
                    lbDS.Text = "DS: " + Convert.ToString(Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_DéfenseSpé + dvds + Math.Truncate(peds / 4)) * N / 100 + 5) * Nature[4]));
                if (txtVitesse.Text != "")
                    lbVitesse.Text = "V: " + Convert.ToString(Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Vitesse + dvv + Math.Truncate(pev / 4)) * N / 100 + 5) * Nature[2]));
            }
        }

        private void txtPV_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtPV.Text);
                if (i > 31)
                    txtPV.Text = "31";
            }
            catch { txtPV.Text = ""; }
        }

        private void txtAttaque_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtAttaque.Text);
                if (i > 31)
                    txtAttaque.Text = "31";
            }
            catch { txtAttaque.Text = ""; }
        }

        private void txtDéfense_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtDéfense.Text);
                if (i > 31)
                    txtDéfense.Text = "31";
            }
            catch { txtDéfense.Text = ""; }
        }

        private void txtAS_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtAS.Text);
                if (i > 31)
                    txtAS.Text = "31";
            }
            catch { txtAS.Text = ""; }
        }

        private void txtDS_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtDS.Text);
                if (i > 31)
                    txtDS.Text = "31";
            }
            catch { txtDS.Text = ""; }
        }

        private void txtVitesse_Leave(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txtVitesse.Text);
                if (i > 31)
                    txtVitesse.Text = "31";
            }
            catch { txtVitesse.Text = ""; }
        }

        private void btCharger_Click(object sender, EventArgs e)
        {
            FormFicheOpen f = new FormFicheOpen();
            if (f.ShowDialog() == DialogResult.OK && f.Filename != "")
            {
                
                Ouvrir(f.Filename);
            }
        }

        public void Ouvrir(string filename)
        {
            XmlDocument dom = new XmlDocument();
            dom.Load(filename);
            XmlElement root = dom.DocumentElement;

            Directory.SetCurrentDirectory(Xblood.CurrentDirectory);

            XmlElement DV = null;
            XmlElement PE = null;
            XmlElement Cap = null;
            XmlElement Symb = null;
            foreach (XmlElement el in root)
            {
                switch (el.Name)
                {
                    case "SYMBOLES":
                        Symb = el;
                        break;
                    case "CAPACITES":
                        Cap = el;
                        break;
                    case "PE":
                        PE = el;
                        break;
                    case "DV":
                        DV = el;
                        break;
                    default:
                        break;
                }
            }

            if (root.Attributes["couleur"].Value == "normal")
                rbNormal.Checked = true;
            else
                rbShiney.Checked = true;

            if (root.Attributes["espece"].Value != "")
                ComboPokémon.SelectedItem = root.Attributes["espece"].Value;
            txtPseudo.Text = root.Attributes["pseudo"].Value;

            switch (root.Attributes["sexe"].Value)
            {
                case "Male":
                    rbMale.Checked = true;
                    break;
                case "Femelle":
                    rbFemelle.Checked = true;
                    break;
                case "Assexue":
                    rbAssexué.Checked = true;
                    break;
                default:
                    break;
            }

            if (root.Attributes["nature"].Value != "")
                ComboNature.SelectedItem = root.Attributes["nature"].Value;
            if (root.Attributes["capacitespe"].Value != "")
                ComboCapacitéSpé.SelectedItem = root.Attributes["capacitespe"].Value;

            NumUDNiveau.Value = Convert.ToDecimal(root.Attributes["niveau"].Value);

            chkCarré.Checked = Convert.ToBoolean(Symb.Attributes["carre"].Value);
            chkRond.Checked = Convert.ToBoolean(Symb.Attributes["rond"].Value);
            chkTriangle.Checked = Convert.ToBoolean(Symb.Attributes["triangle"].Value);
            chkCoeur.Checked = Convert.ToBoolean(Symb.Attributes["coeur"].Value);

            if (Symb.HasAttribute("etoile"))
                chketoile.Checked = Convert.ToBoolean(Symb.Attributes["etoile"].Value);
            if (Symb.HasAttribute("losange"))
                chklosange.Checked = Convert.ToBoolean(Symb.Attributes["losange"].Value);

            try
            {
                string str = Cap.Attributes["nom1"].Value;
                if (str != "")
                    ComboC1.SelectedItem = str;
                else
                    ComboC1.SelectedItem = "(vide)";
            }
            catch { ComboC1.SelectedItem = "(vide)"; }
            try
            {
                string str = Cap.Attributes["nom2"].Value;
                if (str != "")
                    ComboC2.SelectedItem = str;
                else
                    ComboC2.SelectedItem = "(vide)";
            }
            catch { ComboC2.SelectedItem = "(vide)"; }
            try
            {
                string str = Cap.Attributes["nom3"].Value;
                if (str != "")
                    ComboC3.SelectedItem = str;
                else
                    ComboC3.SelectedItem = "(vide)";
            }
            catch { ComboC3.SelectedItem = "(vide)"; }
            try
            {
                string str = Cap.Attributes["nom4"].Value;
                if (str != "")
                    ComboC4.SelectedItem = str;
                else
                    ComboC4.SelectedItem = "(vide)";
            }
            catch { ComboC4.SelectedItem = "(vide)"; }

            if (DV.Attributes["pv"].Value != "-1")
                txtPV.Text = DV.Attributes["pv"].Value;
            else
                txtPV.Text = "";
            if (DV.Attributes["a"].Value != "-1")
                txtAttaque.Text = DV.Attributes["a"].Value;
            else
                txtAttaque.Text = "";
            if (DV.Attributes["d"].Value != "-1")
                txtDéfense.Text = DV.Attributes["d"].Value;
            else
                txtDéfense.Text = "";
            if (DV.Attributes["as"].Value != "-1")
                txtAS.Text = DV.Attributes["as"].Value;
            else
                txtAS.Text = "";
            if (DV.Attributes["ds"].Value != "-1")
                txtDS.Text = DV.Attributes["ds"].Value;
            else
                txtDS.Text = "";
            if (DV.Attributes["v"].Value != "-1")
                txtVitesse.Text = DV.Attributes["v"].Value;
            else
                txtVitesse.Text = "";

            NumUDPV.Value = Convert.ToDecimal(PE.Attributes["pv"].Value);
            NumUDAttaque.Value = Convert.ToDecimal(PE.Attributes["a"].Value);
            NumUDDéfense.Value = Convert.ToDecimal(PE.Attributes["d"].Value);
            NumUDAS.Value = Convert.ToDecimal(PE.Attributes["as"].Value);
            NumUDDS.Value = Convert.ToDecimal(PE.Attributes["ds"].Value);
            NumUDVitesse.Value = Convert.ToDecimal(PE.Attributes["v"].Value);
        }

        public void Ouvrir(Pokemon p)
        {
            ComboPokémon.Text = p.Nom;
            if(p.Capacités_fiche[0] != null)
                ComboC1.Text = p.Capacités_fiche[0].Nom;
            if (p.Capacités_fiche[1] != null)
                ComboC2.Text = p.Capacités_fiche[1].Nom;
            if (p.Capacités_fiche[2] != null)
                ComboC3.Text = p.Capacités_fiche[2].Nom;
            if (p.Capacités_fiche[3] != null)
                ComboC4.Text = p.Capacités_fiche[3].Nom;

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPokémon.Text == "")
                return;
            string pic = CurrentPokemon.Numéro.ToString();
            while (pic.Length < 3)
                pic = "0" + pic;

            string apparence;
            if (rbNormal.Checked)
                apparence = @"Normal\pkrs";
            else
                apparence = @"Shiney\pkrssh";

            pic = @"Images\" + apparence + pic + ".gif";
            pictureBox1.ImageLocation = pic;
        }

        private void rbShiney_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboPokémon.Text == "")
                return;
            string pic = CurrentPokemon.Numéro.ToString();
            while (pic.Length < 3)
                pic = "0" + pic;

            string apparence;
            if (rbNormal.Checked)
                apparence = @"Normal\pkrs";
            else
                apparence = @"Shiney\pkrssh";

            pic = @"Images\" + apparence + pic + ".gif";
            pictureBox1.ImageLocation = pic;
        }

        private void txtPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < (int)'0' || (int)e.KeyChar > (int)'9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else
            {
                TextBox txt = (TextBox)sender;
                int i;

                bool isint = int.TryParse(txt.Text, out i);
                if (isint)
                {
                    if (i > 31)
                        txt.Text = "31";
                }
            }
        }
    }
}