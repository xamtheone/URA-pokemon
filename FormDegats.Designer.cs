namespace URA_Pokemon
{
    partial class FormDegats
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
            this.ComboEfficacite = new System.Windows.Forms.ComboBox();
            this.txtDéfense = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtAttaque = new System.Windows.Forms.TextBox();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSTAB = new System.Windows.Forms.CheckBox();
            this.chkCritique = new System.Windows.Forms.CheckBox();
            this.NudRandom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCalculer = new System.Windows.Forms.Button();
            this.lbResultat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRandom)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboEfficacite
            // 
            this.ComboEfficacite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEfficacite.FormattingEnabled = true;
            this.ComboEfficacite.Items.AddRange(new object[] {
            "x0,25",
            "x0,5",
            "x1",
            "x2",
            "x4"});
            this.ComboEfficacite.Location = new System.Drawing.Point(63, 19);
            this.ComboEfficacite.Name = "ComboEfficacite";
            this.ComboEfficacite.Size = new System.Drawing.Size(46, 21);
            this.ComboEfficacite.TabIndex = 0;
            // 
            // txtDéfense
            // 
            this.txtDéfense.Location = new System.Drawing.Point(63, 45);
            this.txtDéfense.Name = "txtDéfense";
            this.txtDéfense.Size = new System.Drawing.Size(46, 20);
            this.txtDéfense.TabIndex = 1;
            this.txtDéfense.Leave += new System.EventHandler(this.txtDéfense_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboEfficacite);
            this.groupBox1.Controls.Add(this.txtDéfense);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attaqué";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Défense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Efficacité";
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(73, 13);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(39, 20);
            this.txtPuissance.TabIndex = 0;
            this.txtPuissance.Leave += new System.EventHandler(this.txtPuissance_Leave);
            // 
            // txtAttaque
            // 
            this.txtAttaque.Location = new System.Drawing.Point(63, 44);
            this.txtAttaque.Name = "txtAttaque";
            this.txtAttaque.Size = new System.Drawing.Size(46, 20);
            this.txtAttaque.TabIndex = 1;
            this.txtAttaque.Leave += new System.EventHandler(this.txtAttaque_Leave);
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(63, 19);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(46, 20);
            this.txtNiveau.TabIndex = 0;
            this.txtNiveau.Leave += new System.EventHandler(this.txtNiveau_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Attaque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Niveau";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNiveau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAttaque);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attaquant";
            // 
            // chkSTAB
            // 
            this.chkSTAB.AutoSize = true;
            this.chkSTAB.Location = new System.Drawing.Point(9, 39);
            this.chkSTAB.Name = "chkSTAB";
            this.chkSTAB.Size = new System.Drawing.Size(78, 17);
            this.chkSTAB.TabIndex = 1;
            this.chkSTAB.Text = "Même type";
            this.chkSTAB.UseVisualStyleBackColor = true;
            // 
            // chkCritique
            // 
            this.chkCritique.AutoSize = true;
            this.chkCritique.Location = new System.Drawing.Point(9, 62);
            this.chkCritique.Name = "chkCritique";
            this.chkCritique.Size = new System.Drawing.Size(88, 17);
            this.chkCritique.TabIndex = 2;
            this.chkCritique.Text = "Coup critique";
            this.chkCritique.UseVisualStyleBackColor = true;
            // 
            // NudRandom
            // 
            this.NudRandom.Location = new System.Drawing.Point(59, 85);
            this.NudRandom.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NudRandom.Minimum = new decimal(new int[] {
            217,
            0,
            0,
            0});
            this.NudRandom.Name = "NudRandom";
            this.NudRandom.Size = new System.Drawing.Size(53, 20);
            this.NudRandom.TabIndex = 3;
            this.NudRandom.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Random";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPuissance);
            this.groupBox3.Controls.Add(this.NudRandom);
            this.groupBox3.Controls.Add(this.chkSTAB);
            this.groupBox3.Controls.Add(this.chkCritique);
            this.groupBox3.Location = new System.Drawing.Point(134, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attaque";
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(12, 166);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(121, 23);
            this.btCalculer.TabIndex = 3;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // lbResultat
            // 
            this.lbResultat.AutoSize = true;
            this.lbResultat.Location = new System.Drawing.Point(186, 156);
            this.lbResultat.Name = "lbResultat";
            this.lbResultat.Size = new System.Drawing.Size(0, 13);
            this.lbResultat.TabIndex = 17;
            // 
            // FormDegats
            // 
            this.AcceptButton = this.btCalculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 200);
            this.Controls.Add(this.lbResultat);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDegats";
            this.Text = "Dégâts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRandom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboEfficacite;
        private System.Windows.Forms.TextBox txtDéfense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.TextBox txtAttaque;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSTAB;
        private System.Windows.Forms.CheckBox chkCritique;
        private System.Windows.Forms.NumericUpDown NudRandom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label lbResultat;
    }
}