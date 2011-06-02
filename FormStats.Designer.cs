namespace URA_Pokemon
{
    partial class FormStats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboPokémon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtAS = new System.Windows.Forms.TextBox();
            this.txtDéfense = new System.Windows.Forms.TextBox();
            this.txtAttaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPEmax = new System.Windows.Forms.CheckBox();
            this.NumUDPEgeneral = new System.Windows.Forms.NumericUpDown();
            this.ComboNature = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCalculer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAttaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDéfense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClVitesse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumUDDéfense = new System.Windows.Forms.NumericUpDown();
            this.NumUDAttaque = new System.Windows.Forms.NumericUpDown();
            this.NumUDPV = new System.Windows.Forms.NumericUpDown();
            this.NumUDVitesse = new System.Windows.Forms.NumericUpDown();
            this.NumUDDS = new System.Windows.Forms.NumericUpDown();
            this.NumUDAS = new System.Windows.Forms.NumericUpDown();
            this.chkParStat = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPEgeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDéfense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAttaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAS)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pokémon";
            // 
            // ComboPokémon
            // 
            this.ComboPokémon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboPokémon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPokémon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPokémon.FormattingEnabled = true;
            this.ComboPokémon.Location = new System.Drawing.Point(15, 25);
            this.ComboPokémon.MaxDropDownItems = 30;
            this.ComboPokémon.Name = "ComboPokémon";
            this.ComboPokémon.Size = new System.Drawing.Size(135, 21);
            this.ComboPokémon.TabIndex = 19;
            this.ComboPokémon.SelectedIndexChanged += new System.EventHandler(this.ComboPokémon_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 107);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(9, 32);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(39, 20);
            this.txtPV.TabIndex = 0;
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
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(121, 76);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(41, 20);
            this.txtVitesse.TabIndex = 5;
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(62, 76);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(39, 20);
            this.txtDS.TabIndex = 4;
            // 
            // txtAS
            // 
            this.txtAS.Location = new System.Drawing.Point(9, 76);
            this.txtAS.Name = "txtAS";
            this.txtAS.Size = new System.Drawing.Size(41, 20);
            this.txtAS.TabIndex = 3;
            // 
            // txtDéfense
            // 
            this.txtDéfense.Location = new System.Drawing.Point(121, 32);
            this.txtDéfense.Name = "txtDéfense";
            this.txtDéfense.Size = new System.Drawing.Size(41, 20);
            this.txtDéfense.TabIndex = 2;
            // 
            // txtAttaque
            // 
            this.txtAttaque.Location = new System.Drawing.Point(62, 32);
            this.txtAttaque.Name = "txtAttaque";
            this.txtAttaque.Size = new System.Drawing.Size(39, 20);
            this.txtAttaque.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Attaque";
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
            // chkPEmax
            // 
            this.chkPEmax.AutoSize = true;
            this.chkPEmax.Location = new System.Drawing.Point(12, 20);
            this.chkPEmax.Name = "chkPEmax";
            this.chkPEmax.Size = new System.Drawing.Size(47, 17);
            this.chkPEmax.TabIndex = 22;
            this.chkPEmax.Text = "maxi";
            this.chkPEmax.UseVisualStyleBackColor = true;
            this.chkPEmax.CheckedChanged += new System.EventHandler(this.chkPEmax_CheckedChanged);
            // 
            // NumUDPEgeneral
            // 
            this.NumUDPEgeneral.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumUDPEgeneral.Location = new System.Drawing.Point(131, 17);
            this.NumUDPEgeneral.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDPEgeneral.Name = "NumUDPEgeneral";
            this.NumUDPEgeneral.Size = new System.Drawing.Size(42, 20);
            this.NumUDPEgeneral.TabIndex = 23;
            // 
            // ComboNature
            // 
            this.ComboNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNature.FormattingEnabled = true;
            this.ComboNature.Location = new System.Drawing.Point(57, 168);
            this.ComboNature.Name = "ComboNature";
            this.ComboNature.Size = new System.Drawing.Size(121, 21);
            this.ComboNature.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nature";
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(12, 569);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(75, 44);
            this.btCalculer.TabIndex = 26;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClDV,
            this.ClPV,
            this.ClAttaque,
            this.ClDéfense,
            this.ClAS,
            this.ClDS,
            this.ClVitesse});
            this.dataGridView1.Location = new System.Drawing.Point(203, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(195, 601);
            this.dataGridView1.TabIndex = 27;
            // 
            // ClDV
            // 
            this.ClDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClDV.HeaderText = "DV";
            this.ClDV.Name = "ClDV";
            this.ClDV.ReadOnly = true;
            this.ClDV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClDV.Width = 28;
            // 
            // ClPV
            // 
            this.ClPV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClPV.HeaderText = "PV";
            this.ClPV.Name = "ClPV";
            this.ClPV.ReadOnly = true;
            this.ClPV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClPV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClPV.Width = 27;
            // 
            // ClAttaque
            // 
            this.ClAttaque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClAttaque.HeaderText = "A";
            this.ClAttaque.Name = "ClAttaque";
            this.ClAttaque.ReadOnly = true;
            this.ClAttaque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClAttaque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClAttaque.Width = 20;
            // 
            // ClDéfense
            // 
            this.ClDéfense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClDéfense.HeaderText = "D";
            this.ClDéfense.Name = "ClDéfense";
            this.ClDéfense.ReadOnly = true;
            this.ClDéfense.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClDéfense.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClDéfense.Width = 21;
            // 
            // ClAS
            // 
            this.ClAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClAS.HeaderText = "AS";
            this.ClAS.Name = "ClAS";
            this.ClAS.ReadOnly = true;
            this.ClAS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClAS.Width = 27;
            // 
            // ClDS
            // 
            this.ClDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClDS.HeaderText = "DS";
            this.ClDS.Name = "ClDS";
            this.ClDS.ReadOnly = true;
            this.ClDS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClDS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClDS.Width = 28;
            // 
            // ClVitesse
            // 
            this.ClVitesse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClVitesse.HeaderText = "V";
            this.ClVitesse.Name = "ClVitesse";
            this.ClVitesse.ReadOnly = true;
            this.ClVitesse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClVitesse.Width = 20;
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(156, 25);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(35, 20);
            this.txtNiveau.TabIndex = 28;
            this.txtNiveau.Leave += new System.EventHandler(this.txtNiveau_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Niveau";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumUDDéfense);
            this.groupBox2.Controls.Add(this.NumUDAttaque);
            this.groupBox2.Controls.Add(this.NumUDPV);
            this.groupBox2.Controls.Add(this.NumUDVitesse);
            this.groupBox2.Controls.Add(this.NumUDDS);
            this.groupBox2.Controls.Add(this.NumUDAS);
            this.groupBox2.Controls.Add(this.chkParStat);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chkPEmax);
            this.groupBox2.Controls.Add(this.NumUDPEgeneral);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 167);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Points d\'efforts";
            // 
            // NumUDDéfense
            // 
            this.NumUDDéfense.Enabled = false;
            this.NumUDDéfense.Location = new System.Drawing.Point(126, 95);
            this.NumUDDéfense.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDDéfense.Name = "NumUDDéfense";
            this.NumUDDéfense.Size = new System.Drawing.Size(40, 20);
            this.NumUDDéfense.TabIndex = 26;
            // 
            // NumUDAttaque
            // 
            this.NumUDAttaque.Enabled = false;
            this.NumUDAttaque.Location = new System.Drawing.Point(66, 95);
            this.NumUDAttaque.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDAttaque.Name = "NumUDAttaque";
            this.NumUDAttaque.Size = new System.Drawing.Size(40, 20);
            this.NumUDAttaque.TabIndex = 25;
            // 
            // NumUDPV
            // 
            this.NumUDPV.Enabled = false;
            this.NumUDPV.Location = new System.Drawing.Point(6, 95);
            this.NumUDPV.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDPV.Name = "NumUDPV";
            this.NumUDPV.Size = new System.Drawing.Size(40, 20);
            this.NumUDPV.TabIndex = 27;
            // 
            // NumUDVitesse
            // 
            this.NumUDVitesse.Enabled = false;
            this.NumUDVitesse.Location = new System.Drawing.Point(124, 141);
            this.NumUDVitesse.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDVitesse.Name = "NumUDVitesse";
            this.NumUDVitesse.Size = new System.Drawing.Size(41, 20);
            this.NumUDVitesse.TabIndex = 29;
            // 
            // NumUDDS
            // 
            this.NumUDDS.Enabled = false;
            this.NumUDDS.Location = new System.Drawing.Point(66, 141);
            this.NumUDDS.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDDS.Name = "NumUDDS";
            this.NumUDDS.Size = new System.Drawing.Size(41, 20);
            this.NumUDDS.TabIndex = 28;
            // 
            // NumUDAS
            // 
            this.NumUDAS.Enabled = false;
            this.NumUDAS.Location = new System.Drawing.Point(6, 141);
            this.NumUDAS.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.NumUDAS.Name = "NumUDAS";
            this.NumUDAS.Size = new System.Drawing.Size(41, 20);
            this.NumUDAS.TabIndex = 30;
            // 
            // chkParStat
            // 
            this.chkParStat.AutoSize = true;
            this.chkParStat.Location = new System.Drawing.Point(12, 50);
            this.chkParStat.Name = "chkParStat";
            this.chkParStat.Size = new System.Drawing.Size(62, 17);
            this.chkParStat.TabIndex = 37;
            this.chkParStat.Text = "Par stat";
            this.chkParStat.UseVisualStyleBackColor = true;
            this.chkParStat.CheckedChanged += new System.EventHandler(this.chkParStat_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "PV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(118, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Vitesse";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(59, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "DS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(59, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Attaque";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "AS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(118, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Défense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "global";
            // 
            // FormStats
            // 
            this.AcceptButton = this.btCalculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ComboPokémon);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboNature);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStats";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPEgeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDéfense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAttaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboPokémon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtAS;
        private System.Windows.Forms.TextBox txtDéfense;
        private System.Windows.Forms.TextBox txtAttaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPEmax;
        private System.Windows.Forms.NumericUpDown NumUDPEgeneral;
        private System.Windows.Forms.ComboBox ComboNature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAttaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDéfense;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClVitesse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumUDAS;
        private System.Windows.Forms.NumericUpDown NumUDVitesse;
        private System.Windows.Forms.NumericUpDown NumUDDS;
        private System.Windows.Forms.NumericUpDown NumUDPV;
        private System.Windows.Forms.NumericUpDown NumUDDéfense;
        private System.Windows.Forms.NumericUpDown NumUDAttaque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkParStat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}