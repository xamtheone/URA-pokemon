namespace URA_Pokemon
{
    partial class FormPokéFiche
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
            this.ComboPokémon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chketoile = new System.Windows.Forms.CheckBox();
            this.chklosange = new System.Windows.Forms.CheckBox();
            this.chkCoeur = new System.Windows.Forms.CheckBox();
            this.chkTriangle = new System.Windows.Forms.CheckBox();
            this.chkRond = new System.Windows.Forms.CheckBox();
            this.chkCarré = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboC3 = new System.Windows.Forms.ComboBox();
            this.ComboC1 = new System.Windows.Forms.ComboBox();
            this.ComboC4 = new System.Windows.Forms.ComboBox();
            this.ComboC2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtAS = new System.Windows.Forms.TextBox();
            this.txtDéfense = new System.Windows.Forms.TextBox();
            this.txtAttaque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumUDVitesse = new System.Windows.Forms.NumericUpDown();
            this.NumUDDS = new System.Windows.Forms.NumericUpDown();
            this.NumUDAS = new System.Windows.Forms.NumericUpDown();
            this.NumUDDéfense = new System.Windows.Forms.NumericUpDown();
            this.NumUDAttaque = new System.Windows.Forms.NumericUpDown();
            this.NumUDPV = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbAssexué = new System.Windows.Forms.RadioButton();
            this.rbFemelle = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.ComboNature = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ComboCapacitéSpé = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbShiney = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbAS = new System.Windows.Forms.Label();
            this.lbDS = new System.Windows.Forms.Label();
            this.lbVitesse = new System.Windows.Forms.Label();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbAttaque = new System.Windows.Forms.Label();
            this.lbDéfense = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btCalculer = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btCharger = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NumUDNiveau = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDéfense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAttaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPV)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDNiveau)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboPokémon
            // 
            this.ComboPokémon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboPokémon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPokémon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPokémon.FormattingEnabled = true;
            this.ComboPokémon.Location = new System.Drawing.Point(12, 35);
            this.ComboPokémon.MaxDropDownItems = 30;
            this.ComboPokémon.Name = "ComboPokémon";
            this.ComboPokémon.Size = new System.Drawing.Size(121, 21);
            this.ComboPokémon.TabIndex = 0;
            this.ComboPokémon.SelectedIndexChanged += new System.EventHandler(this.ComboPokémon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Espèce";
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(148, 35);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(121, 20);
            this.txtPseudo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pseudo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chketoile);
            this.groupBox1.Controls.Add(this.chklosange);
            this.groupBox1.Controls.Add(this.chkCoeur);
            this.groupBox1.Controls.Add(this.chkTriangle);
            this.groupBox1.Controls.Add(this.chkRond);
            this.groupBox1.Controls.Add(this.chkCarré);
            this.groupBox1.Location = new System.Drawing.Point(215, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symbôles";
            // 
            // chketoile
            // 
            this.chketoile.AutoSize = true;
            this.chketoile.Location = new System.Drawing.Point(6, 111);
            this.chketoile.Name = "chketoile";
            this.chketoile.Size = new System.Drawing.Size(52, 17);
            this.chketoile.TabIndex = 5;
            this.chketoile.Text = "Etoile";
            this.chketoile.UseVisualStyleBackColor = true;
            // 
            // chklosange
            // 
            this.chklosange.AutoSize = true;
            this.chklosange.Location = new System.Drawing.Point(6, 134);
            this.chklosange.Name = "chklosange";
            this.chklosange.Size = new System.Drawing.Size(67, 17);
            this.chklosange.TabIndex = 4;
            this.chklosange.Text = "Losange";
            this.chklosange.UseVisualStyleBackColor = true;
            // 
            // chkCoeur
            // 
            this.chkCoeur.AutoSize = true;
            this.chkCoeur.Location = new System.Drawing.Point(6, 88);
            this.chkCoeur.Name = "chkCoeur";
            this.chkCoeur.Size = new System.Drawing.Size(54, 17);
            this.chkCoeur.TabIndex = 3;
            this.chkCoeur.Text = "Coeur";
            this.chkCoeur.UseVisualStyleBackColor = true;
            // 
            // chkTriangle
            // 
            this.chkTriangle.AutoSize = true;
            this.chkTriangle.Location = new System.Drawing.Point(6, 65);
            this.chkTriangle.Name = "chkTriangle";
            this.chkTriangle.Size = new System.Drawing.Size(64, 17);
            this.chkTriangle.TabIndex = 2;
            this.chkTriangle.Text = "Triangle";
            this.chkTriangle.UseVisualStyleBackColor = true;
            // 
            // chkRond
            // 
            this.chkRond.AutoSize = true;
            this.chkRond.Location = new System.Drawing.Point(6, 19);
            this.chkRond.Name = "chkRond";
            this.chkRond.Size = new System.Drawing.Size(52, 17);
            this.chkRond.TabIndex = 1;
            this.chkRond.Text = "Rond";
            this.chkRond.UseVisualStyleBackColor = true;
            // 
            // chkCarré
            // 
            this.chkCarré.AutoSize = true;
            this.chkCarré.Location = new System.Drawing.Point(6, 42);
            this.chkCarré.Name = "chkCarré";
            this.chkCarré.Size = new System.Drawing.Size(51, 17);
            this.chkCarré.TabIndex = 0;
            this.chkCarré.Text = "Carré";
            this.chkCarré.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboC3);
            this.groupBox2.Controls.Add(this.ComboC1);
            this.groupBox2.Controls.Add(this.ComboC4);
            this.groupBox2.Controls.Add(this.ComboC2);
            this.groupBox2.Location = new System.Drawing.Point(12, 570);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capacités";
            // 
            // ComboC3
            // 
            this.ComboC3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboC3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboC3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboC3.FormattingEnabled = true;
            this.ComboC3.Location = new System.Drawing.Point(6, 46);
            this.ComboC3.MaxDropDownItems = 30;
            this.ComboC3.Name = "ComboC3";
            this.ComboC3.Size = new System.Drawing.Size(121, 21);
            this.ComboC3.Sorted = true;
            this.ComboC3.TabIndex = 2;
            // 
            // ComboC1
            // 
            this.ComboC1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboC1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboC1.FormattingEnabled = true;
            this.ComboC1.Location = new System.Drawing.Point(6, 19);
            this.ComboC1.MaxDropDownItems = 30;
            this.ComboC1.Name = "ComboC1";
            this.ComboC1.Size = new System.Drawing.Size(121, 21);
            this.ComboC1.Sorted = true;
            this.ComboC1.TabIndex = 0;
            // 
            // ComboC4
            // 
            this.ComboC4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboC4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboC4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboC4.FormattingEnabled = true;
            this.ComboC4.Location = new System.Drawing.Point(151, 46);
            this.ComboC4.MaxDropDownItems = 30;
            this.ComboC4.Name = "ComboC4";
            this.ComboC4.Size = new System.Drawing.Size(121, 21);
            this.ComboC4.Sorted = true;
            this.ComboC4.TabIndex = 3;
            // 
            // ComboC2
            // 
            this.ComboC2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboC2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboC2.FormattingEnabled = true;
            this.ComboC2.Location = new System.Drawing.Point(151, 19);
            this.ComboC2.MaxDropDownItems = 30;
            this.ComboC2.Name = "ComboC2";
            this.ComboC2.Size = new System.Drawing.Size(121, 21);
            this.ComboC2.Sorted = true;
            this.ComboC2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVitesse);
            this.groupBox3.Controls.Add(this.txtDS);
            this.groupBox3.Controls.Add(this.txtAS);
            this.groupBox3.Controls.Add(this.txtDéfense);
            this.groupBox3.Controls.Add(this.txtAttaque);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPV);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 110);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DV";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(120, 84);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(42, 20);
            this.txtVitesse.TabIndex = 5;
            this.txtVitesse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(63, 84);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(44, 20);
            this.txtDS.TabIndex = 4;
            this.txtDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // txtAS
            // 
            this.txtAS.Location = new System.Drawing.Point(6, 84);
            this.txtAS.Name = "txtAS";
            this.txtAS.Size = new System.Drawing.Size(42, 20);
            this.txtAS.TabIndex = 3;
            this.txtAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // txtDéfense
            // 
            this.txtDéfense.Location = new System.Drawing.Point(120, 39);
            this.txtDéfense.Name = "txtDéfense";
            this.txtDéfense.Size = new System.Drawing.Size(42, 20);
            this.txtDéfense.TabIndex = 2;
            this.txtDéfense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // txtAttaque
            // 
            this.txtAttaque.Location = new System.Drawing.Point(63, 39);
            this.txtAttaque.Name = "txtAttaque";
            this.txtAttaque.Size = new System.Drawing.Size(44, 20);
            this.txtAttaque.TabIndex = 1;
            this.txtAttaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Attaque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Défense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "AS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vitesse";
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(6, 39);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(42, 20);
            this.txtPV.TabIndex = 0;
            this.txtPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PV";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumUDVitesse);
            this.groupBox4.Controls.Add(this.NumUDDS);
            this.groupBox4.Controls.Add(this.NumUDAS);
            this.groupBox4.Controls.Add(this.NumUDDéfense);
            this.groupBox4.Controls.Add(this.NumUDAttaque);
            this.groupBox4.Controls.Add(this.NumUDPV);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 113);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Points d\'efforts";
            // 
            // NumUDVitesse
            // 
            this.NumUDVitesse.Location = new System.Drawing.Point(120, 85);
            this.NumUDVitesse.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDVitesse.Name = "NumUDVitesse";
            this.NumUDVitesse.Size = new System.Drawing.Size(42, 20);
            this.NumUDVitesse.TabIndex = 5;
            // 
            // NumUDDS
            // 
            this.NumUDDS.Location = new System.Drawing.Point(63, 85);
            this.NumUDDS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDDS.Name = "NumUDDS";
            this.NumUDDS.Size = new System.Drawing.Size(42, 20);
            this.NumUDDS.TabIndex = 4;
            // 
            // NumUDAS
            // 
            this.NumUDAS.Location = new System.Drawing.Point(6, 85);
            this.NumUDAS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDAS.Name = "NumUDAS";
            this.NumUDAS.Size = new System.Drawing.Size(44, 20);
            this.NumUDAS.TabIndex = 3;
            // 
            // NumUDDéfense
            // 
            this.NumUDDéfense.Location = new System.Drawing.Point(120, 37);
            this.NumUDDéfense.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDDéfense.Name = "NumUDDéfense";
            this.NumUDDéfense.Size = new System.Drawing.Size(42, 20);
            this.NumUDDéfense.TabIndex = 2;
            // 
            // NumUDAttaque
            // 
            this.NumUDAttaque.Location = new System.Drawing.Point(63, 37);
            this.NumUDAttaque.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDAttaque.Name = "NumUDAttaque";
            this.NumUDAttaque.Size = new System.Drawing.Size(42, 20);
            this.NumUDAttaque.TabIndex = 1;
            // 
            // NumUDPV
            // 
            this.NumUDPV.Location = new System.Drawing.Point(6, 37);
            this.NumUDPV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUDPV.Name = "NumUDPV";
            this.NumUDPV.Size = new System.Drawing.Size(44, 20);
            this.NumUDPV.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Attaque";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Défense";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "PV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "AS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Vitesse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "DS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbAssexué);
            this.groupBox5.Controls.Add(this.rbFemelle);
            this.groupBox5.Controls.Add(this.rbMale);
            this.groupBox5.Location = new System.Drawing.Point(215, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(75, 88);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sexe";
            // 
            // rbAssexué
            // 
            this.rbAssexué.AutoSize = true;
            this.rbAssexué.Location = new System.Drawing.Point(6, 65);
            this.rbAssexué.Name = "rbAssexué";
            this.rbAssexué.Size = new System.Drawing.Size(65, 17);
            this.rbAssexué.TabIndex = 2;
            this.rbAssexué.Text = "Assexué";
            this.rbAssexué.UseVisualStyleBackColor = true;
            // 
            // rbFemelle
            // 
            this.rbFemelle.AutoSize = true;
            this.rbFemelle.Location = new System.Drawing.Point(6, 42);
            this.rbFemelle.Name = "rbFemelle";
            this.rbFemelle.Size = new System.Drawing.Size(61, 17);
            this.rbFemelle.TabIndex = 1;
            this.rbFemelle.Text = "Femelle";
            this.rbFemelle.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(6, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Mâle";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // ComboNature
            // 
            this.ComboNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNature.FormattingEnabled = true;
            this.ComboNature.Location = new System.Drawing.Point(12, 93);
            this.ComboNature.Name = "ComboNature";
            this.ComboNature.Size = new System.Drawing.Size(121, 21);
            this.ComboNature.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nature";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Capacité spéciale";
            // 
            // ComboCapacitéSpé
            // 
            this.ComboCapacitéSpé.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCapacitéSpé.FormattingEnabled = true;
            this.ComboCapacitéSpé.Location = new System.Drawing.Point(12, 149);
            this.ComboCapacitéSpé.Name = "ComboCapacitéSpé";
            this.ComboCapacitéSpé.Size = new System.Drawing.Size(121, 21);
            this.ComboCapacitéSpé.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbShiney);
            this.groupBox6.Controls.Add(this.rbNormal);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(151, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(137, 145);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Apparence";
            // 
            // rbShiney
            // 
            this.rbShiney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbShiney.AutoSize = true;
            this.rbShiney.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbShiney.Location = new System.Drawing.Point(68, 117);
            this.rbShiney.Name = "rbShiney";
            this.rbShiney.Size = new System.Drawing.Size(63, 18);
            this.rbShiney.TabIndex = 1;
            this.rbShiney.Text = "Shiney";
            this.rbShiney.UseVisualStyleBackColor = true;
            this.rbShiney.CheckedChanged += new System.EventHandler(this.rbShiney_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbNormal.Location = new System.Drawing.Point(6, 117);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(64, 18);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbAS);
            this.groupBox7.Controls.Add(this.lbDS);
            this.groupBox7.Controls.Add(this.lbVitesse);
            this.groupBox7.Controls.Add(this.lbPV);
            this.groupBox7.Controls.Add(this.lbAttaque);
            this.groupBox7.Controls.Add(this.lbDéfense);
            this.groupBox7.Location = new System.Drawing.Point(12, 479);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(186, 71);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Statistiques";
            // 
            // lbAS
            // 
            this.lbAS.AutoSize = true;
            this.lbAS.Location = new System.Drawing.Point(13, 43);
            this.lbAS.Name = "lbAS";
            this.lbAS.Size = new System.Drawing.Size(24, 13);
            this.lbAS.TabIndex = 5;
            this.lbAS.Text = "AS:";
            // 
            // lbDS
            // 
            this.lbDS.AutoSize = true;
            this.lbDS.Location = new System.Drawing.Point(72, 43);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(25, 13);
            this.lbDS.TabIndex = 4;
            this.lbDS.Text = "DS:";
            // 
            // lbVitesse
            // 
            this.lbVitesse.AutoSize = true;
            this.lbVitesse.Location = new System.Drawing.Point(131, 43);
            this.lbVitesse.Name = "lbVitesse";
            this.lbVitesse.Size = new System.Drawing.Size(17, 13);
            this.lbVitesse.TabIndex = 3;
            this.lbVitesse.Text = "V:";
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(13, 16);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(24, 13);
            this.lbPV.TabIndex = 2;
            this.lbPV.Text = "PV:";
            // 
            // lbAttaque
            // 
            this.lbAttaque.AutoSize = true;
            this.lbAttaque.Location = new System.Drawing.Point(72, 15);
            this.lbAttaque.Name = "lbAttaque";
            this.lbAttaque.Size = new System.Drawing.Size(17, 13);
            this.lbAttaque.TabIndex = 1;
            this.lbAttaque.Text = "A:";
            // 
            // lbDéfense
            // 
            this.lbDéfense.AutoSize = true;
            this.lbDéfense.Location = new System.Drawing.Point(131, 15);
            this.lbDéfense.Name = "lbDéfense";
            this.lbDéfense.Size = new System.Drawing.Size(18, 13);
            this.lbDéfense.TabIndex = 0;
            this.lbDéfense.Text = "D:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(212, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Niveau";
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(12, 450);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(176, 23);
            this.btCalculer.TabIndex = 13;
            this.btCalculer.Text = "Calculer statistiques";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Location = new System.Drawing.Point(198, 285);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(84, 23);
            this.btEnregistrer.TabIndex = 12;
            this.btEnregistrer.Text = "Enregi&strer...";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCharger
            // 
            this.btCharger.Location = new System.Drawing.Point(198, 256);
            this.btCharger.Name = "btCharger";
            this.btCharger.Size = new System.Drawing.Size(84, 23);
            this.btCharger.TabIndex = 11;
            this.btCharger.Text = "&Charger...";
            this.btCharger.UseVisualStyleBackColor = true;
            this.btCharger.Click += new System.EventHandler(this.btCharger_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.xml";
            this.saveFileDialog1.Filter = "Fichier XML|*.xml";
            this.saveFileDialog1.InitialDirectory = "Fiches";
            // 
            // NumUDNiveau
            // 
            this.NumUDNiveau.Location = new System.Drawing.Point(213, 228);
            this.NumUDNiveau.Name = "NumUDNiveau";
            this.NumUDNiveau.Size = new System.Drawing.Size(50, 20);
            this.NumUDNiveau.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Fichier XML|*.xml";
            this.openFileDialog1.InitialDirectory = "Fiches";
            // 
            // FormPokéFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 654);
            this.Controls.Add(this.NumUDNiveau);
            this.Controls.Add(this.btCharger);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ComboCapacitéSpé);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ComboNature);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboPokémon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPokéFiche";
            this.Text = "PokéFiche";
            this.Load += new System.EventHandler(this.FormPokéFiche_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDDéfense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDAttaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPV)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDNiveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboPokémon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCoeur;
        private System.Windows.Forms.CheckBox chkTriangle;
        private System.Windows.Forms.CheckBox chkRond;
        private System.Windows.Forms.CheckBox chkCarré;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboC3;
        private System.Windows.Forms.ComboBox ComboC1;
        private System.Windows.Forms.ComboBox ComboC4;
        private System.Windows.Forms.ComboBox ComboC2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.TextBox txtAS;
        private System.Windows.Forms.TextBox txtAttaque;
        private System.Windows.Forms.TextBox txtDéfense;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NumUDPV;
        private System.Windows.Forms.NumericUpDown NumUDAttaque;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumUDDS;
        private System.Windows.Forms.NumericUpDown NumUDVitesse;
        private System.Windows.Forms.NumericUpDown NumUDAS;
        private System.Windows.Forms.NumericUpDown NumUDDéfense;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbAssexué;
        private System.Windows.Forms.RadioButton rbFemelle;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox ComboNature;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ComboCapacitéSpé;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbShiney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbAS;
        private System.Windows.Forms.Label lbDS;
        private System.Windows.Forms.Label lbVitesse;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.Label lbAttaque;
        private System.Windows.Forms.Label lbDéfense;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btCharger;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown NumUDNiveau;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chketoile;
        private System.Windows.Forms.CheckBox chklosange;
    }
}