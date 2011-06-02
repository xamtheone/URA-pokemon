namespace URA_Pokemon
{
    partial class FormDVFinder
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
            this.txtPV = new System.Windows.Forms.TextBox();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtAS = new System.Windows.Forms.TextBox();
            this.txtDéfense = new System.Windows.Forms.TextBox();
            this.txtAttaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSuivant = new System.Windows.Forms.Button();
            this.btPrécédent = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.NumUDNiveau = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboPokémon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNiveauEnAttente = new System.Windows.Forms.Label();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lbDS = new System.Windows.Forms.Label();
            this.lbAS = new System.Windows.Forms.Label();
            this.lbDéfense = new System.Windows.Forms.Label();
            this.lbAttaque = new System.Windows.Forms.Label();
            this.ComboNature = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDNiveau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(9, 32);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(39, 20);
            this.txtPV.TabIndex = 0;
            this.txtPV.Leave += new System.EventHandler(this.txtPV_Leave);
            this.txtPV.Enter += new System.EventHandler(this.txtPV_Enter);
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(121, 76);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(41, 20);
            this.txtVitesse.TabIndex = 5;
            this.txtVitesse.Leave += new System.EventHandler(this.txtPV_Enter);
            this.txtVitesse.Enter += new System.EventHandler(this.txtVitesse_Enter);
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(62, 76);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(39, 20);
            this.txtDS.TabIndex = 4;
            this.txtDS.Leave += new System.EventHandler(this.txtDS_Leave);
            this.txtDS.Enter += new System.EventHandler(this.txtDS_Enter);
            // 
            // txtAS
            // 
            this.txtAS.Location = new System.Drawing.Point(9, 76);
            this.txtAS.Name = "txtAS";
            this.txtAS.Size = new System.Drawing.Size(41, 20);
            this.txtAS.TabIndex = 3;
            this.txtAS.Leave += new System.EventHandler(this.txtAS_Leave);
            this.txtAS.Enter += new System.EventHandler(this.txtAS_Enter);
            // 
            // txtDéfense
            // 
            this.txtDéfense.Location = new System.Drawing.Point(121, 32);
            this.txtDéfense.Name = "txtDéfense";
            this.txtDéfense.Size = new System.Drawing.Size(41, 20);
            this.txtDéfense.TabIndex = 2;
            this.txtDéfense.Leave += new System.EventHandler(this.txtDéfense_Leave);
            this.txtDéfense.Enter += new System.EventHandler(this.txtDéfense_Enter);
            // 
            // txtAttaque
            // 
            this.txtAttaque.Location = new System.Drawing.Point(62, 32);
            this.txtAttaque.Name = "txtAttaque";
            this.txtAttaque.Size = new System.Drawing.Size(39, 20);
            this.txtAttaque.TabIndex = 1;
            this.txtAttaque.Leave += new System.EventHandler(this.txtAttaque_Leave);
            this.txtAttaque.Enter += new System.EventHandler(this.txtAttaque_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vitesse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Défense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Attaque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "PV";
            // 
            // btSuivant
            // 
            this.btSuivant.Location = new System.Drawing.Point(271, 228);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(75, 36);
            this.btSuivant.TabIndex = 3;
            this.btSuivant.Text = "&Suivant";
            this.btSuivant.UseVisualStyleBackColor = true;
            this.btSuivant.Click += new System.EventHandler(this.btSuivant_Click);
            // 
            // btPrécédent
            // 
            this.btPrécédent.Location = new System.Drawing.Point(12, 228);
            this.btPrécédent.Name = "btPrécédent";
            this.btPrécédent.Size = new System.Drawing.Size(75, 36);
            this.btPrécédent.TabIndex = 4;
            this.btPrécédent.Text = "&Précédent";
            this.btPrécédent.UseVisualStyleBackColor = true;
            this.btPrécédent.Click += new System.EventHandler(this.btPrécédent_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNouveau.Location = new System.Drawing.Point(9, 83);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(135, 24);
            this.btNouveau.TabIndex = 2;
            this.btNouveau.Text = "&Nouveau";
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // NumUDNiveau
            // 
            this.NumUDNiveau.Location = new System.Drawing.Point(104, 59);
            this.NumUDNiveau.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDNiveau.Name = "NumUDNiveau";
            this.NumUDNiveau.Size = new System.Drawing.Size(40, 20);
            this.NumUDNiveau.TabIndex = 1;
            this.NumUDNiveau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Niveau de départ:";
            // 
            // ComboPokémon
            // 
            this.ComboPokémon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboPokémon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPokémon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPokémon.FormattingEnabled = true;
            this.ComboPokémon.Location = new System.Drawing.Point(9, 32);
            this.ComboPokémon.MaxDropDownItems = 30;
            this.ComboPokémon.Name = "ComboPokémon";
            this.ComboPokémon.Size = new System.Drawing.Size(135, 21);
            this.ComboPokémon.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pokémon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVitesse);
            this.groupBox1.Controls.Add(this.txtDS);
            this.groupBox1.Controls.Add(this.txtAS);
            this.groupBox1.Controls.Add(this.txtDéfense);
            this.groupBox1.Controls.Add(this.txtAttaque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats actuelles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboPokémon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btNouveau);
            this.groupBox2.Controls.Add(this.NumUDNiveau);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouveau calcul";
            // 
            // lbNiveauEnAttente
            // 
            this.lbNiveauEnAttente.AutoSize = true;
            this.lbNiveauEnAttente.Location = new System.Drawing.Point(12, 137);
            this.lbNiveauEnAttente.Name = "lbNiveauEnAttente";
            this.lbNiveauEnAttente.Size = new System.Drawing.Size(98, 13);
            this.lbNiveauEnAttente.TabIndex = 14;
            this.lbNiveauEnAttente.Text = "Niveau en attente: ";
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(12, 170);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(24, 13);
            this.lbPV.TabIndex = 21;
            this.lbPV.Text = "PV:";
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Location = new System.Drawing.Point(201, 196);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(44, 13);
            this.lbVitesse.TabIndex = 22;
            this.lbVitesse.Text = "Vitesse:";
            // 
            // lbDS
            // 
            this.lbDS.AutoSize = true;
            this.lbDS.Location = new System.Drawing.Point(94, 196);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(25, 13);
            this.lbDS.TabIndex = 23;
            this.lbDS.Text = "DS:";
            // 
            // lbAS
            // 
            this.lbAS.AutoSize = true;
            this.lbAS.Location = new System.Drawing.Point(12, 196);
            this.lbAS.Name = "lbAS";
            this.lbAS.Size = new System.Drawing.Size(24, 13);
            this.lbAS.TabIndex = 24;
            this.lbAS.Text = "AS:";
            // 
            // lbDéfense
            // 
            this.lbDéfense.AutoSize = true;
            this.lbDéfense.Location = new System.Drawing.Point(200, 170);
            this.lbDéfense.Name = "lbDéfense";
            this.lbDéfense.Size = new System.Drawing.Size(50, 13);
            this.lbDéfense.TabIndex = 25;
            this.lbDéfense.Text = "Défense:";
            // 
            // lbAttaque
            // 
            this.lbAttaque.AutoSize = true;
            this.lbAttaque.Location = new System.Drawing.Point(94, 170);
            this.lbAttaque.Name = "lbAttaque";
            this.lbAttaque.Size = new System.Drawing.Size(47, 13);
            this.lbAttaque.TabIndex = 26;
            this.lbAttaque.Text = "Attaque:";
            // 
            // ComboNature
            // 
            this.ComboNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNature.FormattingEnabled = true;
            this.ComboNature.Location = new System.Drawing.Point(225, 129);
            this.ComboNature.MaxDropDownItems = 25;
            this.ComboNature.Name = "ComboNature";
            this.ComboNature.Size = new System.Drawing.Size(121, 21);
            this.ComboNature.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nature";
            // 
            // FormDVFinder
            // 
            this.AcceptButton = this.btSuivant;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btNouveau;
            this.ClientSize = new System.Drawing.Size(361, 276);
            this.Controls.Add(this.ComboNature);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbAttaque);
            this.Controls.Add(this.lbDéfense);
            this.Controls.Add(this.lbAS);
            this.Controls.Add(this.lbDS);
            this.Controls.Add(this.lbVitesse);
            this.Controls.Add(this.lbPV);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btPrécédent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbNiveauEnAttente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDVFinder";
            this.Text = "DVFinder";
            this.Load += new System.EventHandler(this.FormDVFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUDNiveau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtAS;
        private System.Windows.Forms.TextBox txtDéfense;
        private System.Windows.Forms.TextBox txtAttaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button btPrécédent;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.NumericUpDown NumUDNiveau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboPokémon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNiveauEnAttente;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lbDS;
        private System.Windows.Forms.Label lbAS;
        private System.Windows.Forms.Label lbDéfense;
        private System.Windows.Forms.Label lbAttaque;
        private System.Windows.Forms.ComboBox ComboNature;
        private System.Windows.Forms.Label label9;
    }
}