namespace URA_Pokemon
{
    partial class FormCapacites
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
            this.ComboCapacite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbForce = new System.Windows.Forms.Label();
            this.lbPrecision = new System.Windows.Forms.Label();
            this.lbPP = new System.Windows.Forms.Label();
            this.lbCTCS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNature = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboCapacite
            // 
            this.ComboCapacite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboCapacite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboCapacite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCapacite.FormattingEnabled = true;
            this.ComboCapacite.Location = new System.Drawing.Point(70, 12);
            this.ComboCapacite.MaxDropDownItems = 30;
            this.ComboCapacite.Name = "ComboCapacite";
            this.ComboCapacite.Size = new System.Drawing.Size(128, 21);
            this.ComboCapacite.Sorted = true;
            this.ComboCapacite.TabIndex = 0;
            this.ComboCapacite.SelectedIndexChanged += new System.EventHandler(this.ComboCapacite_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(6, 19);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(228, 143);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(12, 45);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Type:";
            // 
            // lbForce
            // 
            this.lbForce.AutoSize = true;
            this.lbForce.Location = new System.Drawing.Point(12, 70);
            this.lbForce.Name = "lbForce";
            this.lbForce.Size = new System.Drawing.Size(37, 13);
            this.lbForce.TabIndex = 2;
            this.lbForce.Text = "Force:";
            // 
            // lbPrecision
            // 
            this.lbPrecision.AutoSize = true;
            this.lbPrecision.Location = new System.Drawing.Point(84, 70);
            this.lbPrecision.Name = "lbPrecision";
            this.lbPrecision.Size = new System.Drawing.Size(53, 13);
            this.lbPrecision.TabIndex = 3;
            this.lbPrecision.Text = "Précision:";
            // 
            // lbPP
            // 
            this.lbPP.AutoSize = true;
            this.lbPP.Location = new System.Drawing.Point(12, 100);
            this.lbPP.Name = "lbPP";
            this.lbPP.Size = new System.Drawing.Size(24, 13);
            this.lbPP.TabIndex = 4;
            this.lbPP.Text = "PP:";
            // 
            // lbCTCS
            // 
            this.lbCTCS.AutoSize = true;
            this.lbCTCS.Location = new System.Drawing.Point(84, 100);
            this.lbCTCS.Name = "lbCTCS";
            this.lbCTCS.Size = new System.Drawing.Size(0, 13);
            this.lbCTCS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capacité";
            // 
            // lbNature
            // 
            this.lbNature.AutoSize = true;
            this.lbNature.Location = new System.Drawing.Point(128, 45);
            this.lbNature.Name = "lbNature";
            this.lbNature.Size = new System.Drawing.Size(42, 13);
            this.lbNature.TabIndex = 7;
            this.lbNature.Text = "Nature:";
            // 
            // FormCapacites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 301);
            this.Controls.Add(this.lbNature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCTCS);
            this.Controls.Add(this.lbPP);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbForce);
            this.Controls.Add(this.lbPrecision);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboCapacite);
            this.MaximizeBox = false;
            this.Name = "FormCapacites";
            this.Text = "Capacités";
            this.Load += new System.EventHandler(this.FormCapacites_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCapacite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbForce;
        private System.Windows.Forms.Label lbPrecision;
        private System.Windows.Forms.Label lbPP;
        private System.Windows.Forms.Label lbCTCS;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNature;
    }
}