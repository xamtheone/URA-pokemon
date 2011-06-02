using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormCapSpe : Form
    {
        public FormCapSpe()
        {
            InitializeComponent();
        }

        private void FormCapSpe_Load(object sender, EventArgs e)
        {
            FillComboCapSpe();
        }

        void FillComboCapSpe()
        {
            foreach (CapSpe c in Xblood.CSlist)
                ComboCapSpe.Items.Add(c.nom);
        }

        private void ComboCapSpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapSpe c = Xblood.GetCapSpe(ComboCapSpe.Text);
            txtDescription.Text = c.description;
        }
    }
}