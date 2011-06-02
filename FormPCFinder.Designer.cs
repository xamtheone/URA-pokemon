namespace URA_Pokemon
{
    partial class formPCfinder
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
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbforce = new System.Windows.Forms.Label();
            this.txtpv = new System.Windows.Forms.NumericUpDown();
            this.txtattspé = new System.Windows.Forms.NumericUpDown();
            this.txtatt = new System.Windows.Forms.NumericUpDown();
            this.txtdefspé = new System.Windows.Forms.NumericUpDown();
            this.txtdef = new System.Windows.Forms.NumericUpDown();
            this.txtvit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtpv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtattspé)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdefspé)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvit)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(193, 93);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "Calculer";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Att";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Def";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attspé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Defspé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vit";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(17, 134);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(156, 13);
            this.lb1.TabIndex = 13;
            this.lb1.Text = "Type de la puissance cachée : ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(17, 170);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(159, 13);
            this.lb2.TabIndex = 14;
            this.lb2.Text = "Force de la puissance cachée : ";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(179, 134);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(0, 13);
            this.lbtype.TabIndex = 15;
            // 
            // lbforce
            // 
            this.lbforce.AutoSize = true;
            this.lbforce.Location = new System.Drawing.Point(182, 170);
            this.lbforce.Name = "lbforce";
            this.lbforce.Size = new System.Drawing.Size(0, 13);
            this.lbforce.TabIndex = 16;
            // 
            // txtpv
            // 
            this.txtpv.Location = new System.Drawing.Point(55, 12);
            this.txtpv.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtpv.Name = "txtpv";
            this.txtpv.Size = new System.Drawing.Size(39, 20);
            this.txtpv.TabIndex = 0;
            // 
            // txtattspé
            // 
            this.txtattspé.Location = new System.Drawing.Point(55, 58);
            this.txtattspé.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtattspé.Name = "txtattspé";
            this.txtattspé.Size = new System.Drawing.Size(39, 20);
            this.txtattspé.TabIndex = 3;
            // 
            // txtatt
            // 
            this.txtatt.Location = new System.Drawing.Point(147, 14);
            this.txtatt.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtatt.Name = "txtatt";
            this.txtatt.Size = new System.Drawing.Size(39, 20);
            this.txtatt.TabIndex = 1;
            // 
            // txtdefspé
            // 
            this.txtdefspé.Location = new System.Drawing.Point(147, 58);
            this.txtdefspé.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtdefspé.Name = "txtdefspé";
            this.txtdefspé.Size = new System.Drawing.Size(39, 20);
            this.txtdefspé.TabIndex = 4;
            // 
            // txtdef
            // 
            this.txtdef.Location = new System.Drawing.Point(229, 14);
            this.txtdef.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtdef.Name = "txtdef";
            this.txtdef.Size = new System.Drawing.Size(39, 20);
            this.txtdef.TabIndex = 2;
            // 
            // txtvit
            // 
            this.txtvit.Location = new System.Drawing.Point(229, 58);
            this.txtvit.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txtvit.Name = "txtvit";
            this.txtvit.Size = new System.Drawing.Size(39, 20);
            this.txtvit.TabIndex = 5;
            // 
            // formPCfinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 204);
            this.Controls.Add(this.txtvit);
            this.Controls.Add(this.txtdef);
            this.Controls.Add(this.txtdefspé);
            this.Controls.Add(this.txtatt);
            this.Controls.Add(this.txtattspé);
            this.Controls.Add(this.txtpv);
            this.Controls.Add(this.lbforce);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPCfinder";
            this.Text = "PC Finder";
            ((System.ComponentModel.ISupportInitialize)(this.txtpv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtattspé)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdefspé)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbforce;
        private System.Windows.Forms.NumericUpDown txtpv;
        private System.Windows.Forms.NumericUpDown txtattspé;
        private System.Windows.Forms.NumericUpDown txtatt;
        private System.Windows.Forms.NumericUpDown txtdefspé;
        private System.Windows.Forms.NumericUpDown txtdef;
        private System.Windows.Forms.NumericUpDown txtvit;
    }
}

