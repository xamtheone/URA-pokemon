namespace URA_Pokemon
{
    partial class FormDebug
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
            this.btSerializer = new System.Windows.Forms.Button();
            this.btDéserializer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSerializer
            // 
            this.btSerializer.Location = new System.Drawing.Point(12, 12);
            this.btSerializer.Name = "btSerializer";
            this.btSerializer.Size = new System.Drawing.Size(75, 23);
            this.btSerializer.TabIndex = 0;
            this.btSerializer.Text = "Serializer";
            this.btSerializer.UseVisualStyleBackColor = true;
            this.btSerializer.Click += new System.EventHandler(this.btSerializer_Click);
            // 
            // btDéserializer
            // 
            this.btDéserializer.Location = new System.Drawing.Point(12, 41);
            this.btDéserializer.Name = "btDéserializer";
            this.btDéserializer.Size = new System.Drawing.Size(75, 23);
            this.btDéserializer.TabIndex = 1;
            this.btDéserializer.Text = "Déserializer";
            this.btDéserializer.UseVisualStyleBackColor = true;
            this.btDéserializer.Click += new System.EventHandler(this.btDéserializer_Click);
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btDéserializer);
            this.Controls.Add(this.btSerializer);
            this.Name = "FormDebug";
            this.Text = "FormDebug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSerializer;
        private System.Windows.Forms.Button btDéserializer;
    }
}