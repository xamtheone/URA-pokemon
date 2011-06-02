using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace URA_Pokemon
{
    public partial class FormFicheSave_ex : Form
    {
        public FormFicheSave_ex()
        {
            InitializeComponent();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            //Interdiction des caractères
            Regex FileRegex = new Regex("[^\\\\/:*?<>\"|]");
            if (!FileRegex.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Nom invalide.  Les caractères ? : \\ / * \" < > | ne sont pas acceptés.");
            }
            else
            {

            }
        }
    }
}