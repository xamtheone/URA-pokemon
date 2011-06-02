using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormCapacites : Form
    {
        Capacite CurrentCapacite;
        Xblood xb;

        public FormCapacites()
        {
            InitializeComponent();
            
        }

        public FormCapacites(Capacite c)
        {
            InitializeComponent();
            

            CurrentCapacite = c;
            

        }

        private void ComboCapacite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Capacite c = Xblood.GetCapacite(ComboCapacite.Text);
            SetPage(c);
        }

        void SetPage(Capacite c)
        {
            lbType.Text = "Type: " + c.TypeAttaque.ToString();
            lbForce.Text = "Force: " + c.Force.ToString();
            lbPrecision.Text = "Précision: " + c.Précision.ToString();
            lbPP.Text = "PP: " + c.pp.ToString();
            if (c.numCT != 0)
                lbCTCS.Text = "CT" + c.numCT;
            else if (c.numCS != 0)
                lbCTCS.Text = "CS" + c.numCS;
            else
                lbCTCS.Text = "";
            txtDescription.Text = c.Description;

            if (c.NatureDegat != NatureDegat.NULL)
                lbNature.Text = "Nature: " + c.NatureDegat.ToString();
            else
                lbNature.Text = "Nature: ";
        }

        void FillComboCapacites()
        {
            foreach (Capacite c in xb.Clist)
                ComboCapacite.Items.Add(c.Nom);
        }

        private void FormCapacites_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboCapacites();
            if(CurrentCapacite != null)
                ComboCapacite.Text = CurrentCapacite.Nom;
        }
    }
}