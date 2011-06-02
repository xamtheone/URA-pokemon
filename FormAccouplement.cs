using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.IO;

namespace URA_Pokemon
{
    public partial class FormAccouplement : Form
    {
        Thread t;
        Noeud n;
        Xblood X;
        static Mutex muteur = new Mutex();

        public FormAccouplement()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
            this.KickTreeView += new EventHandler(Form2_KickTreeView);
        }

        void Xblood_BranchAdded(object sender, EventArgs e)
        {
            RefreshLabelBranche();
        }

        void RefreshLabelBranche()
        {
            lblBranches.Text = X.branches.ToString();
        }

        void Form2_KickTreeView(object sender, EventArgs e)
        {
            TVrésultat.Visible = false;
            LoadTV(n);
            TVrésultat.TreeViewNodeSorter = new NodeSorter();
            TVrésultat.Sort();
            if (checkBox1.Checked)
                TVrésultat.ExpandAll();
            else if (NumUD.Value > 0 && TVrésultat.Nodes.Count > 0)
                ExpandTV(0, TVrésultat.Nodes[0]);
            TVrésultat.Visible = true;
        }

        private void ExpandTV(int p, TreeNode n)
        {
            if (p < NumUD.Value)
            {
                n.Expand();
                if ((p + 1) < NumUD.Value)
                {
                    foreach (TreeNode tn in n.Nodes)
                        ExpandTV(p + 1, tn);
                }
            }
        }

        public event EventHandler KickTreeView;

        void OnKickTreeView(EventArgs e)
        {
            if (KickTreeView != null)
                KickTreeView(this, e);
        }

        void Xblood_Finished(object sender, EventArgs e)
        {
            timer1.Stop();
            lblLeaf.Text = X.leafs.ToString();
            lblBranches.Text = X.branches.ToString();
            lblResult.Text = "Charge l'arborescence...";

            Thread.Sleep(10);
            n = (Noeud)sender;

            //try
            //{
            //    muteur.WaitOne();
            //}
            //catch (AbandonedMutexException)
            //{
            //    muteur.ReleaseMutex();
            //    muteur.WaitOne();
            //}
            this.Invoke(KickTreeView);
            //muteur.ReleaseMutex();
        }

        void Xblood_LeafFound(object sender, EventArgs e)
        {
            /*
            CallRefreshlbLeaf i = new CallRefreshlbLeaf(RefreshLabelLeaf);
            this.Invoke(i);
            */
            //try
            //{
            //    muteur.WaitOne();
            //}
            //catch (AbandonedMutexException)
            //{
            //    muteur.ReleaseMutex();
            //    muteur.WaitOne();
            //}

                
                

            RefreshLabelLeaf();
            //muteur.ReleaseMutex();
        }

        void RefreshLabelLeaf()
        {
            muteur.WaitOne();
            
            muteur.ReleaseMutex();
        }

        void FillComboPokémon()
        {
            ComboPokémon.Text = "";
            ComboPokémon.Items.Clear();
            
            foreach (Pokemon p in X.PKlist)
                ComboPokémon.Items.Add(p.Nom);
                
        }

        private void btCherche_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                try
                {
                    //TODO modifier l'accès au pokémon par l'index du combo
                    Pokemon p = X.PKlist[ComboPokémon.SelectedIndex];
                    if (p.dependevo)
                    {
                        Pokemon evo = X.GetPokémon(p.evolution.ToArray()[0].nom);
                        Pokemon p2 = new Pokemon();
                        X.CopyPokemon(p, p2);
                        p2.Oeuf1 = evo.Oeuf1;
                        p2.Oeuf2 = evo.Oeuf2;
                        X.argPokemon = p2;
                    }
                    else
                        X.argPokemon = p;
                    
                    Stack<Capacite> cap = new Stack<Capacite>();

                    if (txtCapacité1.Text == "" && txtCapacité2.Text == "" && txtCapacité3.Text == "" && txtCapacité4.Text == "")
                    {
                        MessageBox.Show("Capacité mal sélectionné, click eul' nom dans la boîte!");
                        return;
                    }
                    if (txtCapacité1.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacité1.Text));
                    if (txtCapacité2.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacité2.Text));
                    if (txtCapacité3.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacité3.Text));
                    if (txtCapacité4.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacité4.Text));

                    X.argCapacite = cap.ToArray();
                    X.deepness = (int)NumUDDepth.Value;
                    
                    lblBranches.Text = "";
                    lblLeaf.Text = "";
                    lblResult.Text = "Recherche...";
                    btChercher.Enabled = false;
                    btStop.Enabled = true;

                    t = new Thread(new ThreadStart(X.StartThread));
                    //t.Priority = ThreadPriority.AboveNormal;
                    
                    t.Start();
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("Pokémon mal sélectionné, click eul' nom dans la boîte!");
                }
            }
            else
                TVrésultat.Nodes.Clear();
        }

        void LoadTV(Noeud n)
        {
            TVrésultat.Nodes.Clear();
            if (n != null)
            {
                TreeNode root = Sousnoeuds(n);
                TVrésultat.Nodes.Add(root);
            }
            lblResult.Text = "Fini!";
            lbrecordmin.Text = "Mini: " + X.recordmin.ToString();
            lbrecordmax.Text = "Maxi: " + X.recordmax.ToString();
            btChercher.Enabled = true;
            btStop.Enabled = false;
        }

        public class NodeSorter : IComparer
        {
            public int Compare(object x, object y)
            {
                TreeNode tx = (TreeNode)x;
                TreeNode ty = (TreeNode)y;

                return tx.Nodes.Count - ty.Nodes.Count;
            }
        }

        TreeNode Sousnoeuds(Noeud nodePK)
        {
            TreeNode Tnode = new TreeNode(nodePK.Nom);
            foreach (Noeud n in nodePK.ChildNodes)
            {
                TreeNode nodeTV = new TreeNode(n.Nom);
                if (n.ChildNodes.Count > 0)
                {
                    TreeNode sousnoeud = Sousnoeuds(n);
                    Tnode.Nodes.Add(sousnoeud);
                }
                else
                    Tnode.Nodes.Add(nodeTV);
            }
            return Tnode;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NumUD.Enabled = false;
                lblNiveaux.Enabled = false;
            }
            else
            {
                NumUD.Enabled = true;
                lblNiveaux.Enabled = true;
            }
        }

        private void btDeployer_Click(object sender, EventArgs e)
        {
            if (TVrésultat.Nodes.Count != 0)
            {
                TVrésultat.CollapseAll();
                if (checkBox1.Checked)
                    TVrésultat.ExpandAll();
                else if (TVrésultat.Nodes.Count > 0)
                    ExpandTV(0, TVrésultat.Nodes[0]);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                t.Abort();
            }
            catch { }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            try
            {
                t.Abort();
                try
                {
                    muteur.ReleaseMutex();
                }
                catch
                { }
                lblResult.Text = "Annulé";
                btStop.Enabled = false;
                btChercher.Enabled = true;
            }
            catch { }
        }

        private void FormAccouplement_Load(object sender, EventArgs e)
        {
            X = new Xblood();
            //X.LeafFound += new EventHandler(Xblood_LeafFound);
            X.Finished += new EventHandler(Xblood_Finished);
            //X.BranchAdded += new EventHandler(Xblood_BranchAdded);
            FillComboPokémon();
            ComboPokémon.Focus();
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TVrésultat.SelectedNode != null)
            {
                Pokemon p = X.GetPokémon(TVrésultat.SelectedNode.Text);
                if (p != null)
                {
                    FormDescription f = new FormDescription();
                    f.Show();
                    f.SetPage(p);
                }
            }
        }

        private void btGetMove1_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacité1, ComboPokémon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pokémon d'abord!");
        }

        private void btGetMove2_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacité2, ComboPokémon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pokémon d'abord!");
        }

        private void btGetMove3_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacité3, ComboPokémon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pokémon d'abord!");
        }

        private void btGetMove4_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacité4, ComboPokémon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pokémon d'abord!");
        }

        private void ComboPokémon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacité1.Text = "";
            txtCapacité2.Text = "";
            txtCapacité3.Text = "";
            txtCapacité4.Text = "";
        }

        private void btClear1_Click(object sender, EventArgs e)
        {
            txtCapacité1.Text = "";
        }

        private void btClear2_Click(object sender, EventArgs e)
        {
            txtCapacité2.Text = "";
        }

        private void btClear3_Click(object sender, EventArgs e)
        {
            txtCapacité3.Text = "";
        }

        private void btClear4_Click(object sender, EventArgs e)
        {
            txtCapacité4.Text = "";
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pokemon p = X.GetPokémon(TVrésultat.SelectedNode.Text);
            FormTypes ft = new FormTypes(p);
            ft.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLeaf.Text = X.leafs.ToString();
            lblBranches.Text = X.branches.ToString();
        }
    }
}