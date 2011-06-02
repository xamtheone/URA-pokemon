namespace URA_Pokemon
{
    partial class FormDescription
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.ComboPokémon = new System.Windows.Forms.ComboBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbShiney = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbOeuf = new System.Windows.Forms.Label();
            this.lbPE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbAttaque = new System.Windows.Forms.Label();
            this.lbDefense = new System.Windows.Forms.Label();
            this.lbAS = new System.Windows.Forms.Label();
            this.lbDS = new System.Windows.Forms.Label();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lbCapacitésSpé = new System.Windows.Forms.Label();
            this.ComboLevel = new System.Windows.Forms.ComboBox();
            this.ComboCTCS = new System.Windows.Forms.ComboBox();
            this.ComboOeuf = new System.Windows.Forms.ComboBox();
            this.ComboNum = new System.Windows.Forms.ComboBox();
            this.lbEvo_de = new System.Windows.Forms.Label();
            this.lbEvo_en = new System.Windows.Forms.Label();
            this.OeufList = new System.Windows.Forms.DataGridView();
            this.Clpokemon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClOeuf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClOeuf2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCTCS = new System.Windows.Forms.DataGridView();
            this.ColCTCSNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCTCSNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCTCSNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNiveau = new System.Windows.Forms.DataGridView();
            this.ColNiveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAppNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAppNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOeuf = new System.Windows.Forms.DataGridView();
            this.ColOeufNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOeufNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvo = new System.Windows.Forms.DataGridView();
            this.ColEvolueEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OeufList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(11, 37);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(120, 19);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "NOM: (cliquez)";
            this.lbNom.Click += new System.EventHandler(this.lbNom_Click);
            // 
            // ComboPokémon
            // 
            this.ComboPokémon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboPokémon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPokémon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPokémon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboPokémon.FormattingEnabled = true;
            this.ComboPokémon.Location = new System.Drawing.Point(58, 37);
            this.ComboPokémon.MaxDropDownItems = 30;
            this.ComboPokémon.Name = "ComboPokémon";
            this.ComboPokémon.Size = new System.Drawing.Size(121, 21);
            this.ComboPokémon.TabIndex = 2;
            this.ComboPokémon.Visible = false;
            this.ComboPokémon.SelectedIndexChanged += new System.EventHandler(this.ComboPokémon_SelectedIndexChanged);
            this.ComboPokémon.Leave += new System.EventHandler(this.ComboPokémon_Leave);
            // 
            // rbNormal
            // 
            this.rbNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbNormal.Location = new System.Drawing.Point(6, 112);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(64, 18);
            this.rbNormal.TabIndex = 3;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbShiney
            // 
            this.rbShiney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbShiney.AutoSize = true;
            this.rbShiney.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbShiney.Location = new System.Drawing.Point(6, 135);
            this.rbShiney.Name = "rbShiney";
            this.rbShiney.Size = new System.Drawing.Size(63, 18);
            this.rbShiney.TabIndex = 4;
            this.rbShiney.Text = "Shiney";
            this.rbShiney.UseVisualStyleBackColor = true;
            this.rbShiney.CheckedChanged += new System.EventHandler(this.rbShiney_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbShiney);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apparence";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.White;
            this.lbType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(131, 58);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 16);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "TYPE: ";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.Location = new System.Drawing.Point(12, 12);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(96, 18);
            this.lbNum.TabIndex = 7;
            this.lbNum.Text = "N° (cliquez)";
            this.lbNum.Click += new System.EventHandler(this.lbNum_Click);
            // 
            // lbOeuf
            // 
            this.lbOeuf.AutoSize = true;
            this.lbOeuf.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOeuf.Location = new System.Drawing.Point(130, 148);
            this.lbOeuf.Name = "lbOeuf";
            this.lbOeuf.Size = new System.Drawing.Size(54, 16);
            this.lbOeuf.TabIndex = 8;
            this.lbOeuf.Text = "OEUF: ";
            // 
            // lbPE
            // 
            this.lbPE.AutoSize = true;
            this.lbPE.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPE.Location = new System.Drawing.Point(130, 202);
            this.lbPE.Name = "lbPE";
            this.lbPE.Size = new System.Drawing.Size(112, 16);
            this.lbPE.TabIndex = 9;
            this.lbPE.Text = "Points d\'effort: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apprentissage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "CT - CS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Oeuf";
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPV.Location = new System.Drawing.Point(11, 238);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(35, 18);
            this.lbPV.TabIndex = 16;
            this.lbPV.Text = "PV: ";
            // 
            // lbAttaque
            // 
            this.lbAttaque.AutoSize = true;
            this.lbAttaque.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttaque.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbAttaque.Location = new System.Drawing.Point(77, 238);
            this.lbAttaque.Name = "lbAttaque";
            this.lbAttaque.Size = new System.Drawing.Size(25, 18);
            this.lbAttaque.TabIndex = 17;
            this.lbAttaque.Text = "A: ";
            // 
            // lbDefense
            // 
            this.lbDefense.AutoSize = true;
            this.lbDefense.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefense.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDefense.Location = new System.Drawing.Point(136, 238);
            this.lbDefense.Name = "lbDefense";
            this.lbDefense.Size = new System.Drawing.Size(27, 18);
            this.lbDefense.TabIndex = 18;
            this.lbDefense.Text = "D: ";
            // 
            // lbAS
            // 
            this.lbAS.AutoSize = true;
            this.lbAS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbAS.Location = new System.Drawing.Point(11, 265);
            this.lbAS.Name = "lbAS";
            this.lbAS.Size = new System.Drawing.Size(35, 18);
            this.lbAS.TabIndex = 19;
            this.lbAS.Text = "AS: ";
            // 
            // lbDS
            // 
            this.lbDS.AutoSize = true;
            this.lbDS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDS.Location = new System.Drawing.Point(76, 265);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(37, 18);
            this.lbDS.TabIndex = 20;
            this.lbDS.Text = "DS: ";
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVitesse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbVitesse.Location = new System.Drawing.Point(136, 265);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(21, 18);
            this.lbVitesse.TabIndex = 21;
            this.lbVitesse.Text = "V:";
            // 
            // lbCapacitésSpé
            // 
            this.lbCapacitésSpé.AutoSize = true;
            this.lbCapacitésSpé.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapacitésSpé.Location = new System.Drawing.Point(130, 96);
            this.lbCapacitésSpé.Name = "lbCapacitésSpé";
            this.lbCapacitésSpé.Size = new System.Drawing.Size(112, 16);
            this.lbCapacitésSpé.TabIndex = 22;
            this.lbCapacitésSpé.Text = "Capacités spé: ";
            // 
            // ComboLevel
            // 
            this.ComboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLevel.FormattingEnabled = true;
            this.ComboLevel.Location = new System.Drawing.Point(12, 315);
            this.ComboLevel.MaxDropDownItems = 30;
            this.ComboLevel.Name = "ComboLevel";
            this.ComboLevel.Size = new System.Drawing.Size(158, 21);
            this.ComboLevel.TabIndex = 23;
            // 
            // ComboCTCS
            // 
            this.ComboCTCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCTCS.FormattingEnabled = true;
            this.ComboCTCS.Location = new System.Drawing.Point(12, 342);
            this.ComboCTCS.MaxDropDownItems = 30;
            this.ComboCTCS.Name = "ComboCTCS";
            this.ComboCTCS.Size = new System.Drawing.Size(158, 21);
            this.ComboCTCS.TabIndex = 24;
            // 
            // ComboOeuf
            // 
            this.ComboOeuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOeuf.FormattingEnabled = true;
            this.ComboOeuf.Location = new System.Drawing.Point(12, 369);
            this.ComboOeuf.MaxDropDownItems = 30;
            this.ComboOeuf.Name = "ComboOeuf";
            this.ComboOeuf.Size = new System.Drawing.Size(158, 21);
            this.ComboOeuf.Sorted = true;
            this.ComboOeuf.TabIndex = 25;
            // 
            // ComboNum
            // 
            this.ComboNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNum.FormattingEnabled = true;
            this.ComboNum.Location = new System.Drawing.Point(36, 13);
            this.ComboNum.MaxDropDownItems = 30;
            this.ComboNum.Name = "ComboNum";
            this.ComboNum.Size = new System.Drawing.Size(121, 21);
            this.ComboNum.Sorted = true;
            this.ComboNum.TabIndex = 26;
            this.ComboNum.Visible = false;
            this.ComboNum.SelectedIndexChanged += new System.EventHandler(this.ComboNum_SelectedIndexChanged);
            this.ComboNum.Leave += new System.EventHandler(this.ComboNum_Leave);
            // 
            // lbEvo_de
            // 
            this.lbEvo_de.AutoSize = true;
            this.lbEvo_de.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvo_de.Location = new System.Drawing.Point(278, 9);
            this.lbEvo_de.Name = "lbEvo_de";
            this.lbEvo_de.Size = new System.Drawing.Size(76, 18);
            this.lbEvo_de.TabIndex = 27;
            this.lbEvo_de.Text = "Evolution";
            // 
            // lbEvo_en
            // 
            this.lbEvo_en.AutoSize = true;
            this.lbEvo_en.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvo_en.Location = new System.Drawing.Point(278, 56);
            this.lbEvo_en.Name = "lbEvo_en";
            this.lbEvo_en.Size = new System.Drawing.Size(87, 18);
            this.lbEvo_en.TabIndex = 28;
            this.lbEvo_en.Text = "Evolue en:";
            // 
            // OeufList
            // 
            this.OeufList.AllowUserToAddRows = false;
            this.OeufList.AllowUserToDeleteRows = false;
            this.OeufList.AllowUserToResizeRows = false;
            this.OeufList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OeufList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OeufList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clpokemon,
            this.ClOeuf1,
            this.ClOeuf2});
            this.OeufList.Location = new System.Drawing.Point(516, 30);
            this.OeufList.Name = "OeufList";
            this.OeufList.ReadOnly = true;
            this.OeufList.RowHeadersVisible = false;
            this.OeufList.Size = new System.Drawing.Size(244, 242);
            this.OeufList.TabIndex = 29;
            this.OeufList.DoubleClick += new System.EventHandler(this.OeufList_DoubleClick);
            // 
            // Clpokemon
            // 
            this.Clpokemon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clpokemon.Frozen = true;
            this.Clpokemon.HeaderText = "Pokémon";
            this.Clpokemon.Name = "Clpokemon";
            this.Clpokemon.ReadOnly = true;
            this.Clpokemon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Clpokemon.Width = 77;
            // 
            // ClOeuf1
            // 
            this.ClOeuf1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClOeuf1.Frozen = true;
            this.ClOeuf1.HeaderText = "Oeuf 1";
            this.ClOeuf1.Name = "ClOeuf1";
            this.ClOeuf1.ReadOnly = true;
            this.ClOeuf1.Width = 64;
            // 
            // ClOeuf2
            // 
            this.ClOeuf2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClOeuf2.Frozen = true;
            this.ClOeuf2.HeaderText = "Oeuf 2";
            this.ClOeuf2.Name = "ClOeuf2";
            this.ClOeuf2.ReadOnly = true;
            this.ClOeuf2.Width = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pokémons compatible";
            // 
            // dgvCTCS
            // 
            this.dgvCTCS.AllowUserToAddRows = false;
            this.dgvCTCS.AllowUserToDeleteRows = false;
            this.dgvCTCS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCTCS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCTCSNum,
            this.ColCTCSNom,
            this.ColCTCSNature});
            this.dgvCTCS.Location = new System.Drawing.Point(252, 305);
            this.dgvCTCS.Name = "dgvCTCS";
            this.dgvCTCS.ReadOnly = true;
            this.dgvCTCS.RowHeadersVisible = false;
            this.dgvCTCS.Size = new System.Drawing.Size(253, 242);
            this.dgvCTCS.TabIndex = 31;
            this.dgvCTCS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTCS_CellContentDoubleClick);
            // 
            // ColCTCSNum
            // 
            this.ColCTCSNum.Frozen = true;
            this.ColCTCSNum.HeaderText = "CT/CS";
            this.ColCTCSNum.Name = "ColCTCSNum";
            this.ColCTCSNum.ReadOnly = true;
            this.ColCTCSNum.Width = 45;
            // 
            // ColCTCSNom
            // 
            this.ColCTCSNom.Frozen = true;
            this.ColCTCSNom.HeaderText = "Nom";
            this.ColCTCSNom.Name = "ColCTCSNom";
            this.ColCTCSNom.ReadOnly = true;
            this.ColCTCSNom.Width = 110;
            // 
            // ColCTCSNature
            // 
            this.ColCTCSNature.Frozen = true;
            this.ColCTCSNature.HeaderText = "Nature";
            this.ColCTCSNature.Name = "ColCTCSNature";
            this.ColCTCSNature.ReadOnly = true;
            this.ColCTCSNature.Width = 60;
            // 
            // dgvNiveau
            // 
            this.dgvNiveau.AllowUserToAddRows = false;
            this.dgvNiveau.AllowUserToDeleteRows = false;
            this.dgvNiveau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNiveau.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNiveau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNiveau,
            this.ColAppNom,
            this.ColAppNature});
            this.dgvNiveau.Location = new System.Drawing.Point(12, 305);
            this.dgvNiveau.Name = "dgvNiveau";
            this.dgvNiveau.ReadOnly = true;
            this.dgvNiveau.RowHeadersVisible = false;
            this.dgvNiveau.Size = new System.Drawing.Size(228, 242);
            this.dgvNiveau.TabIndex = 32;
            this.dgvNiveau.DoubleClick += new System.EventHandler(this.dgvNiveau_DoubleClick);
            // 
            // ColNiveau
            // 
            this.ColNiveau.Frozen = true;
            this.ColNiveau.HeaderText = "Niv.";
            this.ColNiveau.Name = "ColNiveau";
            this.ColNiveau.ReadOnly = true;
            this.ColNiveau.Width = 30;
            // 
            // ColAppNom
            // 
            this.ColAppNom.Frozen = true;
            this.ColAppNom.HeaderText = "Nom";
            this.ColAppNom.Name = "ColAppNom";
            this.ColAppNom.ReadOnly = true;
            this.ColAppNom.Width = 110;
            // 
            // ColAppNature
            // 
            this.ColAppNature.Frozen = true;
            this.ColAppNature.HeaderText = "Nature";
            this.ColAppNature.Name = "ColAppNature";
            this.ColAppNature.ReadOnly = true;
            this.ColAppNature.Width = 60;
            // 
            // dgvOeuf
            // 
            this.dgvOeuf.AllowUserToAddRows = false;
            this.dgvOeuf.AllowUserToDeleteRows = false;
            this.dgvOeuf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOeuf.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOeuf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOeuf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOeufNom,
            this.ColOeufNature});
            this.dgvOeuf.Location = new System.Drawing.Point(518, 305);
            this.dgvOeuf.Name = "dgvOeuf";
            this.dgvOeuf.ReadOnly = true;
            this.dgvOeuf.RowHeadersVisible = false;
            this.dgvOeuf.Size = new System.Drawing.Size(203, 242);
            this.dgvOeuf.TabIndex = 33;
            this.dgvOeuf.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOeuf_CellContentDoubleClick);
            // 
            // ColOeufNom
            // 
            this.ColOeufNom.Frozen = true;
            this.ColOeufNom.HeaderText = "Nom";
            this.ColOeufNom.Name = "ColOeufNom";
            this.ColOeufNom.ReadOnly = true;
            this.ColOeufNom.Width = 110;
            // 
            // ColOeufNature
            // 
            this.ColOeufNature.Frozen = true;
            this.ColOeufNature.HeaderText = "Nature";
            this.ColOeufNature.Name = "ColOeufNature";
            this.ColOeufNature.ReadOnly = true;
            this.ColOeufNature.Width = 60;
            // 
            // dgvEvo
            // 
            this.dgvEvo.AllowUserToAddRows = false;
            this.dgvEvo.AllowUserToDeleteRows = false;
            this.dgvEvo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEvolueEn,
            this.ColPar});
            this.dgvEvo.Location = new System.Drawing.Point(281, 30);
            this.dgvEvo.Name = "dgvEvo";
            this.dgvEvo.ReadOnly = true;
            this.dgvEvo.RowHeadersVisible = false;
            this.dgvEvo.Size = new System.Drawing.Size(229, 242);
            this.dgvEvo.TabIndex = 34;
            this.dgvEvo.DoubleClick += new System.EventHandler(this.dgvEvo_DoubleClick);
            // 
            // ColEvolueEn
            // 
            this.ColEvolueEn.Frozen = true;
            this.ColEvolueEn.HeaderText = "Nom";
            this.ColEvolueEn.Name = "ColEvolueEn";
            this.ColEvolueEn.ReadOnly = true;
            this.ColEvolueEn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPar
            // 
            this.ColPar.Frozen = true;
            this.ColPar.HeaderText = "Par";
            this.ColPar.Name = "ColPar";
            this.ColPar.ReadOnly = true;
            this.ColPar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPar.Width = 105;
            // 
            // FormDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(772, 557);
            this.Controls.Add(this.dgvEvo);
            this.Controls.Add(this.dgvOeuf);
            this.Controls.Add(this.dgvNiveau);
            this.Controls.Add(this.dgvCTCS);
            this.Controls.Add(this.OeufList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEvo_en);
            this.Controls.Add(this.lbEvo_de);
            this.Controls.Add(this.ComboNum);
            this.Controls.Add(this.ComboOeuf);
            this.Controls.Add(this.ComboCTCS);
            this.Controls.Add(this.ComboLevel);
            this.Controls.Add(this.lbCapacitésSpé);
            this.Controls.Add(this.lbVitesse);
            this.Controls.Add(this.lbDS);
            this.Controls.Add(this.lbAS);
            this.Controls.Add(this.lbDefense);
            this.Controls.Add(this.lbAttaque);
            this.Controls.Add(this.lbPV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPE);
            this.Controls.Add(this.lbOeuf);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboPokémon);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbType);
            this.Name = "FormDescription";
            this.Text = "Description";
            this.Load += new System.EventHandler(this.FormDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OeufList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.ComboBox ComboPokémon;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbShiney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbOeuf;
        private System.Windows.Forms.Label lbPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.Label lbAttaque;
        private System.Windows.Forms.Label lbDefense;
        private System.Windows.Forms.Label lbAS;
        private System.Windows.Forms.Label lbDS;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lbCapacitésSpé;
        private System.Windows.Forms.ComboBox ComboLevel;
        private System.Windows.Forms.ComboBox ComboCTCS;
        private System.Windows.Forms.ComboBox ComboOeuf;
        private System.Windows.Forms.ComboBox ComboNum;
        private System.Windows.Forms.Label lbEvo_de;
        private System.Windows.Forms.Label lbEvo_en;
        private System.Windows.Forms.DataGridView OeufList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clpokemon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClOeuf1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClOeuf2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCTCS;
        private System.Windows.Forms.DataGridView dgvNiveau;
        private System.Windows.Forms.DataGridView dgvOeuf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCTCSNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCTCSNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCTCSNature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOeufNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOeufNature;
        private System.Windows.Forms.DataGridView dgvEvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNiveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAppNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAppNature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvolueEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPar;
    }
}