namespace URA_Pokemon
{
    partial class FormFicheOpen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFicheOpen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imgTreeView = new System.Windows.Forms.ImageList(this.components);
            this.btDirParent = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imgListView = new System.Windows.Forms.ImageList(this.components);
            this.lbDossierCourant = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbDossierCourant);
            this.splitContainer1.Panel2.Controls.Add(this.btDirParent);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(531, 370);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imgTreeView;
            this.treeView1.Location = new System.Drawing.Point(12, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(213, 318);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imgTreeView
            // 
            this.imgTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.imgTreeView.TransparentColor = System.Drawing.Color.Black;
            // 
            // btDirParent
            // 
            this.btDirParent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDirParent.Image = ((System.Drawing.Image)(resources.GetObject("btDirParent.Image")));
            this.btDirParent.Location = new System.Drawing.Point(3, 12);
            this.btDirParent.Name = "btDirParent";
            this.btDirParent.Size = new System.Drawing.Size(30, 23);
            this.btDirParent.TabIndex = 1;
            this.btDirParent.UseVisualStyleBackColor = true;
            this.btDirParent.Click += new System.EventHandler(this.btDirParent_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.LargeImageList = this.imgListView;
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 318);
            this.listView1.SmallImageList = this.imgListView;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imgListView
            // 
            this.imgListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListView.ImageSize = new System.Drawing.Size(32, 32);
            this.imgListView.TransparentColor = System.Drawing.Color.Black;
            // 
            // lbDossierCourant
            // 
            this.lbDossierCourant.AutoSize = true;
            this.lbDossierCourant.Location = new System.Drawing.Point(39, 17);
            this.lbDossierCourant.Name = "lbDossierCourant";
            this.lbDossierCourant.Size = new System.Drawing.Size(84, 13);
            this.lbDossierCourant.TabIndex = 6;
            this.lbDossierCourant.Text = "Dossier courant:";
            // 
            // FormFicheOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 370);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormFicheOpen";
            this.Text = "FormDirFiche";
            this.Load += new System.EventHandler(this.FormDirFiche_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDirFiche_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imgListView;
        private System.Windows.Forms.ImageList imgTreeView;
        private System.Windows.Forms.Button btDirParent;
        private System.Windows.Forms.Label lbDossierCourant;

    }
}