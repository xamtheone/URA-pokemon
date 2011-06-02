namespace URA_Pokemon
{
    partial class FormPopupMouvementSelection
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
            this.ComboTypeMove = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboCapacite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboTypeMove
            // 
            this.ComboTypeMove.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboTypeMove.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboTypeMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTypeMove.FormattingEnabled = true;
            this.ComboTypeMove.Items.AddRange(new object[] {
            "Oeuf",
            "CT"});
            this.ComboTypeMove.Location = new System.Drawing.Point(12, 25);
            this.ComboTypeMove.Name = "ComboTypeMove";
            this.ComboTypeMove.Size = new System.Drawing.Size(121, 21);
            this.ComboTypeMove.TabIndex = 0;
            this.ComboTypeMove.SelectedIndexChanged += new System.EventHandler(this.ComboTypeMove_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // ComboCapacite
            // 
            this.ComboCapacite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboCapacite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboCapacite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCapacite.FormattingEnabled = true;
            this.ComboCapacite.Location = new System.Drawing.Point(12, 65);
            this.ComboCapacite.MaxDropDownItems = 12;
            this.ComboCapacite.Name = "ComboCapacite";
            this.ComboCapacite.Size = new System.Drawing.Size(121, 21);
            this.ComboCapacite.Sorted = true;
            this.ComboCapacite.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacité";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 92);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(31, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(58, 92);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 5;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FormPopupMouvementSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 126);
            this.Controls.Add(this.ComboCapacite);
            this.Controls.Add(this.ComboTypeMove);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPopupMouvementSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capacité";
            this.Load += new System.EventHandler(this.FormPopupMouvementSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboTypeMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboCapacite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btAnnuler;
    }
}