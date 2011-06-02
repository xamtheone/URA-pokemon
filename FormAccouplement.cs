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
            TVr�sultat.Visible = false;
            LoadTV(n);
            TVr�sultat.TreeViewNodeSorter = new NodeSorter();
            TVr�sultat.Sort();
            if (checkBox1.Checked)
                TVr�sultat.ExpandAll();
            else if (NumUD.Value > 0 && TVr�sultat.Nodes.Count > 0)
                ExpandTV(0, TVr�sultat.Nodes[0]);
            TVr�sultat.Visible = true;
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

        void FillComboPok�mon()
        {
            ComboPok�mon.Text = "";
            ComboPok�mon.Items.Clear();
            
            foreach (Pokemon p in X.PKlist)
                ComboPok�mon.Items.Add(p.Nom);
                
        }

        private void btCherche_Click(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text != "")
            {
                try
                {
                    //TODO modifier l'acc�s au pok�mon par l'index du combo
                    Pokemon p = X.PKlist[ComboPok�mon.SelectedIndex];
                    if (p.dependevo)
                    {
                        Pokemon evo = X.GetPok�mon(p.evolution.ToArray()[0].nom);
                        Pokemon p2 = new Pokemon();
                        X.CopyPokemon(p, p2);
                        p2.Oeuf1 = evo.Oeuf1;
                        p2.Oeuf2 = evo.Oeuf2;
                        X.argPokemon = p2;
                    }
                    else
                        X.argPokemon = p;
                    
                    Stack<Capacite> cap = new Stack<Capacite>();

                    if (txtCapacit�1.Text == "" && txtCapacit�2.Text == "" && txtCapacit�3.Text == "" && txtCapacit�4.Text == "")
                    {
                        MessageBox.Show("Capacit� mal s�lectionn�, click eul' nom dans la bo�te!");
                        return;
                    }
                    if (txtCapacit�1.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacit�1.Text));
                    if (txtCapacit�2.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacit�2.Text));
                    if (txtCapacit�3.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacit�3.Text));
                    if (txtCapacit�4.Text != "")
                        cap.Push(Xblood.GetCapacite(txtCapacit�4.Text));

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
                    MessageBox.Show("Pok�mon mal s�lectionn�, click eul' nom dans la bo�te!");
                }
            }
            else
                TVr�sultat.Nodes.Clear();
        }

        void LoadTV(Noeud n)
        {
            TVr�sultat.Nodes.Clear();
            if (n != null)
            {
                TreeNode root = Sousnoeuds(n);
                TVr�sultat.Nodes.Add(root);
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
            if (TVr�sultat.Nodes.Count != 0)
            {
                TVr�sultat.CollapseAll();
                if (checkBox1.Checked)
                    TVr�sultat.ExpandAll();
                else if (TVr�sultat.Nodes.Count > 0)
                    ExpandTV(0, TVr�sultat.Nodes[0]);
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
                lblResult.Text = "Annul�";
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
            FillComboPok�mon();
            ComboPok�mon.Focus();
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TVr�sultat.SelectedNode != null)
            {
                Pokemon p = X.GetPok�mon(TVr�sultat.SelectedNode.Text);
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
            if (ComboPok�mon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacit�1, ComboPok�mon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pok�mon d'abord!");
        }

        private void btGetMove2_Click(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacit�2, ComboPok�mon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pok�mon d'abord!");
        }

        private void btGetMove3_Click(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacit�3, ComboPok�mon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pok�mon d'abord!");
        }

        private void btGetMove4_Click(object sender, EventArgs e)
        {
            if (ComboPok�mon.Text != "")
            {
                FormPopupMouvementSelection fp = new FormPopupMouvementSelection(txtCapacit�4, ComboPok�mon.SelectedIndex);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Choisi un pok�mon d'abord!");
        }

        private void ComboPok�mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacit�1.Text = "";
            txtCapacit�2.Text = "";
            txtCapacit�3.Text = "";
            txtCapacit�4.Text = "";
        }

        private void btClear1_Click(object sender, EventArgs e)
        {
            txtCapacit�1.Text = "";
        }

        private void btClear2_Click(object sender, EventArgs e)
        {
            txtCapacit�2.Text = "";
        }

        private void btClear3_Click(object sender, EventArgs e)
        {
            txtCapacit�3.Text = "";
        }

        private void btClear4_Click(object sender, EventArgs e)
        {
            txtCapacit�4.Text = "";
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pokemon p = X.GetPok�mon(TVr�sultat.SelectedNode.Text);
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