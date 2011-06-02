using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace URA_Pokemon
{
    public partial class FormFicheOpen : Form
    {
        string DirFiche = Application.StartupPath + "\\Fiches";

        public string Filename;

        public FormFicheOpen()
        {
            InitializeComponent();
        }

        private void FormDirFiche_Load(object sender, EventArgs e)
        {
            Icon dirIcon = GetDirIcon(DirFiche);
            imgListView.Images.Add(dirIcon);
            imgTreeView.Images.Add(dirIcon);

            BuildTree();
            SetListViewDir(DirFiche);

        }

        void BuildTree()
        {
            treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("Fiches");
            root.Tag = DirFiche;
            root.ImageIndex = 0;
            AddNodes(DirFiche, root);
            treeView1.Nodes.Add(root);
        }

        void AddNodes(string dir, TreeNode root)
        {
            string[] sousreps = Directory.GetDirectories(dir);

            foreach (string rep in sousreps)
            {
                DirectoryInfo di = new DirectoryInfo(rep);
                TreeNode node = new TreeNode(di.Name);
                node.Tag = rep;
                node.ImageIndex = 0;
                AddNodes(rep, node);
                root.Nodes.Add(node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string dir = e.Node.Tag.ToString();
            SetListViewDir(dir);
        }

        void SetListViewDir(string dir)
        {
            listView1.Clear();
            DirectoryInfo dirroot = new DirectoryInfo(dir);

            lbDossierCourant.Text = "Dossier courant: " + dirroot.Name;

            int intdiricon = 0;

            DirectoryInfo[] sousdir = dirroot.GetDirectories();

            foreach (DirectoryInfo d in sousdir)
            {
                ListViewItem item = listView1.Items.Add(d.FullName, d.Name, intdiricon);
                item.Tag = d.FullName;
            }

            FileInfo[] files = dirroot.GetFiles("*.xml");

            foreach (FileInfo file in files)
            {
                Icon i = Icon.ExtractAssociatedIcon(file.FullName);
                string str = Path.GetFileNameWithoutExtension(file.FullName);
                imgListView.Images.Add(i);
                ListViewItem item = listView1.Items.Add(file.FullName, str, imgListView.Images.Count - 1);
                item.Tag = file.FullName;
            }


        }

        void SyncTree(string dir)
        {
            if (treeView1.SelectedNode == null)
                treeView1.SelectedNode = treeView1.TopNode;

            foreach (TreeNode node in treeView1.SelectedNode.Nodes)
            {
                if (node.Tag.ToString() == dir)
                    treeView1.SelectedNode = node;
            }
        }

        private Icon GetDirIcon(string dir)
        {
            Icon icon;
            IntPtr hInst = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);
            Int32 iIcon = 0;
            IntPtr hIcon;
            hIcon = ExtractAssociatedIcon(hInst, dir, ref iIcon);
            icon = Icon.FromHandle(hIcon);
            return icon;
        }

        [DllImport("shell32.dll", EntryPoint = "ExtractAssociatedIcon")]
        private extern static IntPtr ExtractAssociatedIcon
        (
            IntPtr hInst,
            [MarshalAs(UnmanagedType.LPStr)] string lpIconPath,
            ref int lpiIcon
        );

        void Exit(string filename)
        {
            Filename = filename;
            this.Close();
            if (filename != null)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;

            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    string str = listView1.SelectedItems[0].Tag.ToString();
                    if (IsDirectory(str))
                    {
                        SetListViewDir(str);
                        SyncTree(str);
                    }
                    else // fichier
                    {
                        Exit(str);
                    }
                }
            }
        }

        private bool IsDirectory(string path)
        {
            // Utilisation du try/catch si le fichier n'est pas valide.
            try
            {
                // Regarde si le fichier possède l'attribut de dossier.
                if ((new DirectoryInfo(path).Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void FormDirFiche_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                DialogResult = DialogResult.Cancel;
        }

        private void btDirParent_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode != treeView1.TopNode)
                treeView1.SelectedNode = treeView1.SelectedNode.Parent;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}