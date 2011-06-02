using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace URA_Pokemon
{
    public partial class FormCompare : Form
    {
        Pokemon CurrentPokemon1;
        double PV1;
        double A1;
        double D1;
        double AS1;
        double DS1;
        double V1;
        Type t11 = Type.AUCUN;
        Type t21 = Type.AUCUN;
        Type t31 = Type.AUCUN;
        Type t41 = Type.AUCUN;

        Pokemon CurrentPokemon2;
        double PV2;
        double A2;
        double D2;
        double AS2;
        double DS2;
        double V2;
        Type t12 = Type.AUCUN;
        Type t22 = Type.AUCUN;
        Type t32 = Type.AUCUN;
        Type t42 = Type.AUCUN;

        string[] NatureNoms = new string[25];
        string[] NatureNomsPur = new string[25];
        double[][] NatureValeurs = new double[25][];
        Xblood xb;

        public FormCompare()
        {
            InitializeComponent();
        }

        void FillComboPokémon()
        {
            ComboPoke1.Text = "";
            ComboPoke1.Items.Clear();
            ComboPoke2.Text = "";
            ComboPoke2.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
            {
                ComboPoke1.Items.Add(p.Nom);
                ComboPoke2.Items.Add(p.Nom);
            }
        }

        void FillComboNature()
        {
            //Valeurs (A, D, V, AS, DS)
            NatureValeurs[0] = new double[] { 0.9, 1.1, 1, 1, 1 };
            NatureValeurs[1] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[2] = new double[] { 1.1, 1, 0.9, 1, 1 };
            NatureValeurs[3] = new double[] { 0.9, 1, 1, 1, 1.1 };
            NatureValeurs[4] = new double[] { 1, 1, 0.9, 1.1, 1 };
            NatureValeurs[5] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[6] = new double[] { 1, 0.9, 1, 1.1, 1 };
            NatureValeurs[7] = new double[] { 1, 1, 1, 1.1, 0.9 };
            NatureValeurs[8] = new double[] { 1, 0.9, 1, 1, 1.1 };
            NatureValeurs[9] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[10] = new double[] { 1, 1, 1.1, 0.9, 1 };
            NatureValeurs[11] = new double[] { 1, 1.1, 1, 1, 0.9 };
            NatureValeurs[12] = new double[] { 1, 1.1, 1, 0.9, 1 };
            NatureValeurs[13] = new double[] { 1, 1, 0.9, 1, 1.1 };
            NatureValeurs[14] = new double[] { 1.1, 1, 1, 1, 0.9 };
            NatureValeurs[15] = new double[] { 0.9, 1, 1, 1.1, 1 };
            NatureValeurs[16] = new double[] { 1, 1, 1.1, 1, 0.9 };
            NatureValeurs[17] = new double[] { 1, 0.9, 1.1, 1, 1 };
            NatureValeurs[18] = new double[] { 1, 1, 1, 0.9, 1.1 };
            NatureValeurs[19] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[20] = new double[] { 1, 1.1, 0.9, 1, 1 };
            NatureValeurs[21] = new double[] { 1.1, 1, 1, 0.9, 1 };
            NatureValeurs[22] = new double[] { 1, 1, 1, 1, 1 };
            NatureValeurs[23] = new double[] { 1.1, 0.9, 1, 1, 1 };
            NatureValeurs[24] = new double[] { 0.9, 1, 1.1, 1, 1 };

            //Noms
            NatureNoms[0] = "Assuré(A-, D+)";
            NatureNoms[1] = "Bizarre";
            NatureNoms[2] = "Brave(A+, V-)";
            NatureNoms[3] = "Calme(A-, DS+)";
            NatureNoms[4] = "Discret(V-, AS+)";
            NatureNoms[5] = "Docile";
            NatureNoms[6] = "Doux(AS+, D-)";
            NatureNoms[7] = "Foufou(DS-, AS+)";
            NatureNoms[8] = "Gentil(D-, DS+)";
            NatureNoms[9] = "Hardi";
            NatureNoms[10] = "Jovial(AS-, V+)";
            NatureNoms[11] = "Laché(D+, DS-)";
            NatureNoms[12] = "Malin(AS-, D+)";
            NatureNoms[13] = "Malpoli(V-, DS+)";
            NatureNoms[14] = "Mauvais(A+, DS-)";
            NatureNoms[15] = "Modeste(A-, AS+)";
            NatureNoms[16] = "Naïf(DS-, V+)";
            NatureNoms[17] = "Pressé(V+, D-)";
            NatureNoms[18] = "Prudent(AS-, DS+)";
            NatureNoms[19] = "Pudique";
            NatureNoms[20] = "Relax(D+, V-)";
            NatureNoms[21] = "Rigide(A+, AS-)";
            NatureNoms[22] = "Sérieux";
            NatureNoms[23] = "Solo(A+, D-)";
            NatureNoms[24] = "Timide(A-, V+)";

            NatureNomsPur[0] = "Assure";
            NatureNomsPur[1] = "Bizarre";
            NatureNomsPur[2] = "Brave";
            NatureNomsPur[3] = "Calme";
            NatureNomsPur[4] = "Discret";
            NatureNomsPur[5] = "Docile";
            NatureNomsPur[6] = "Doux";
            NatureNomsPur[7] = "Foufou";
            NatureNomsPur[8] = "Gentil";
            NatureNomsPur[9] = "Hardi";
            NatureNomsPur[10] = "Jovial";
            NatureNomsPur[11] = "Lache";
            NatureNomsPur[12] = "Malin";
            NatureNomsPur[13] = "Malpoli";
            NatureNomsPur[14] = "Mauvais";
            NatureNomsPur[15] = "Modeste";
            NatureNomsPur[16] = "Naif";
            NatureNomsPur[17] = "Presse";
            NatureNomsPur[18] = "Prudent";
            NatureNomsPur[19] = "Pudique";
            NatureNomsPur[20] = "Relax";
            NatureNomsPur[21] = "Rigide";
            NatureNomsPur[22] = "Serieux";
            NatureNomsPur[23] = "Solo";
            NatureNomsPur[24] = "Timide";

            foreach (string str in NatureNoms)
            {
                ComboNature1.Items.Add(str);
                ComboNature2.Items.Add(str);
            }
        }

        void CalcStatsPoke1()
        {
            if (CurrentPokemon1 != null)
            {
                double[] Nature = new double[] { 1, 1, 1, 1, 1 };
                if (ComboNature1.Text != "")
                    Nature = NatureValeurs[ComboNature1.SelectedIndex];

                double N = Convert.ToDouble(NumUDNiveau1.Value);
                double dvpv = 0;
                dvpv = Convert.ToDouble(NumDVPV1.Value);
                double pepv = Convert.ToDouble(NumUDPV1.Value);
                double dva = 0;
                dva = Convert.ToDouble(NumDVA1.Value);
                double pea = Convert.ToDouble(NumUDAttaque1.Value);
                double dvd = 0;
                dvd = Convert.ToDouble(NumDVD1.Value);
                double ped = Convert.ToDouble(NumUDDéfense1.Value);
                double dvas = 0;
                dvas = Convert.ToDouble(NumDVAS1.Value);
                double peas = Convert.ToDouble(NumUDAS1.Value);
                double dvds = 0;
                dvds = Convert.ToDouble(NumDVDS1.Value);
                double peds = Convert.ToDouble(NumUDDS1.Value);
                double dvv = 0;
                dvv = Convert.ToDouble(NumDVV1.Value);
                double pev = Convert.ToDouble(NumUDVitesse1.Value);

                double npv = GetStatLevel(cbNivAltPV1.Text);
                double na = GetStatLevel(cbNivAltA1.Text);
                double nd = GetStatLevel(cbNivAltD1.Text);
                double nas = GetStatLevel(cbNivAltAS1.Text);
                double nds = GetStatLevel(cbNivAltDS1.Text);
                double nv = GetStatLevel(cbNivAltV1.Text);


                PV1 = Math.Truncate(((2 * CurrentPokemon1.Stat_PV + dvpv + Math.Truncate(pepv / 4)) * N / 100 + 10 + N));
                A1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon1.Stat_Attaque + dva + Math.Truncate(pea / 4)) * N / 100 + 5) * Nature[0]);
                D1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon1.Stat_Défense + dvd + Math.Truncate(ped / 4)) * N / 100 + 5) * Nature[1]);
                AS1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon1.Stat_AttaqueSpé + dvas + Math.Truncate(peas / 4)) * N / 100 + 5) * Nature[3]);
                DS1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon1.Stat_DéfenseSpé + dvds + Math.Truncate(peds / 4)) * N / 100 + 5) * Nature[4]);
                V1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon1.Stat_Vitesse + dvv + Math.Truncate(pev / 4)) * N / 100 + 5) * Nature[2]);



                PV1 = Math.Truncate(PV1 * npv);
                A1 = Math.Truncate(A1 * na);
                D1 = Math.Truncate(D1 * nd);
                AS1 = Math.Truncate(AS1 * nas);
                DS1 = Math.Truncate(DS1 * nds);
                V1 = Math.Truncate(V1 * nv);

                if (PV1 > 999d)
                    PV1 = 999d;
                else if (PV1 < 1d)
                    PV1 = 1d;
                if (A1 > 999d)
                    A1 = 999d;
                else if (A1 < 1d)
                    A1 = 1d;
                if (D1 > 999d)
                    D1 = 999d;
                else if (D1 < 1d)
                    D1 = 1d;
                if (AS1 > 999d)
                    AS1 = 999d;
                else if (AS1 < 1d)
                    AS1 = 1d;
                if (DS1 > 999d)
                    DS1 = 999d;
                else if (DS1 < 1d)
                    DS1 = 1d;
                if (V1 > 999d)
                    V1 = 999d;
                else if (V1 < 1d)
                    V1 = 1d;

                nStatPV1.ValueChanged -= new EventHandler(StatsManualChange);
                nStatA1.ValueChanged -= new EventHandler(StatsManualChange);
                nStatD1.ValueChanged -= new EventHandler(StatsManualChange);
                nStatAS1.ValueChanged -= new EventHandler(StatsManualChange);
                nStatDS1.ValueChanged -= new EventHandler(StatsManualChange);
                nStatV1.ValueChanged -= new EventHandler(StatsManualChange);

                nStatPV1.Value = (decimal)PV1;
                nStatA1.Value = (decimal)A1;
                nStatD1.Value = (decimal)D1;
                nStatAS1.Value = (decimal)AS1;
                nStatDS1.Value = (decimal)DS1;
                nStatV1.Value = (decimal)V1;

                nStatPV1.ValueChanged += new EventHandler(StatsManualChange);
                nStatA1.ValueChanged += new EventHandler(StatsManualChange);
                nStatD1.ValueChanged += new EventHandler(StatsManualChange);
                nStatAS1.ValueChanged += new EventHandler(StatsManualChange);
                nStatDS1.ValueChanged += new EventHandler(StatsManualChange);
                nStatV1.ValueChanged += new EventHandler(StatsManualChange);

                RecalcCapacites1(null, null);
            }


        }

        private double GetStatLevel(string n)
        {
            switch (n)
            {
                case "-6":
                    return 1d / 4d;
                case "-5":
                    return 2d / 7d;
                case "-4":
                    return 1d / 3d;
                case "-3":
                    return 2d / 5d;
                case "-2":
                    return 1d / 2d;
                case "-1":
                    return 2d / 3d;
                case "0":
                    return 1d;
                case "1":
                    return 3d / 2d;
                case "2":
                    return 2d;
                case "3":
                    return 5d / 2d;
                case "4":
                    return 3d;
                case "5":
                    return 7d / 2d;
                case "6":
                    return 4d;
                default:
                    return 1d;
            }
        }

        void CalcStatsPoke2()
        {
            if (CurrentPokemon2 != null)
            {
                double[] Nature = new double[] { 1, 1, 1, 1, 1 };
                if (ComboNature2.Text != "")
                    Nature = NatureValeurs[ComboNature2.SelectedIndex];

                double N = Convert.ToDouble(NumUDNiveau2.Value);
                double dvpv = 0;
                dvpv = Convert.ToDouble(NumDVPV2.Value);
                double pepv = Convert.ToDouble(NumUDPV2.Value);
                double dva = 0;
                dva = Convert.ToDouble(NumDVA2.Value);
                double pea = Convert.ToDouble(NumUDAttaque2.Value);
                double dvd = 0;
                dvd = Convert.ToDouble(NumDVD2.Value);
                double ped = Convert.ToDouble(NumUDDéfense2.Value);
                double dvas = 0;
                dvas = Convert.ToDouble(NumDVAS2.Value);
                double peas = Convert.ToDouble(NumUDAS2.Value);
                double dvds = 0;
                dvds = Convert.ToDouble(NumDVDS2.Value);
                double peds = Convert.ToDouble(NumUDDS2.Value);
                double dvv = 0;
                dvv = Convert.ToDouble(NumDVV2.Value);
                double pev = Convert.ToDouble(NumUDVitesse2.Value);

                double npv = GetStatLevel(cbNivAltPV2.Text);
                double na = GetStatLevel(cbNivAltA2.Text);
                double nd = GetStatLevel(cbNivAltD2.Text);
                double nas = GetStatLevel(cbNivAltAS2.Text);
                double nds = GetStatLevel(cbNivAltDS2.Text);
                double nv = GetStatLevel(cbNivAltV2.Text);

                PV2 = Math.Truncate(((2 * CurrentPokemon2.Stat_PV + dvpv + Math.Truncate(pepv / 4)) * N / 100 + 10 + N));
                A2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon2.Stat_Attaque + dva + Math.Truncate(pea / 4)) * N / 100 + 5) * Nature[0]);
                D2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon2.Stat_Défense + dvd + Math.Truncate(ped / 4)) * N / 100 + 5) * Nature[1]);
                AS2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon2.Stat_AttaqueSpé + dvas + Math.Truncate(peas / 4)) * N / 100 + 5) * Nature[3]);
                DS2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon2.Stat_DéfenseSpé + dvds + Math.Truncate(peds / 4)) * N / 100 + 5) * Nature[4]);
                V2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon2.Stat_Vitesse + dvv + Math.Truncate(pev / 4)) * N / 100 + 5) * Nature[2]);


                PV2 = Math.Truncate(PV2 * npv);
                A2 = Math.Truncate(A2 * na);
                D2 = Math.Truncate(D2 * nd);
                AS2 = Math.Truncate(AS2 * nas);
                DS2 = Math.Truncate(DS2 * nds);
                V2 = Math.Truncate(V2 * nv);

                if (PV2 > 999d)
                    PV2 = 999d;
                else if (PV2 < 1d)
                    PV2 = 1d;
                if (A2 > 999d)
                    A2 = 999d;
                else if (A2 < 1d)
                    A2 = 1d;
                if (D2 > 999d)
                    D2 = 999d;
                else if (D2 < 1d)
                    D2 = 1d;
                if (AS2 > 999d)
                    AS2 = 999d;
                else if (AS2 < 1d)
                    AS2 = 1d;
                if (DS2 > 999d)
                    DS2 = 999d;
                else if (DS2 < 1d)
                    DS2 = 1d;
                if (V2 > 999d)
                    V2 = 999d;
                else if (V2 < 1d)
                    V2 = 1d;

                nStatPV2.ValueChanged -= new EventHandler(StatsManualChange);
                nStatA2.ValueChanged -= new EventHandler(StatsManualChange);
                nStatD2.ValueChanged -= new EventHandler(StatsManualChange);
                nStatAS2.ValueChanged -= new EventHandler(StatsManualChange);
                nStatDS2.ValueChanged -= new EventHandler(StatsManualChange);
                nStatV2.ValueChanged -= new EventHandler(StatsManualChange);

                nStatPV2.Value = (decimal)PV2;
                nStatA2.Value = (decimal)A2;
                nStatD2.Value = (decimal)D2;
                nStatAS2.Value = (decimal)AS2;
                nStatDS2.Value = (decimal)DS2;
                nStatV2.Value = (decimal)V2;

                nStatPV2.ValueChanged += new EventHandler(StatsManualChange);
                nStatA2.ValueChanged += new EventHandler(StatsManualChange);
                nStatD2.ValueChanged += new EventHandler(StatsManualChange);
                nStatAS2.ValueChanged += new EventHandler(StatsManualChange);
                nStatDS2.ValueChanged += new EventHandler(StatsManualChange);
                nStatV2.ValueChanged += new EventHandler(StatsManualChange);

                RecalcCapacites2(null, null);
            }
        }

        void Stats1Altered(object sender, EventArgs e)
        {
            CalcStatsPoke1();
            RecalcCapacites2(null, null);
        }

        void Stats2Altered(object sender, EventArgs e)
        {
            CalcStatsPoke2();
            RecalcCapacites1(null, null);
        }

        void StatsManualChange(object sender, EventArgs e)
        {
            PV1 = Convert.ToDouble(nStatPV1.Value);
            A1 = Convert.ToDouble(nStatA1.Value);
            D1 = Convert.ToDouble(nStatD1.Value);
            AS1 = Convert.ToDouble(nStatAS1.Value);
            DS1 = Convert.ToDouble(nStatDS1.Value);
            V1 = Convert.ToDouble(nStatV1.Value);

            PV2 = Convert.ToDouble(nStatPV2.Value);
            A2 = Convert.ToDouble(nStatA2.Value);
            D2 = Convert.ToDouble(nStatD2.Value);
            AS2 = Convert.ToDouble(nStatAS2.Value);
            DS2 = Convert.ToDouble(nStatDS2.Value);
            V2 = Convert.ToDouble(nStatV2.Value);

            RecalcCapacites1(null, null);
            RecalcCapacites2(null, null);

        }

        void ChangePokemon1()
        {
            lbEfficace1.Text = "Efficacité: ";
            lbNeutre1.Text = "Neutralité: ";
            lbInneff1.Text = "Innefficacité: ";
            lbImmunite1.Text = "Immunité: ";

            lbCapType11.Text = "";
            lbCapType21.Text = "";
            lbCapType31.Text = "";
            lbCapType41.Text = "";
            
            lbNature11.Text = "Nature: ";
            lbNature21.Text = "Nature: ";
            lbNature31.Text = "Nature: ";
            lbNature41.Text = "Nature: ";

            t11 = Type.AUCUN;
            t21 = Type.AUCUN;
            t31 = Type.AUCUN;
            t41 = Type.AUCUN;
            
            ComboC11.Items.Clear();
            ComboC21.Items.Clear();
            ComboC31.Items.Clear();
            ComboC41.Items.Clear();

            ComboC11.Items.Add("(vide)");
            ComboC21.Items.Add("(vide)");
            ComboC31.Items.Add("(vide)");
            ComboC41.Items.Add("(vide)");

            ComboC11.SelectedIndexChanged -= new EventHandler(ComboC11_SelectedIndexChanged);
            ComboC21.SelectedIndexChanged -= new EventHandler(ComboC21_SelectedIndexChanged);
            ComboC31.SelectedIndexChanged -= new EventHandler(ComboC31_SelectedIndexChanged);
            ComboC41.SelectedIndexChanged -= new EventHandler(ComboC41_SelectedIndexChanged);

            ComboC11.SelectedIndex = 0;
            ComboC21.SelectedIndex = 0;
            ComboC31.SelectedIndex = 0;
            ComboC41.SelectedIndex = 0;

            ComboC11.SelectedIndexChanged += new EventHandler(ComboC11_SelectedIndexChanged);
            ComboC21.SelectedIndexChanged += new EventHandler(ComboC21_SelectedIndexChanged);
            ComboC31.SelectedIndexChanged += new EventHandler(ComboC31_SelectedIndexChanged);
            ComboC41.SelectedIndexChanged += new EventHandler(ComboC41_SelectedIndexChanged);

            CurrentPokemon1 = xb.GetPokémon(ComboPoke1.Text);

            lbType11.Text = CurrentPokemon1.Type1.ToString();
            if (CurrentPokemon1.Type2 != Type.AUCUN)
                lbType21.Text = CurrentPokemon1.Type2.ToString();
            else
                lbType21.Text = "";

            Capacite[] cap = Xblood.ListofMoves(CurrentPokemon1);
            foreach (Capacite c in cap)
            {
                ComboC11.Items.Add(c.Nom);
                ComboC21.Items.Add(c.Nom);
                ComboC31.Items.Add(c.Nom);
                ComboC41.Items.Add(c.Nom);
            }

            CalcStatsPoke1();
            RecalcCapacites2(null, null);
        }

        void ChangePokemon2()
        {
            lbEfficace2.Text = "Efficacité: ";
            lbNeutre2.Text = "Neutralité: ";
            lbInneff2.Text = "Innefficacité: ";
            lbImmunite2.Text = "Immunité: ";

            lbCapType12.Text = "";
            lbCapType22.Text = "";
            lbCapType32.Text = "";
            lbCapType42.Text = "";

            lbNature12.Text = "Nature: ";
            lbNature22.Text = "Nature: ";
            lbNature32.Text = "Nature: ";
            lbNature42.Text = "Nature: ";

            t12 = Type.AUCUN;
            t22 = Type.AUCUN;
            t32 = Type.AUCUN;
            t42 = Type.AUCUN;
            
            ComboC12.Items.Clear();
            ComboC22.Items.Clear();
            ComboC32.Items.Clear();
            ComboC42.Items.Clear();

            ComboC12.Items.Add("(vide)");
            ComboC22.Items.Add("(vide)");
            ComboC32.Items.Add("(vide)");
            ComboC42.Items.Add("(vide)");

            ComboC12.SelectedIndexChanged -= new EventHandler(ComboC12_SelectedIndexChanged);
            ComboC22.SelectedIndexChanged -= new EventHandler(ComboC22_SelectedIndexChanged);
            ComboC32.SelectedIndexChanged -= new EventHandler(ComboC32_SelectedIndexChanged);
            ComboC42.SelectedIndexChanged -= new EventHandler(ComboC42_SelectedIndexChanged);

            ComboC12.SelectedIndex = 0;
            ComboC22.SelectedIndex = 0;
            ComboC32.SelectedIndex = 0;
            ComboC42.SelectedIndex = 0;

            ComboC12.SelectedIndexChanged += new EventHandler(ComboC12_SelectedIndexChanged);
            ComboC22.SelectedIndexChanged += new EventHandler(ComboC22_SelectedIndexChanged);
            ComboC32.SelectedIndexChanged += new EventHandler(ComboC32_SelectedIndexChanged);
            ComboC42.SelectedIndexChanged += new EventHandler(ComboC42_SelectedIndexChanged);

            CurrentPokemon2 = xb.GetPokémon(ComboPoke2.Text);

            lbType12.Text = CurrentPokemon2.Type1.ToString();
            if (CurrentPokemon2.Type2 != Type.AUCUN)
                lbType22.Text = CurrentPokemon2.Type2.ToString();
            else
                lbType22.Text = "";

            Capacite[] cap = Xblood.ListofMoves(CurrentPokemon2);
            foreach (Capacite c in cap)
            {
                ComboC12.Items.Add(c.Nom);
                ComboC22.Items.Add(c.Nom);
                ComboC32.Items.Add(c.Nom);
                ComboC42.Items.Add(c.Nom);
            }

            CalcStatsPoke2();
            RecalcCapacites1(null, null);
        }

        private void FormCompare_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            if (Xblood.Types == null)
                Xblood.FillTypes();
            FillComboPokémon();
            FillComboNature();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePokemon1();
        }

        private void NumUDNiveau1_KeyUp(object sender, KeyEventArgs e)
        {
            CalcStatsPoke1();
        }

        int Efficacite(Type attaque, Type type1, Type type2)
        {
            if (type1 == Type.AUCUN && type2 == Type.AUCUN)
                return 0;
            else if (attaque == Type.AUCUN)
                return 7;
            else if (type1 != Type.AUCUN && type2 == Type.AUCUN)
                return Xblood.Types[(int)attaque, (int)type1];
            else if (type1 == Type.AUCUN && type2 != Type.AUCUN)
                return Xblood.Types[(int)attaque, (int)type2];
            else
            {
                if (Xblood.Types[(int)attaque, (int)type1] == 7 || Xblood.Types[(int)attaque, (int)type2] == 7)
                    return 7;
                return Xblood.Types[(int)attaque, (int)type1] + Xblood.Types[(int)attaque, (int)type2];
            }

        }

        void CalcEfficacite1(Type t1, Type t2, Type t3, Type t4)
        {
            if (Xblood.TypesExistants == null)
                Xblood.FillTypesExistants();

            int length0 = Xblood.TypesExistants.GetLength(0);
            int length1 = Xblood.TypesExistants.GetLength(1);

            int Efficace = 0;
            int Neutre = 0;
            int Innefficace = 0;
            int Immunise = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i != j && Xblood.TypesExistants[j, i])
                    {
                        int eff1 = Efficacite(t1, (Type)i, (Type)j);
                        int eff2 = Efficacite(t2, (Type)i, (Type)j);
                        int eff3 = Efficacite(t3, (Type)i, (Type)j);
                        int eff4 = Efficacite(t4, (Type)i, (Type)j);

                        if (eff1 == 7 && eff2 == 7 && eff3 == 7 && eff4 == 7)
                            Immunise++;
                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7))
                            Efficace++;
                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0)
                            Neutre++;
                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2)
                            Innefficace++;
                        else
                            System.Diagnostics.Debug.Assert(true);
                    }

                }
            }

            lbEfficace1.Text = "Efficacité: " + Efficace;
            lbNeutre1.Text = "Neutralité: " + Neutre;
            lbInneff1.Text = "Innefficacité: " + Innefficace;
            lbImmunite1.Text = "Immunité: " + Immunise;
        }

        void CalcEfficacite2(Type t1, Type t2, Type t3, Type t4)
        {
            if (Xblood.TypesExistants == null)
                Xblood.FillTypesExistants();

            int length0 = Xblood.TypesExistants.GetLength(0);
            int length1 = Xblood.TypesExistants.GetLength(1);

            int Efficace = 0;
            int Neutre = 0;
            int Innefficace = 0;
            int Immunise = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i != j && Xblood.TypesExistants[j, i])
                    {
                        int eff1 = Efficacite(t1, (Type)i, (Type)j);
                        int eff2 = Efficacite(t2, (Type)i, (Type)j);
                        int eff3 = Efficacite(t3, (Type)i, (Type)j);
                        int eff4 = Efficacite(t4, (Type)i, (Type)j);

                        if (eff1 == 7 && eff2 == 7 && eff3 == 7 && eff4 == 7)
                            Immunise++;
                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7))
                            Efficace++;
                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0)
                            Neutre++;
                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2)
                            Innefficace++;
                    }

                }
            }

            lbEfficace2.Text = "Efficacité: " + Efficace;
            lbNeutre2.Text = "Neutralité: " + Neutre;
            lbInneff2.Text = "Innefficacité: " + Innefficace;
            lbImmunite2.Text = "Immunité: " + Immunise;
        }

        void RecalcCapacites1(object sender, EventArgs e)
        {
            //ComboC11_SelectedIndexChanged(null, null);
            //ComboC21_SelectedIndexChanged(null, null);
            //ComboC31_SelectedIndexChanged(null, null);
            //ComboC41_SelectedIndexChanged(null, null);

            nPowCap11_ValueChanged(null, null);
            nPowCap21_ValueChanged(null, null);
            nPowCap31_ValueChanged(null, null);
            nPowCap41_ValueChanged(null, null);
        }

        void RecalcCapacites2(object sender, EventArgs e)
        {
            //ComboC12_SelectedIndexChanged(null, null);
            //ComboC22_SelectedIndexChanged(null, null);
            //ComboC32_SelectedIndexChanged(null, null);
            //ComboC42_SelectedIndexChanged(null, null);

            nPowCap12_ValueChanged(null, null);
            nPowCap22_ValueChanged(null, null);
            nPowCap32_ValueChanged(null, null);
            nPowCap42_ValueChanged(null, null);
        }

        private void ComboC11_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature11.Text = "Nature: ";
            lbCapType11.Text = "";
            t11 = Type.AUCUN;

            if (ComboC11.Text != null && ComboC11.Text != "" && ComboC11.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC11.Text);

                lbCapType11.Text = cap.TypeAttaque.ToString();
                lbNature11.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t11 = cap.TypeAttaque;
                else
                    t11 = Type.AUCUN;

                decimal oldval = nPowCap11.Value;
                nPowCap11.Value = (decimal)cap.Force;

                if (oldval == nPowCap11.Value)
                    nPowCap11_ValueChanged(null, null);
            }
            else
            {
                lbKO11.Text = "KO: ";
                lbdgPV11.Text = "Dg PV: ";
                lbdgpourcent11.Text = "Dg %: ";
            }

            CalcEfficacite1(t11, t21, t31, t41);
        }

        void GetOutPutCapacite1(Capacite cap, double force, out int damagepvmin, out int damagepvmax, out int KOmax, out int KOmin, out double dgpourcentmin, out double dgpourcentmax)
        {
            double atq = 0.0;
            double def = 0.0;

            if (cap.NatureDegat == NatureDegat.Physique)
            {
                atq = A1;
                def = D2;
            }
            else if (cap.NatureDegat == NatureDegat.Special)
            {
                atq = AS1;
                def = DS2;
            }


            double efficacite = 0.0;
            if (CurrentPokemon2.Type2 != Type.AUCUN)
                efficacite = Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon2.Type1] + Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon2.Type2];
            else
                efficacite = Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon2.Type1];

            if (efficacite == 0)
                efficacite = 1;
            else if (efficacite == -2)
                efficacite = 0.50;
            else if (efficacite == -4)
                efficacite = 0.25;
            else if (efficacite > 4)
                efficacite = 0;


            bool stab = cap.TypeAttaque == CurrentPokemon1.Type1 || cap.TypeAttaque == CurrentPokemon1.Type2;

            damagepvmin = GetDamage((double)(NumUDNiveau1.Value), atq, efficacite, def, force, stab, 217.0);
            damagepvmax = GetDamage((double)(NumUDNiveau1.Value), atq, efficacite, def, force, stab, 255.0);

            if (damagepvmin != 0)
                KOmax = (int)Math.Ceiling(PV2 / damagepvmin);
            else
                KOmax = 0;
            if (damagepvmax != 0)
                KOmin = (int)Math.Ceiling(PV2 / damagepvmax);
            else
                KOmin = 0;

            dgpourcentmin = Math.Round(((double)damagepvmin / PV2) * 100, 1);
            dgpourcentmax = Math.Round(((double)damagepvmax / PV2) * 100, 1);
        }

        void GetOutPutCapacite2(Capacite cap, double force, out int damagepvmin, out int damagepvmax, out int KOmax, out int KOmin, out double dgpourcentmin, out double dgpourcentmax)
        {
            double atq = 0.0;
            double def = 0.0;

            if (cap.NatureDegat == NatureDegat.Physique)
            {
                atq = A2;
                def = D1;
            }
            else if (cap.NatureDegat == NatureDegat.Special)
            {
                atq = AS2;
                def = DS1;
            }


            double efficacite = 0.0;
            if (CurrentPokemon1.Type2 != Type.AUCUN)
                efficacite = Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon1.Type1] + Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon1.Type2];
            else
                efficacite = Xblood.Types[(int)cap.TypeAttaque, (int)CurrentPokemon1.Type1];

            if (efficacite == 0)
                efficacite = 1;
            else if (efficacite == -2)
                efficacite = 0.50;
            else if (efficacite == -4)
                efficacite = 0.25;
            else if (efficacite > 4)
                efficacite = 0;


            bool stab = cap.TypeAttaque == CurrentPokemon2.Type1 || cap.TypeAttaque == CurrentPokemon2.Type2;

            damagepvmin = GetDamage((double)(NumUDNiveau2.Value), atq, efficacite, def, force, stab, 217.0);
            damagepvmax = GetDamage((double)(NumUDNiveau2.Value), atq, efficacite, def, force, stab, 255.0);

            if (damagepvmin != 0)
                KOmax = (int)Math.Ceiling(PV1 / damagepvmin);
            else
                KOmax = 0;
            if (damagepvmax != 0)
                KOmin = (int)Math.Ceiling(PV1 / damagepvmax);
            else
                KOmin = 0;

            dgpourcentmin = Math.Round(((double)damagepvmin / PV1) * 100, 1);
            dgpourcentmax = Math.Round(((double)damagepvmax / PV1) * 100, 1);
        }

        int GetDamage(double niveau, double attaque, double efficacite, double defense, double puissance, bool stab, double random)
        {
            double N = niveau;
            double A = attaque;
            double E = efficacite;
            double D = defense;
            double F = puissance;
            double S;
            if (stab)
                S = 1.5;
            else
                S = 1;
            double C = 1;
            double R = random;

            return (int)(Math.Truncate(((((2 * N * C / 5 + 2) * A * F / D) / 50 + 2) * S * E * R / 255)));
        }

        private void ComboC21_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature21.Text = "Nature: ";
            lbCapType21.Text = "";
            t21 = Type.AUCUN;

            if (ComboC21.Text != null && ComboC21.Text != "" && ComboC21.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC21.Text);

                lbCapType21.Text = cap.TypeAttaque.ToString();
                lbNature21.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t21 = cap.TypeAttaque;
                else
                    t21 = Type.AUCUN;

                decimal oldval = nPowCap21.Value;
                nPowCap21.Value = (decimal)cap.Force;

                if (oldval == nPowCap21.Value)
                    nPowCap21_ValueChanged(null, null);
            }
            else
            {
                lbKO21.Text = "KO: ";
                lbdgPV21.Text = "Dg PV: ";
                lbdgpourcent21.Text = "Dg %: ";
            }

            CalcEfficacite1(t11, t21, t31, t41);
        }

        private void ComboC31_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature31.Text = "Nature: ";
            lbCapType31.Text = "";
            t31 = Type.AUCUN;

            if (ComboC31.Text != null && ComboC31.Text != "" && ComboC31.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC31.Text);

                lbCapType31.Text = cap.TypeAttaque.ToString();
                lbNature31.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t31 = cap.TypeAttaque;
                else
                    t31 = Type.AUCUN;

                decimal oldval = nPowCap31.Value;
                nPowCap31.Value = (decimal)cap.Force;

                if (oldval == nPowCap31.Value)
                    nPowCap31_ValueChanged(null, null);
            }
            else
            {
                lbKO31.Text = "KO: ";
                lbdgPV31.Text = "Dg PV: ";
                lbdgpourcent31.Text = "Dg %: ";
            }

            CalcEfficacite1(t11, t21, t31, t41);
        }

        private void ComboC41_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature41.Text = "Nature: ";
            lbCapType41.Text = "";
            t41 = Type.AUCUN;

            if (ComboC41.Text != null && ComboC41.Text != "" && ComboC41.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC41.Text);

                lbCapType41.Text = cap.TypeAttaque.ToString();
                lbNature41.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t41 = cap.TypeAttaque;
                else
                    t41 = Type.AUCUN;

                decimal oldval = nPowCap41.Value;
                nPowCap41.Value = (decimal)cap.Force;

                if (oldval == nPowCap41.Value)
                    nPowCap41_ValueChanged(null, null);
            }
            else
            {
                lbKO41.Text = "KO: ";
                lbdgPV41.Text = "Dg PV: ";
                lbdgpourcent41.Text = "Dg %: ";
            }

            CalcEfficacite1(t11, t21, t31, t41);
        }

        private void ComboPoke2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePokemon2();
        }

        private void ComboC12_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature12.Text = "Nature: ";
            lbCapType12.Text = "";
            t12 = Type.AUCUN;

            if (ComboC12.Text != null && ComboC12.Text != "" && ComboC12.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC12.Text);

                lbCapType12.Text = cap.TypeAttaque.ToString();
                lbNature12.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t12 = cap.TypeAttaque;
                else
                    t12 = Type.AUCUN;

                decimal oldval = nPowCap12.Value;
                nPowCap12.Value = (decimal)cap.Force;

                if (oldval == nPowCap12.Value)
                    nPowCap12_ValueChanged(null, null);
            }
            else
            {
                lbKO12.Text = "KO: ";
                lbdgPV12.Text = "Dg PV: ";
                lbdgpourcent12.Text = "Dg %: ";
            }

            CalcEfficacite2(t12, t22, t32, t42);
        }

        private void ComboC22_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature22.Text = "Nature: ";
            lbCapType22.Text = "";
            t22 = Type.AUCUN;

            if (ComboC22.Text != null && ComboC22.Text != "" && ComboC22.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC22.Text);

                lbCapType22.Text = cap.TypeAttaque.ToString();
                lbNature22.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t22 = cap.TypeAttaque;
                else
                    t22 = Type.AUCUN;

                decimal oldval = nPowCap22.Value;
                nPowCap22.Value = (decimal)cap.Force;

                if (oldval == nPowCap22.Value)
                    nPowCap22_ValueChanged(null, null);
            }
            else
            {
                lbKO22.Text = "KO: ";
                lbdgPV22.Text = "Dg PV: ";
                lbdgpourcent22.Text = "Dg %: ";
            }

            CalcEfficacite2(t12, t22, t32, t42);
        }

        private void ComboC32_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature32.Text = "Nature: ";
            lbCapType32.Text = "";
            t32 = Type.AUCUN;

            if (ComboC32.Text != null && ComboC32.Text != "" && ComboC32.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC32.Text);

                lbCapType32.Text = cap.TypeAttaque.ToString();
                lbNature32.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t32 = cap.TypeAttaque;
                else
                    t32 = Type.AUCUN;

                decimal oldval = nPowCap32.Value;
                nPowCap32.Value = (decimal)cap.Force;

                if (oldval == nPowCap32.Value)
                    nPowCap32_ValueChanged(null, null);
            }
            else
            {
                lbKO32.Text = "KO: ";
                lbdgPV32.Text = "Dg PV: ";
                lbdgpourcent32.Text = "Dg %: ";
            }

            CalcEfficacite2(t12, t22, t32, t42);
        }

        private void ComboC42_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNature42.Text = "Nature: ";
            lbCapType42.Text = "";
            t42 = Type.AUCUN;

            if (ComboC42.Text != null && ComboC42.Text != "" && ComboC42.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC42.Text);

                lbCapType42.Text = cap.TypeAttaque.ToString();
                lbNature42.Text = "Nature: " + cap.NatureDegat.ToString();

                if (cap.NatureDegat != NatureDegat.Aucun && cap.NatureDegat != NatureDegat.NULL)
                    t42 = cap.TypeAttaque;
                else
                    t42 = Type.AUCUN;

                decimal oldval = nPowCap42.Value;
                nPowCap42.Value = (decimal)cap.Force;

                if (oldval == nPowCap42.Value)
                    nPowCap42_ValueChanged(null, null);
            }
            else
            {
                lbKO42.Text = "KO: ";
                lbdgPV42.Text = "Dg PV: ";
                lbdgpourcent42.Text = "Dg %: ";
            }

            CalcEfficacite2(t12, t22, t32, t42);
        }

        private void NumUDNiveau2_ValueChanged(object sender, EventArgs e)
        {
            CalcStatsPoke2();
        }

        private void nPowCap11_ValueChanged(object sender, EventArgs e)
        {
            lbKO11.Text = "KO: ";
            lbdgPV11.Text = "Dg PV: ";
            lbdgpourcent11.Text = "Dg %: ";

            if (CurrentPokemon2 == null)
                return;

            if (ComboC11.Text != null && ComboC11.Text != "" && ComboC11.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC11.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite1(cap, (double)nPowCap11.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO11.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV11.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent11.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap21_ValueChanged(object sender, EventArgs e)
        {

            lbKO21.Text = "KO: ";
            lbdgPV21.Text = "Dg PV: ";
            lbdgpourcent21.Text = "Dg %: ";

            if (CurrentPokemon2 == null)
                return;

            if (ComboC21.Text != null && ComboC21.Text != "" && ComboC21.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC21.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite1(cap, (double)nPowCap21.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO21.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV21.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent21.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap31_ValueChanged(object sender, EventArgs e)
        {

            lbKO31.Text = "KO: ";
            lbdgPV31.Text = "Dg PV: ";
            lbdgpourcent31.Text = "Dg %: ";

            if (CurrentPokemon2 == null)
                return;

            if (ComboC31.Text != null && ComboC31.Text != "" && ComboC31.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC31.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite1(cap, (double)nPowCap31.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO31.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV31.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent31.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap41_ValueChanged(object sender, EventArgs e)
        {
            lbKO41.Text = "KO: ";
            lbdgPV41.Text = "Dg PV: ";
            lbdgpourcent41.Text = "Dg %: ";

            if (CurrentPokemon2 == null)
                return;

            if (ComboC41.Text != null && ComboC41.Text != "" && ComboC41.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC41.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite1(cap, (double)nPowCap41.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO41.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV41.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent41.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap12_ValueChanged(object sender, EventArgs e)
        {
            lbKO12.Text = "KO: ";
            lbdgPV12.Text = "Dg PV: ";
            lbdgpourcent12.Text = "Dg %: ";

            if (CurrentPokemon1 == null)
                return;

            if (ComboC12.Text != null && ComboC12.Text != "" && ComboC12.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC12.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite2(cap, (double)nPowCap12.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO12.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV12.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent12.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap22_ValueChanged(object sender, EventArgs e)
        {
            lbKO22.Text = "KO: ";
            lbdgPV22.Text = "Dg PV: ";
            lbdgpourcent22.Text = "Dg %: ";

            if (CurrentPokemon1 == null)
                return;

            if (ComboC22.Text != null && ComboC22.Text != "" && ComboC22.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC22.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite2(cap, (double)nPowCap22.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO22.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV22.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent22.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap32_ValueChanged(object sender, EventArgs e)
        {
            lbKO32.Text = "KO: ";
            lbdgPV32.Text = "Dg PV: ";
            lbdgpourcent32.Text = "Dg %: ";

            if (CurrentPokemon1 == null)
                return;

            if (ComboC32.Text != null && ComboC32.Text != "" && ComboC32.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC32.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite2(cap, (double)nPowCap32.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO32.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV32.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent32.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void nPowCap42_ValueChanged(object sender, EventArgs e)
        {
            lbKO42.Text = "KO: ";
            lbdgPV42.Text = "Dg PV: ";
            lbdgpourcent42.Text = "Dg %: ";

            if (CurrentPokemon1 == null)
                return;

            if (ComboC42.Text != null && ComboC42.Text != "" && ComboC42.Text != "(vide)")
            {
                Capacite cap = Xblood.GetCapacite(ComboC42.Text);

                if (cap.NatureDegat == NatureDegat.Aucun || cap.NatureDegat == NatureDegat.NULL)
                    return;

                int damagepvmin;
                int damagepvmax;
                int KOmax;
                int KOmin;
                double dgpourcentmin;
                double dgpourcentmax;

                GetOutPutCapacite2(cap, (double)nPowCap42.Value, out damagepvmin, out damagepvmax, out KOmax, out KOmin, out dgpourcentmin, out dgpourcentmax);

                lbKO42.Text = "KO: {" + KOmin.ToString() + ", " + KOmax.ToString() + "}";
                lbdgPV42.Text = "Dg PV: {" + damagepvmin.ToString() + ", " + damagepvmax.ToString() + "}";
                lbdgpourcent42.Text = "Dg %: {" + dgpourcentmin.ToString() + ", " + dgpourcentmax.ToString() + "}";
            }
        }

        private void Ouvrir1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                XmlDocument dom = new XmlDocument();
                dom.Load(openFileDialog1.FileName);
                XmlElement root = dom.DocumentElement;

                Directory.SetCurrentDirectory(Xblood.CurrentDirectory);

                XmlElement DV = null;
                XmlElement PE = null;
                XmlElement Cap = null;

                foreach (XmlElement el in root)
                {
                    switch (el.Name)
                    {
                        case "CAPACITES":
                            Cap = el;
                            break;
                        case "PE":
                            PE = el;
                            break;
                        case "DV":
                            DV = el;
                            break;
                        default:
                            break;
                    }
                }

                if (root.Attributes["espece"].Value != "")
                    ComboPoke1.SelectedItem = root.Attributes["espece"].Value;
                else
                {
                    MessageBox.Show("Pas d'espèce dans cette fiche!");
                    return;
                }


                if (root.Attributes["nature"].Value != "")
                {
                    for (int i = 0; i < NatureNomsPur.Length; i++)
                    {
                        if(NatureNomsPur[i] == root.Attributes["nature"].Value)
                            ComboNature1.SelectedItem = NatureNoms[i];
                    }
                    
                }

                decimal niveau = Convert.ToDecimal(root.Attributes["niveau"].Value);
                if (niveau == 0m)
                    niveau = 1;
                NumUDNiveau1.Value = niveau;

                try
                {
                    string str = Cap.Attributes["nom1"].Value;
                    if (str != "")
                        ComboC11.SelectedItem = str;
                    else
                        ComboC11.SelectedItem = "(vide)";
                }
                catch { ComboC11.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom2"].Value;
                    if (str != "")
                        ComboC21.SelectedItem = str;
                    else
                        ComboC21.SelectedItem = "(vide)";
                }
                catch { ComboC21.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom3"].Value;
                    if (str != "")
                        ComboC31.SelectedItem = str;
                    else
                        ComboC31.SelectedItem = "(vide)";
                }
                catch { ComboC31.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom4"].Value;
                    if (str != "")
                        ComboC41.SelectedItem = str;
                    else
                        ComboC41.SelectedItem = "(vide)";
                }
                catch { ComboC41.SelectedItem = "(vide)"; }

                if (DV.Attributes["pv"].Value != "-1")
                    NumDVPV1.Value = Convert.ToDecimal(DV.Attributes["pv"].Value);
                else
                    NumDVPV1.Value = 0m;
                if (DV.Attributes["a"].Value != "-1")
                    NumDVA1.Value = Convert.ToDecimal(DV.Attributes["a"].Value);
                else
                    NumDVA1.Value = 0m;
                if (DV.Attributes["d"].Value != "-1")
                    NumDVD1.Value = Convert.ToDecimal(DV.Attributes["d"].Value);
                else
                    NumDVD1.Value = 0m;
                if (DV.Attributes["as"].Value != "-1")
                    NumDVAS1.Value = Convert.ToDecimal(DV.Attributes["as"].Value);
                else
                    NumDVAS1.Value = 0m;
                if (DV.Attributes["ds"].Value != "-1")
                    NumDVDS1.Value = Convert.ToDecimal(DV.Attributes["ds"].Value);
                else
                    NumDVDS1.Value = 0m;
                if (DV.Attributes["v"].Value != "-1")
                    NumDVV1.Value = Convert.ToDecimal(DV.Attributes["v"].Value);
                else
                    NumDVV1.Value = 0m;

                NumUDPV1.Value = Convert.ToDecimal(PE.Attributes["pv"].Value);
                NumUDAttaque1.Value = Convert.ToDecimal(PE.Attributes["a"].Value);
                NumUDDéfense1.Value = Convert.ToDecimal(PE.Attributes["d"].Value);
                NumUDAS1.Value = Convert.ToDecimal(PE.Attributes["as"].Value);
                NumUDDS1.Value = Convert.ToDecimal(PE.Attributes["ds"].Value);
                NumUDVitesse1.Value = Convert.ToDecimal(PE.Attributes["v"].Value);
            }
        }

        private void Ouvrir2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                XmlDocument dom = new XmlDocument();
                dom.Load(openFileDialog1.FileName);
                XmlElement root = dom.DocumentElement;

                Directory.SetCurrentDirectory(Xblood.CurrentDirectory);

                XmlElement DV = null;
                XmlElement PE = null;
                XmlElement Cap = null;

                foreach (XmlElement el in root)
                {
                    switch (el.Name)
                    {
                        case "CAPACITES":
                            Cap = el;
                            break;
                        case "PE":
                            PE = el;
                            break;
                        case "DV":
                            DV = el;
                            break;
                        default:
                            break;
                    }
                }

                if (root.Attributes["espece"].Value != "")
                    ComboPoke2.SelectedItem = root.Attributes["espece"].Value;
                else
                {
                    MessageBox.Show("Pas d'espèce dans cette fiche!");
                    return;
                }

                if (root.Attributes["nature"].Value != "")
                {
                    for (int i = 0; i < NatureNomsPur.Length; i++)
                    {
                        if (NatureNomsPur[i] == root.Attributes["nature"].Value)
                            ComboNature2.SelectedItem = NatureNoms[i];
                    }
                }

                decimal niveau = Convert.ToDecimal(root.Attributes["niveau"].Value);
                if (niveau == 0m)
                    niveau = 1;
                NumUDNiveau2.Value = niveau;

                try
                {
                    string str = Cap.Attributes["nom1"].Value;
                    if (str != "")
                        ComboC12.SelectedItem = str;
                    else
                        ComboC12.SelectedItem = "(vide)";
                }
                catch { ComboC12.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom2"].Value;
                    if (str != "")
                        ComboC22.SelectedItem = str;
                    else
                        ComboC22.SelectedItem = "(vide)";
                }
                catch { ComboC22.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom3"].Value;
                    if (str != "")
                        ComboC32.SelectedItem = str;
                    else
                        ComboC32.SelectedItem = "(vide)";
                }
                catch { ComboC32.SelectedItem = "(vide)"; }
                try
                {
                    string str = Cap.Attributes["nom4"].Value;
                    if (str != "")
                        ComboC42.SelectedItem = str;
                    else
                        ComboC42.SelectedItem = "(vide)";
                }
                catch { ComboC42.SelectedItem = "(vide)"; }

                if (DV.Attributes["pv"].Value != "-1")
                    NumDVPV2.Value = Convert.ToDecimal(DV.Attributes["pv"].Value);
                else
                    NumDVPV2.Value = 0m;
                if (DV.Attributes["a"].Value != "-1")
                    NumDVA2.Value = Convert.ToDecimal(DV.Attributes["a"].Value);
                else
                    NumDVA2.Value = 0m;
                if (DV.Attributes["d"].Value != "-1")
                    NumDVD2.Value = Convert.ToDecimal(DV.Attributes["d"].Value);
                else
                    NumDVD2.Value = 0m;
                if (DV.Attributes["as"].Value != "-1")
                    NumDVAS2.Value = Convert.ToDecimal(DV.Attributes["as"].Value);
                else
                    NumDVAS2.Value = 0m;
                if (DV.Attributes["ds"].Value != "-1")
                    NumDVDS2.Value = Convert.ToDecimal(DV.Attributes["ds"].Value);
                else
                    NumDVDS2.Value = 0m;
                if (DV.Attributes["v"].Value != "-1")
                    NumDVV2.Value = Convert.ToDecimal(DV.Attributes["v"].Value);
                else
                    NumDVV2.Value = 0m;

                NumUDPV2.Value = Convert.ToDecimal(PE.Attributes["pv"].Value);
                NumUDAttaque2.Value = Convert.ToDecimal(PE.Attributes["a"].Value);
                NumUDDéfense2.Value = Convert.ToDecimal(PE.Attributes["d"].Value);
                NumUDAS2.Value = Convert.ToDecimal(PE.Attributes["as"].Value);
                NumUDDS2.Value = Convert.ToDecimal(PE.Attributes["ds"].Value);
                NumUDVitesse2.Value = Convert.ToDecimal(PE.Attributes["v"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTypeGrid f = new FormTypeGrid();
            f.SetGrid(t11, t21, t31, t41);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormTypeGrid f = new FormTypeGrid();
            f.SetGrid(t12, t22, t32, t42);
            f.Show();
        }
    }
}