namespace URA_Pokemon
{
    partial class FormAccouplement
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
            this.lblResult = new System.Windows.Forms.Label();
            this.ComboPokémon = new System.Windows.Forms.ComboBox();
            this.btChercher = new System.Windows.Forms.Button();
            this.TVrésultat = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLeaf = new System.Windows.Forms.Label();
            this.lblBranches = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.btDeployer = new System.Windows.Forms.Button();
            this.lblNiveaux = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.NumUDDepth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCapacité1 = new System.Windows.Forms.TextBox();
            this.txtCapacité2 = new System.Windows.Forms.TextBox();
            this.btGetMove1 = new System.Windows.Forms.Button();
            this.btGetMove2 = new System.Windows.Forms.Button();
            this.btGetMove4 = new System.Windows.Forms.Button();
            this.btGetMove3 = new System.Windows.Forms.Button();
            this.txtCapacité4 = new System.Windows.Forms.TextBox();
            this.txtCapacité3 = new System.Windows.Forms.TextBox();
            this.btClear1 = new System.Windows.Forms.Button();
            this.btClear2 = new System.Windows.Forms.Button();
            this.btClear3 = new System.Windows.Forms.Button();
            this.btClear4 = new System.Windows.Forms.Button();
            this.lbrecordmax = new System.Windows.Forms.Label();
            this.lbrecordmin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(141, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(143, 23);
            this.lblResult.TabIndex = 1;
            // 
            // ComboPokémon
            // 
            this.ComboPokémon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboPokémon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPokémon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPokémon.Location = new System.Drawing.Point(12, 28);
            this.ComboPokémon.MaxDropDownItems = 30;
            this.ComboPokémon.Name = "ComboPokémon";
            this.ComboPokémon.Size = new System.Drawing.Size(121, 21);
            this.ComboPokémon.TabIndex = 0;
            this.ComboPokémon.SelectedIndexChanged += new System.EventHandler(this.ComboPokémon_SelectedIndexChanged);
            // 
            // btChercher
            // 
            this.btChercher.Location = new System.Drawing.Point(12, 128);
            this.btChercher.Name = "btChercher";
            this.btChercher.Size = new System.Drawing.Size(64, 23);
            this.btChercher.TabIndex = 3;
            this.btChercher.Text = "Chercher";
            this.btChercher.UseVisualStyleBackColor = true;
            this.btChercher.Click += new System.EventHandler(this.btCherche_Click);
            // 
            // TVrésultat
            // 
            this.TVrésultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TVrésultat.ContextMenuStrip = this.contextMenuStrip1;
            this.TVrésultat.Location = new System.Drawing.Point(12, 157);
            this.TVrésultat.Name = "TVrésultat";
            this.TVrésultat.Size = new System.Drawing.Size(400, 274);
            this.TVrésultat.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptionToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.descriptionToolStripMenuItem.Text = "Description...";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.typeToolStripMenuItem.Text = "Type...";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // lblLeaf
            // 
            this.lblLeaf.Location = new System.Drawing.Point(362, 28);
            this.lblLeaf.Name = "lblLeaf";
            this.lblLeaf.Size = new System.Drawing.Size(45, 23);
            this.lblLeaf.TabIndex = 10;
            // 
            // lblBranches
            // 
            this.lblBranches.Location = new System.Drawing.Point(304, 28);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(43, 21);
            this.lblBranches.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(8, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Déployer tout";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NumUD
            // 
            this.NumUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumUD.Enabled = false;
            this.NumUD.Location = new System.Drawing.Point(135, 14);
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(38, 20);
            this.NumUD.TabIndex = 1;
            // 
            // btDeployer
            // 
            this.btDeployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeployer.Location = new System.Drawing.Point(242, 11);
            this.btDeployer.Name = "btDeployer";
            this.btDeployer.Size = new System.Drawing.Size(91, 23);
            this.btDeployer.TabIndex = 2;
            this.btDeployer.Text = "Déployer";
            this.btDeployer.UseVisualStyleBackColor = true;
            this.btDeployer.Click += new System.EventHandler(this.btDeployer_Click);
            // 
            // lblNiveaux
            // 
            this.lblNiveaux.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNiveaux.AutoSize = true;
            this.lblNiveaux.Enabled = false;
            this.lblNiveaux.Location = new System.Drawing.Point(179, 18);
            this.lblNiveaux.Name = "lblNiveaux";
            this.lblNiveaux.Size = new System.Drawing.Size(44, 13);
            this.lblNiveaux.TabIndex = 15;
            this.lblNiveaux.Text = "niveaux";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "OU";
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(82, 128);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(64, 23);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // NumUDDepth
            // 
            this.NumUDDepth.Location = new System.Drawing.Point(266, 128);
            this.NumUDDepth.Name = "NumUDDepth";
            this.NumUDDepth.Size = new System.Drawing.Size(32, 20);
            this.NumUDDepth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pokémon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Limiter la recherche à";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "niveau(x)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Branches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Feuilles";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.NumUD);
            this.groupBox1.Controls.Add(this.btDeployer);
            this.groupBox1.Controls.Add(this.lblNiveaux);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 40);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Déploiement";
            // 
            // txtCapacité1
            // 
            this.txtCapacité1.Location = new System.Drawing.Point(12, 55);
            this.txtCapacité1.Name = "txtCapacité1";
            this.txtCapacité1.ReadOnly = true;
            this.txtCapacité1.Size = new System.Drawing.Size(100, 20);
            this.txtCapacité1.TabIndex = 27;
            // 
            // txtCapacité2
            // 
            this.txtCapacité2.Location = new System.Drawing.Point(184, 55);
            this.txtCapacité2.Name = "txtCapacité2";
            this.txtCapacité2.ReadOnly = true;
            this.txtCapacité2.Size = new System.Drawing.Size(100, 20);
            this.txtCapacité2.TabIndex = 28;
            // 
            // btGetMove1
            // 
            this.btGetMove1.Location = new System.Drawing.Point(118, 55);
            this.btGetMove1.Name = "btGetMove1";
            this.btGetMove1.Size = new System.Drawing.Size(28, 21);
            this.btGetMove1.TabIndex = 29;
            this.btGetMove1.Text = "...";
            this.btGetMove1.UseVisualStyleBackColor = true;
            this.btGetMove1.Click += new System.EventHandler(this.btGetMove1_Click);
            // 
            // btGetMove2
            // 
            this.btGetMove2.Location = new System.Drawing.Point(290, 55);
            this.btGetMove2.Name = "btGetMove2";
            this.btGetMove2.Size = new System.Drawing.Size(28, 20);
            this.btGetMove2.TabIndex = 30;
            this.btGetMove2.Text = "...";
            this.btGetMove2.UseVisualStyleBackColor = true;
            this.btGetMove2.Click += new System.EventHandler(this.btGetMove2_Click);
            // 
            // btGetMove4
            // 
            this.btGetMove4.Location = new System.Drawing.Point(290, 81);
            this.btGetMove4.Name = "btGetMove4";
            this.btGetMove4.Size = new System.Drawing.Size(28, 21);
            this.btGetMove4.TabIndex = 34;
            this.btGetMove4.Text = "...";
            this.btGetMove4.UseVisualStyleBackColor = true;
            this.btGetMove4.Click += new System.EventHandler(this.btGetMove4_Click);
            // 
            // btGetMove3
            // 
            this.btGetMove3.Location = new System.Drawing.Point(118, 81);
            this.btGetMove3.Name = "btGetMove3";
            this.btGetMove3.Size = new System.Drawing.Size(28, 21);
            this.btGetMove3.TabIndex = 33;
            this.btGetMove3.Text = "...";
            this.btGetMove3.UseVisualStyleBackColor = true;
            this.btGetMove3.Click += new System.EventHandler(this.btGetMove3_Click);
            // 
            // txtCapacité4
            // 
            this.txtCapacité4.Location = new System.Drawing.Point(184, 81);
            this.txtCapacité4.Name = "txtCapacité4";
            this.txtCapacité4.ReadOnly = true;
            this.txtCapacité4.Size = new System.Drawing.Size(100, 20);
            this.txtCapacité4.TabIndex = 32;
            // 
            // txtCapacité3
            // 
            this.txtCapacité3.Location = new System.Drawing.Point(12, 81);
            this.txtCapacité3.Name = "txtCapacité3";
            this.txtCapacité3.ReadOnly = true;
            this.txtCapacité3.Size = new System.Drawing.Size(100, 20);
            this.txtCapacité3.TabIndex = 31;
            // 
            // btClear1
            // 
            this.btClear1.Location = new System.Drawing.Point(152, 55);
            this.btClear1.Name = "btClear1";
            this.btClear1.Size = new System.Drawing.Size(26, 20);
            this.btClear1.TabIndex = 35;
            this.btClear1.Text = "C";
            this.btClear1.UseVisualStyleBackColor = true;
            this.btClear1.Click += new System.EventHandler(this.btClear1_Click);
            // 
            // btClear2
            // 
            this.btClear2.Location = new System.Drawing.Point(321, 55);
            this.btClear2.Name = "btClear2";
            this.btClear2.Size = new System.Drawing.Size(26, 20);
            this.btClear2.TabIndex = 36;
            this.btClear2.Text = "C";
            this.btClear2.UseVisualStyleBackColor = true;
            this.btClear2.Click += new System.EventHandler(this.btClear2_Click);
            // 
            // btClear3
            // 
            this.btClear3.Location = new System.Drawing.Point(152, 81);
            this.btClear3.Name = "btClear3";
            this.btClear3.Size = new System.Drawing.Size(26, 20);
            this.btClear3.TabIndex = 37;
            this.btClear3.Text = "C";
            this.btClear3.UseVisualStyleBackColor = true;
            this.btClear3.Click += new System.EventHandler(this.btClear3_Click);
            // 
            // btClear4
            // 
            this.btClear4.Location = new System.Drawing.Point(321, 81);
            this.btClear4.Name = "btClear4";
            this.btClear4.Size = new System.Drawing.Size(26, 20);
            this.btClear4.TabIndex = 38;
            this.btClear4.Text = "C";
            this.btClear4.UseVisualStyleBackColor = true;
            this.btClear4.Click += new System.EventHandler(this.btClear4_Click);
            // 
            // lbrecordmax
            // 
            this.lbrecordmax.AutoSize = true;
            this.lbrecordmax.Location = new System.Drawing.Point(353, 81);
            this.lbrecordmax.Name = "lbrecordmax";
            this.lbrecordmax.Size = new System.Drawing.Size(35, 13);
            this.lbrecordmax.TabIndex = 39;
            this.lbrecordmax.Text = "Maxi: ";
            // 
            // lbrecordmin
            // 
            this.lbrecordmin.AutoSize = true;
            this.lbrecordmin.Location = new System.Drawing.Point(353, 59);
            this.lbrecordmin.Name = "lbrecordmin";
            this.lbrecordmin.Size = new System.Drawing.Size(29, 13);
            this.lbrecordmin.TabIndex = 40;
            this.lbrecordmin.Text = "Mini:";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAccouplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 489);
            this.Controls.Add(this.lbrecordmin);
            this.Controls.Add(this.lbrecordmax);
            this.Controls.Add(this.btClear4);
            this.Controls.Add(this.btClear3);
            this.Controls.Add(this.btClear2);
            this.Controls.Add(this.btClear1);
            this.Controls.Add(this.btGetMove4);
            this.Controls.Add(this.btGetMove3);
            this.Controls.Add(this.txtCapacité4);
            this.Controls.Add(this.txtCapacité3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btGetMove2);
            this.Controls.Add(this.btGetMove1);
            this.Controls.Add(this.txtCapacité2);
            this.Controls.Add(this.txtCapacité1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBranches);
            this.Controls.Add(this.NumUDDepth);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.lblLeaf);
            this.Controls.Add(this.TVrésultat);
            this.Controls.Add(this.btChercher);
            this.Controls.Add(this.ComboPokémon);
            this.Controls.Add(this.lblResult);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(432, 300);
            this.Name = "FormAccouplement";
            this.Text = "Accouplement";
            this.Load += new System.EventHandler(this.FormAccouplement_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox ComboPokémon;
        private System.Windows.Forms.Button btChercher;
        private System.Windows.Forms.TreeView TVrésultat;
        private System.Windows.Forms.Label lblLeaf;
        private System.Windows.Forms.Label lblBranches;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown NumUD;
        private System.Windows.Forms.Button btDeployer;
        private System.Windows.Forms.Label lblNiveaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.NumericUpDown NumUDDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCapacité1;
        private System.Windows.Forms.TextBox txtCapacité2;
        private System.Windows.Forms.Button btGetMove1;
        private System.Windows.Forms.Button btGetMove2;
        private System.Windows.Forms.Button btGetMove4;
        private System.Windows.Forms.Button btGetMove3;
        private System.Windows.Forms.TextBox txtCapacité4;
        private System.Windows.Forms.TextBox txtCapacité3;
        private System.Windows.Forms.Button btClear1;
        private System.Windows.Forms.Button btClear2;
        private System.Windows.Forms.Button btClear3;
        private System.Windows.Forms.Button btClear4;
        private System.Windows.Forms.Label lbrecordmax;
        private System.Windows.Forms.Label lbrecordmin;
        private System.Windows.Forms.Timer timer1;
    }
}