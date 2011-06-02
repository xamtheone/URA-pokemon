namespace URA_Pokemon
{
    partial class FormTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ongletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerCourrantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterURAPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 24);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fenêtreToolStripMenuItem,
            this.ongletToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ongletToolStripMenuItem
            // 
            this.ongletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.fermerCourrantToolStripMenuItem});
            this.ongletToolStripMenuItem.Name = "ongletToolStripMenuItem";
            this.ongletToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ongletToolStripMenuItem.Text = "Onglet";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptionToolStripMenuItem,
            this.filtreToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // fermerCourrantToolStripMenuItem
            // 
            this.fermerCourrantToolStripMenuItem.Name = "fermerCourrantToolStripMenuItem";
            this.fermerCourrantToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fermerCourrantToolStripMenuItem.Text = "Fermer";
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleFenêtreToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.quitterURAPokemonToolStripMenuItem});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // nouvelleFenêtreToolStripMenuItem
            // 
            this.nouvelleFenêtreToolStripMenuItem.Name = "nouvelleFenêtreToolStripMenuItem";
            this.nouvelleFenêtreToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nouvelleFenêtreToolStripMenuItem.Text = "Nouvelle fenêtre";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // quitterURAPokemonToolStripMenuItem
            // 
            this.quitterURAPokemonToolStripMenuItem.Name = "quitterURAPokemonToolStripMenuItem";
            this.quitterURAPokemonToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quitterURAPokemonToolStripMenuItem.Text = "Quitter URA-Pokemon";
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // filtreToolStripMenuItem
            // 
            this.filtreToolStripMenuItem.Name = "filtreToolStripMenuItem";
            this.filtreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtreToolStripMenuItem.Text = "Filtre";
            this.filtreToolStripMenuItem.Click += new System.EventHandler(this.filtreToolStripMenuItem_Click);
            // 
            // FormTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTab";
            this.Text = "FormTab";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ongletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerCourrantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterURAPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreToolStripMenuItem;
    }
}