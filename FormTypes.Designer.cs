namespace URA_Pokemon
{
    partial class FormTypes
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
            this.ComboType1 = new System.Windows.Forms.ComboBox();
            this.ComboType2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalculer = new System.Windows.Forms.Button();
            this.lbEfficace = new System.Windows.Forms.Label();
            this.lbPeuEfficace = new System.Windows.Forms.Label();
            this.lbT2 = new System.Windows.Forms.Label();
            this.lbT1 = new System.Windows.Forms.Label();
            this.lbRésistance = new System.Windows.Forms.Label();
            this.lbFaiblesse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboType1
            // 
            this.ComboType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboType1.FormattingEnabled = true;
            this.ComboType1.Location = new System.Drawing.Point(112, 30);
            this.ComboType1.MaxDropDownItems = 15;
            this.ComboType1.Name = "ComboType1";
            this.ComboType1.Size = new System.Drawing.Size(103, 21);
            this.ComboType1.TabIndex = 0;
            // 
            // ComboType2
            // 
            this.ComboType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboType2.FormattingEnabled = true;
            this.ComboType2.Location = new System.Drawing.Point(239, 30);
            this.ComboType2.MaxDropDownItems = 15;
            this.ComboType2.Name = "ComboType2";
            this.ComboType2.Size = new System.Drawing.Size(103, 21);
            this.ComboType2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type 2";
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(12, 14);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(82, 37);
            this.btCalculer.TabIndex = 4;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // lbEfficace
            // 
            this.lbEfficace.AutoSize = true;
            this.lbEfficace.Location = new System.Drawing.Point(12, 77);
            this.lbEfficace.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbEfficace.Name = "lbEfficace";
            this.lbEfficace.Size = new System.Drawing.Size(82, 13);
            this.lbEfficace.TabIndex = 5;
            this.lbEfficace.Text = "Efficace contre:";
            // 
            // lbPeuEfficace
            // 
            this.lbPeuEfficace.AutoSize = true;
            this.lbPeuEfficace.Location = new System.Drawing.Point(12, 130);
            this.lbPeuEfficace.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbPeuEfficace.Name = "lbPeuEfficace";
            this.lbPeuEfficace.Size = new System.Drawing.Size(103, 13);
            this.lbPeuEfficace.TabIndex = 6;
            this.lbPeuEfficace.Text = "Peu efficace contre:";
            // 
            // lbT2
            // 
            this.lbT2.AutoSize = true;
            this.lbT2.Location = new System.Drawing.Point(12, 236);
            this.lbT2.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbT2.Name = "lbT2";
            this.lbT2.Size = new System.Drawing.Size(222, 13);
            this.lbT2.TabIndex = 7;
            this.lbT2.Text = "Peu efficace contre (tableau dissocié TYPE2)";
            // 
            // lbT1
            // 
            this.lbT1.AutoSize = true;
            this.lbT1.Location = new System.Drawing.Point(12, 182);
            this.lbT1.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbT1.Name = "lbT1";
            this.lbT1.Size = new System.Drawing.Size(222, 13);
            this.lbT1.TabIndex = 8;
            this.lbT1.Text = "Peu efficace contre (tableau dissocié TYPE1)";
            // 
            // lbRésistance
            // 
            this.lbRésistance.AutoSize = true;
            this.lbRésistance.Location = new System.Drawing.Point(12, 289);
            this.lbRésistance.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbRésistance.Name = "lbRésistance";
            this.lbRésistance.Size = new System.Drawing.Size(107, 13);
            this.lbRésistance.TabIndex = 9;
            this.lbRésistance.Text = "Résistance, immunité";
            // 
            // lbFaiblesse
            // 
            this.lbFaiblesse.AutoSize = true;
            this.lbFaiblesse.Location = new System.Drawing.Point(12, 340);
            this.lbFaiblesse.MaximumSize = new System.Drawing.Size(347, 0);
            this.lbFaiblesse.Name = "lbFaiblesse";
            this.lbFaiblesse.Size = new System.Drawing.Size(54, 13);
            this.lbFaiblesse.TabIndex = 10;
            this.lbFaiblesse.Text = "Faiblesse:";
            // 
            // FormTypes
            // 
            this.AcceptButton = this.btCalculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 388);
            this.Controls.Add(this.lbFaiblesse);
            this.Controls.Add(this.lbRésistance);
            this.Controls.Add(this.lbT1);
            this.Controls.Add(this.lbT2);
            this.Controls.Add(this.lbPeuEfficace);
            this.Controls.Add(this.ComboType2);
            this.Controls.Add(this.ComboType1);
            this.Controls.Add(this.lbEfficace);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTypes";
            this.Text = "Types";
            this.Load += new System.EventHandler(this.FormTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboType1;
        private System.Windows.Forms.ComboBox ComboType2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label lbEfficace;
        private System.Windows.Forms.Label lbPeuEfficace;
        private System.Windows.Forms.Label lbT2;
        private System.Windows.Forms.Label lbT1;
        private System.Windows.Forms.Label lbRésistance;
        private System.Windows.Forms.Label lbFaiblesse;
    }
}