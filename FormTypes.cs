using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormTypes : Form
    {
        int index1 = 0;
        int index2 = 0;
        bool calcul = false;

        public FormTypes()
        {
            InitializeComponent();
            if (Xblood.Types == null)
                Xblood.FillTypes();
        }

        public FormTypes(Pokemon p)
        {
            InitializeComponent();
            if (Xblood.Types == null)
                Xblood.FillTypes();
            index1 = (int)p.Type1;
            if (p.Type2 == Type.AUCUN)
                index2 = 0;
            else
                index2 = (int)p.Type2 + 1;

            calcul = true;
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {
            FillComboType1();
            FillComboType2();
            if (calcul)
            {
                ComboType1.SelectedIndex = index1;
                ComboType2.SelectedIndex = index2;
                Calculer();
            }
        }

        void FillComboType1()
        {
            foreach (string type in Xblood.NomsTypes)
                ComboType1.Items.Add(type);
        }

        void FillComboType2()
        {
            ComboType2.Items.Add("AUCUN");
            foreach (string type in Xblood.NomsTypes)
                ComboType2.Items.Add(type);
        }

        void Calculer()
        {
            int t1 = ComboType1.SelectedIndex;
            lbEfficace.Text = "Efficace contre:\r\n";
            lbPeuEfficace.Text = "Peu efficace contre:\r\n";
            lbRésistance.Text = "Résistance:\r\n";
            lbFaiblesse.Text = "Faiblesse:\r\n";
            lbT1.Text = "";
            lbT2.Text = "";

            if (ComboType2.Text == "AUCUN" || ComboType2.Text == "" || ComboType1.Text == ComboType2.Text)
            {
                for (int i = 0; i < 17; i++)
                {
                    if (Xblood.Types[t1, i] == 2)
                        lbEfficace.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[t1, i] == -2)
                        lbPeuEfficace.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[t1, i] == 7)
                        lbPeuEfficace.Text += Xblood.NomsTypes[i] + "(pas d'effet), ";

                    if (Xblood.Types[i, t1] == -2)
                        lbRésistance.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[i, t1] == 7)
                        lbRésistance.Text += Xblood.NomsTypes[i] + "(immunisé), ";
                    else if (Xblood.Types[i, t1] == 2)
                        lbFaiblesse.Text += Xblood.NomsTypes[i] + ", ";
                }

            }
            else
            {
                lbT1.Text = "Peu efficace (tableau dissocié, " + ComboType1.Text + "):\r\n";
                lbT2.Text = "Peu efficace (tableau dissocié, " + ComboType2.Text + "):\r\n";
                int t2 = ComboType2.SelectedIndex - 1;
                for (int i = 0; i < 17; i++)
                {
                    if (Xblood.Types[t1, i] == 2 || Xblood.Types[t2, i] == 2)
                        lbEfficace.Text += Xblood.NomsTypes[i] + ", ";
                    else if ((Xblood.Types[t1, i] == -2 && (Xblood.Types[t2, i] < 0 || Xblood.Types[t2, i] == 7)) || (Xblood.Types[t2, i] == -2 && (Xblood.Types[t1, i] < 0 || Xblood.Types[t1, i] == 7)))
                        lbPeuEfficace.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[t1, i] == 7 && Xblood.Types[t2, i] == 7)
                        lbPeuEfficace.Text += Xblood.NomsTypes[i] + "(pas d'effet), ";

                    if (Xblood.Types[t1, i] == -2)
                        lbT1.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[t1, i] == 7)
                        lbT1.Text += Xblood.NomsTypes[i] + "(pas d'effet), ";

                    if (Xblood.Types[t2, i] == -2)
                        lbT2.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[t2, i] == 7)
                        lbT2.Text += Xblood.NomsTypes[i] + "(pas d'effet), ";

                    if (Xblood.Types[i, t1] + Xblood.Types[i, t2] == -2)
                        lbRésistance.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[i, t1] + Xblood.Types[i, t2] == -4)
                        lbRésistance.Text += Xblood.NomsTypes[i] + "(x4), ";
                    else if (Xblood.Types[i, t1] == 7 || Xblood.Types[i, t2] == 7)
                        lbRésistance.Text += Xblood.NomsTypes[i] + "(immunisé), ";
                    else if (Xblood.Types[i, t1] + Xblood.Types[i, t2] == 2)
                        lbFaiblesse.Text += Xblood.NomsTypes[i] + ", ";
                    else if (Xblood.Types[i, t1] + Xblood.Types[i, t2] == 4)
                        lbFaiblesse.Text += Xblood.NomsTypes[i] + "(x4), ";
                }
                lbT1.Text = lbT1.Text.Substring(0, lbT1.Text.Length - 2);
                lbT2.Text = lbT2.Text.Substring(0, lbT2.Text.Length - 2);
            }
            lbEfficace.Text = lbEfficace.Text.Substring(0, lbEfficace.Text.Length - 2);
            lbPeuEfficace.Text = lbPeuEfficace.Text.Substring(0, lbPeuEfficace.Text.Length - 2);
            lbRésistance.Text = lbRésistance.Text.Substring(0, lbRésistance.Text.Length - 2);
            lbFaiblesse.Text = lbFaiblesse.Text.Substring(0, lbFaiblesse.Text.Length - 2);
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            if (ComboType1.SelectedIndex != -1)
                Calculer();
        }
    }
}