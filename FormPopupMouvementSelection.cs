using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormPopupMouvementSelection : Form
    {
        TextBox TxtBox;
        int Pok�Index;
        Xblood xb;

        public FormPopupMouvementSelection(TextBox tbox, int pkm)
        {
            InitializeComponent();
            TxtBox = tbox;
            Pok�Index = pkm;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            TxtBox.Text = ComboCapacite.Text;
            this.Close();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboTypeMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboCapacite.Items.Clear();
            Pokemon p = xb.PKlist[Pok�Index];
            if (ComboTypeMove.Text == "Oeuf")
            {
                foreach (Capacite c in p.Capacit�sOeuf)
                    ComboCapacite.Items.Add(c.Nom);
                //ComboCapacite.Sorted = true;
            }
            else
            {
                //ComboCapacite.Sorted = false;
                foreach (Capacite c in p.Capacit�sCT)
                    ComboCapacite.Items.Add(c.Nom);
            }
        }

        private void FormPopupMouvementSelection_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            ComboTypeMove.SelectedIndex = 0;
        }
    }
}