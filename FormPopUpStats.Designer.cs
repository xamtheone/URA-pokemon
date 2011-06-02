namespace URA_Pokemon
{
    partial class FormPopUpStats
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
            this.chkPV = new System.Windows.Forms.CheckBox();
            this.chkAttaque = new System.Windows.Forms.CheckBox();
            this.chkDS = new System.Windows.Forms.CheckBox();
            this.chkAS = new System.Windows.Forms.CheckBox();
            this.chkVitesse = new System.Windows.Forms.CheckBox();
            this.chkDéfense = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkPV
            // 
            this.chkPV.AutoSize = true;
            this.chkPV.Location = new System.Drawing.Point(12, 12);
            this.chkPV.Name = "chkPV";
            this.chkPV.Size = new System.Drawing.Size(40, 17);
            this.chkPV.TabIndex = 0;
            this.chkPV.Text = "PV";
            this.chkPV.UseVisualStyleBackColor = true;
            // 
            // chkAttaque
            // 
            this.chkAttaque.AutoSize = true;
            this.chkAttaque.Location = new System.Drawing.Point(12, 35);
            this.chkAttaque.Name = "chkAttaque";
            this.chkAttaque.Size = new System.Drawing.Size(63, 17);
            this.chkAttaque.TabIndex = 1;
            this.chkAttaque.Text = "Attaque";
            this.chkAttaque.UseVisualStyleBackColor = true;
            // 
            // chkDS
            // 
            this.chkDS.AutoSize = true;
            this.chkDS.Location = new System.Drawing.Point(12, 104);
            this.chkDS.Name = "chkDS";
            this.chkDS.Size = new System.Drawing.Size(41, 17);
            this.chkDS.TabIndex = 2;
            this.chkDS.Text = "DS";
            this.chkDS.UseVisualStyleBackColor = true;
            // 
            // chkAS
            // 
            this.chkAS.AutoSize = true;
            this.chkAS.Location = new System.Drawing.Point(12, 81);
            this.chkAS.Name = "chkAS";
            this.chkAS.Size = new System.Drawing.Size(40, 17);
            this.chkAS.TabIndex = 3;
            this.chkAS.Text = "AS";
            this.chkAS.UseVisualStyleBackColor = true;
            // 
            // chkVitesse
            // 
            this.chkVitesse.AutoSize = true;
            this.chkVitesse.Location = new System.Drawing.Point(12, 127);
            this.chkVitesse.Name = "chkVitesse";
            this.chkVitesse.Size = new System.Drawing.Size(60, 17);
            this.chkVitesse.TabIndex = 4;
            this.chkVitesse.Text = "Vitesse";
            this.chkVitesse.UseVisualStyleBackColor = true;
            // 
            // chkDéfense
            // 
            this.chkDéfense.AutoSize = true;
            this.chkDéfense.Location = new System.Drawing.Point(12, 58);
            this.chkDéfense.Name = "chkDéfense";
            this.chkDéfense.Size = new System.Drawing.Size(66, 17);
            this.chkDéfense.TabIndex = 5;
            this.chkDéfense.Text = "Défense";
            this.chkDéfense.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPopUpStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(82, 211);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkDéfense);
            this.Controls.Add(this.chkVitesse);
            this.Controls.Add(this.chkAS);
            this.Controls.Add(this.chkDS);
            this.Controls.Add(this.chkAttaque);
            this.Controls.Add(this.chkPV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPopUpStats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPV;
        private System.Windows.Forms.CheckBox chkAttaque;
        private System.Windows.Forms.CheckBox chkDS;
        private System.Windows.Forms.CheckBox chkAS;
        private System.Windows.Forms.CheckBox chkVitesse;
        private System.Windows.Forms.CheckBox chkDéfense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}