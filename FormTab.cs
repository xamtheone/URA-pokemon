using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormTab : Form
    {
        public FormTab()
        {
            InitializeComponent();
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDescription f = new FormDescription();
            OpenNew(f, "Description");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Tag != null)
            {
                Form f = (Form)tabControl1.SelectedTab.Tag;
                f.Select();
            }
        }

        private void filtreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltrer f = new FormFiltrer();
            OpenNew(f, "Filtrer par");
        }

        void OpenNew(Form f, string tabNom)
        {
            f.MdiParent = this;
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Enter += new EventHandler(f_Enter);
            TabPage tp = new TabPage(tabNom);
            tp.Tag = f;
            f.Tag = tp;
            tabControl1.TabPages.Add(tp);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        void f_Enter(object sender, EventArgs e)
        {
            TabPage tp = (TabPage)((Form)sender).Tag;
            if (tp != tabControl1.SelectedTab)
                tabControl1.SelectedTab = tp;
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            TabPage tp = (TabPage)((Form)sender).Tag;
            tp.Dispose();
        }
    }
}