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
        int PokéIndex;
        Xblood xb;

        public FormPopupMouvementSelection(TextBox tbox, int pkm)
        {
            InitializeComponent();
            TxtBox = tbox;
            PokéIndex = pkm;
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
            Pokemon p = xb.PKlist[PokéIndex];
            if (ComboTypeMove.Text == "Oeuf")
            {
                foreach (Capacite c in p.CapacitésOeuf)
                    ComboCapacite.Items.Add(c.Nom);
                //ComboCapacite.Sorted = true;
            }
            else
            {
                //ComboCapacite.Sorted = false;
                foreach (Capacite c in p.CapacitésCT)
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