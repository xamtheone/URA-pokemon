using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormDVFinder : Form
    {
        string[] NatureNoms = new string[25];
        double[][] NatureValeurs = new double[25][];
        bool Première = true;
        int CurrentLevel;
        Pokemon CurrentPokemon;
        Xblood xb;

        int minPV = 0;
        int maxPV = 31;
        int minA = 0;
        int maxA = 31;
        int minD = 0;
        int maxD = 31;
        int minAS = 0;
        int maxAS = 31;
        int minDS = 0;
        int maxDS = 31;
        int minV = 0;
        int maxV = 31;

        double PV;
        double A;
        double D;
        double AS;
        double DS;
        double V;

        ArrayList Mémoire = new ArrayList();
        int indexMémoire = -1;
        bool précédant = false;


        public FormDVFinder()
        {
            InitializeComponent();
        }

        void Nouveau()
        {
            ComboPokémon.Text = "";
            ComboNature.Text = "";
            txtAS.Text = "";
            txtAttaque.Text = "";
            txtDéfense.Text = "";
            txtDS.Text = "";
            txtPV.Text = "";
            txtVitesse.Text = "";

            lbAS.Text = "AS: ";
            lbAttaque.Text = "Attaque: ";
            lbDéfense.Text = "Défense: ";
            lbDS.Text = "DS: ";
            lbNiveauEnAttente.Text = "Niveau en attente: ";
            lbPV.Text = "PV: ";
            lbVitesse.Text = "Vitesse: ";

            NumUDNiveau.Value = 1;

            minPV = 0;
            maxPV = 31;
            minA = 0;
            maxA = 31;
            minD = 0;
            maxD = 31;
            minAS = 0;
            maxAS = 31;
            minDS = 0;
            maxDS = 31;
            minV = 0;
            maxV = 31;

            Première = true;
            Mémoire = new ArrayList();
            indexMémoire = -1;
        }

        void FillComboPokémon()
        {
            ComboPokémon.Text = "";
            ComboPokémon.Items.Clear();
            foreach (Pokemon p in xb.PKlist)
                ComboPokémon.Items.Add(p.Nom);
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

            foreach (string str in NatureNoms)
                ComboNature.Items.Add(str);
        }

        int GetNextLevel()
        {
            double[] Nature = new double[] { 1, 1, 1, 1, 1 };
            try
            {
                if (ComboNature.Text != "")
                    Nature = NatureValeurs[ComboNature.SelectedIndex];
            }
            catch { }

            for (int l = CurrentLevel + 1; l <= 100; l++)
            {
                for (int dv = minPV; dv <= maxPV && PV != 0; dv++)
                {
                    double pv1 = Math.Truncate((2 * CurrentPokemon.Stat_PV + dv) * l / 100 + 10 + l);
                    double pv2 = Math.Truncate((2 * CurrentPokemon.Stat_PV + minPV) * l / 100 + 10 + l);
                    if (pv1 != pv2)
                        return l;
                }
                for (int dv = minA; dv <= maxA && A != 0; dv++)
                {
                    double a1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Attaque + dv) * l / 100 + 5) * Nature[0]);
                    double a2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Attaque + minA) * l / 100 + 5) * Nature[0]);

                    if (a1 != a2)
                        return l;
                }
                for (int dv = minD; dv <= maxD && D != 0; dv++)
                {
                    double d1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Défense + dv) * l / 100 + 5) * Nature[1]);
                    double d2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Défense + minD) * l / 100 + 5) * Nature[1]);
                    if (d1 != d2)
                        return l;
                }
                for (int dv = minAS; dv <= maxAS && AS != 0; dv++)
                {
                    double as1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_AttaqueSpé + dv) * l / 100 + 5) * Nature[3]);
                    double as2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_AttaqueSpé + minAS) * l / 100 + 5) * Nature[3]);
                    if (as1 != as2)
                        return l;
                }
                for (int dv = minDS; dv <= maxDS && DS != 0; dv++)
                {
                    double ds1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_DéfenseSpé + dv) * l / 100 + 5) * Nature[4]);
                    double ds2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_DéfenseSpé + minDS) * l / 100 + 5) * Nature[4]);
                    if (ds1 != ds2)
                        return l;
                }
                for (int dv = minV; dv <= maxV && V != 0; dv++)
                {
                    double v1 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Vitesse + dv) * l / 100 + 5) * Nature[2]);
                    double v2 = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Vitesse + minV) * l / 100 + 5) * Nature[2]);
                    if (v1 != v2)
                        return l;
                }
            }
            return 0;
        }

        void Calculer()
        {
            if (Première)
            {
                CurrentPokemon = xb.PKlist[ComboPokémon.SelectedIndex];
                Première = false;
            }
            if (précédant)
            {
                Mémoire.RemoveRange(indexMémoire + 1, Mémoire.Count - (indexMémoire + 1));
                //indexMémoire--;
                précédant = false;
            }

            double[] Nature = new double[] { 1, 1, 1, 1, 1 };
            double Niveau;


            try { PV = Convert.ToDouble(txtPV.Text); }
            catch { PV = 0; }
            try { A = Convert.ToDouble(txtAttaque.Text); }
            catch { A = 0; }
            try { D = Convert.ToDouble(txtDéfense.Text); }
            catch { D = 0; }
            try { AS = Convert.ToDouble(txtAS.Text); }
            catch { AS = 0; }
            try { DS = Convert.ToDouble(txtDS.Text); }
            catch { DS = 0; }
            try { V = Convert.ToDouble(txtVitesse.Text); }
            catch { V = 0; }
            try
            {
                if (ComboNature.Text != "")
                    Nature = NatureValeurs[ComboNature.SelectedIndex];
            }
            catch { }

            Niveau = CurrentLevel;

            bool firstPV = true;
            bool firstA = true;
            bool firstD = true;
            bool firstAS = true;
            bool firstDS = true;
            bool firstV = true;

            bool foundPV = false;
            bool foundA = false;
            bool foundD = false;
            bool foundAS = false;
            bool foundDS = false;
            bool foundV = false;

            int mPV = 31;
            int mA = 31;
            int mD = 31;
            int mAS = 31;
            int mDS = 31;
            int mV = 31;

            for (int dv = 0; dv <= 31; dv++)
            {
                //si les pv ont été saisis et que le dv n'a pas été trouvé,
                //on calcule
                if (PV != 0 && !foundPV)
                {
                    
                    double pv = PokeMath.StatPV(CurrentPokemon.Stat_PV, dv, 0, Niveau);
                    //si la stat trouvée avec le dv est égal à la stat saisie
                    if (pv == PV)
                    {
                        //si c'est le premier dv qui donne la même stat que celle saisie
                        // et qu'il est suppérieur ou égal au dernier dv minimum trouvé
                        if (firstPV && dv >= minPV)
                        {
                            minPV = dv;
                            firstPV = false;
                        }
                        mPV = dv;
                    }
                    //sinon, si on viend de dépasser la stat saisie
                    else if (!firstPV && mPV < maxPV)
                        maxPV = mPV;
                }

                if (A != 0 && !foundA)
                {
                    //double a = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Attaque + dv) * Niveau / 100 + 5) * Nature[0]);
                    double a = PokeMath.Stat(CurrentPokemon.Stat_Attaque, dv, 0, Niveau, Nature[0]);
                    if (a == A)
                    {
                        if (firstA && dv >= minA)
                        {
                            minA = dv;
                            firstA = false;
                        }
                        mA = dv;
                    }
                    else if (!firstA && mA < maxA)
                        maxA = mA;
                }

                if (D != 0 && !foundD)
                {
                    //double d = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Défense + dv) * Niveau / 100 + 5) * Nature[1]);
                    double d = PokeMath.Stat(CurrentPokemon.Stat_Défense, dv, 0, Niveau, Nature[1]);
                    if (d == D)
                    {
                        if (firstD && dv >= minD)
                        {
                            minD = dv;
                            firstD = false;
                        }
                        mD = dv;
                    }
                    else if (!firstD && mD < maxD)
                        maxD = mD;
                }

                if (AS != 0 && !foundAS)
                {
                    //double a = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_AttaqueSpé + dv) * Niveau / 100 + 5) * Nature[3]);
                    double a = PokeMath.Stat(CurrentPokemon.Stat_AttaqueSpé, dv, 0, Niveau, Nature[3]);
                    if (a == AS)
                    {
                        if (firstAS && dv >= minAS)
                        {
                            minAS = dv;
                            firstAS = false;
                        }
                        mAS = dv;
                    }
                    else if (!firstAS && mAS < maxAS)
                        maxAS = mAS;
                }

                if (DS != 0 && !foundDS)
                {
                    //double ds = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_DéfenseSpé + dv) * Niveau / 100 + 5) * Nature[4]);
                    double ds = PokeMath.Stat(CurrentPokemon.Stat_DéfenseSpé, dv, 0, Niveau, Nature[4]);
                    if (ds == DS)
                    {
                        if (firstDS && dv >= minDS)
                        {
                            minDS = dv;
                            firstDS = false;
                        }
                        mDS = dv;
                    }
                    else if (!firstDS && mDS < maxDS)
                        maxDS = mDS;
                }

                if (V != 0 && !foundV)
                {
                    //double v = Math.Truncate(Math.Truncate((2 * CurrentPokemon.Stat_Vitesse + dv) * Niveau / 100 + 5) * Nature[2]);
                    double v = PokeMath.Stat(CurrentPokemon.Stat_Vitesse, dv, 0, Niveau, Nature[2]);
                    if (v == V)
                    {
                        if (firstV && dv >= minV)
                        {
                            minV = dv;
                            firstV = false;
                        }
                        mV = dv;
                    }
                    else if (!firstV && mV < maxV)
                        maxV = mV;
                }
            } // end for

            if (minPV == maxPV && !foundPV)
                foundPV = true;
            if (minA == maxA && !foundA)
                foundA = true;
            if (minD == maxD && !foundD)
                foundD = true;
            if (minAS == maxAS && !foundAS)
                foundAS = true;
            if (minDS == maxDS && !foundDS)
                foundDS = true;
            if (minV == maxV && !foundV)
                foundV = true;

            AfficheResultats();

            Niveau = GetNextLevel();
            CurrentLevel = (int)Niveau;

            if (Niveau == 0)
                lbNiveauEnAttente.Text = "Fini!";
            else
                lbNiveauEnAttente.Text = "Niveau en attente: " + Niveau;

            int[] m = new int[]
            {
                minPV,
                maxPV,
                minA,
                maxA,
                minD,
                maxD,
                minAS,
                maxAS,
                minDS,
                maxDS,
                minV,
                maxV,
                (int)Niveau
            };

            Mémoire.Add(m);
            indexMémoire = Mémoire.Count - 1;
        }

        void AfficheResultats()
        {
            if (PV != 0)
            {
                if (minPV != maxPV)
                    lbPV.Text = "PV: " + minPV + " à " + maxPV;
                else
                    lbPV.Text = "PV: " + minPV;
            }
            if (A != 0)
            {
                if (minA != maxA)
                    lbAttaque.Text = "Attaque: " + minA + " à " + maxA;
                else
                    lbAttaque.Text = "Attaque: " + minA;
            }
            if (D != 0)
            {
                if (minD != maxD)
                    lbDéfense.Text = "Défense: " + minD + " à " + maxD;
                else
                    lbDéfense.Text = "Défense: " + minD;
            }
            if (AS != 0)
            {
                if (minAS != maxAS)
                    lbAS.Text = "AS: " + minAS + " à " + maxAS;
                else
                    lbAS.Text = "AS: " + minAS.ToString();
            }
            if (DS != 0)
            {
                if (minDS != maxDS)
                    lbDS.Text = "DS: " + minDS + " à " + maxDS;
                else
                    lbDS.Text = "DS: " + minDS;
            }
            if (V != 0)
            {
                if (minV != maxV)
                    lbVitesse.Text = "Vitesse: " + minV + " à " + maxV;
                else
                    lbVitesse.Text = "Vitesse: " + minV;
            }
        }

        private void FormDVFinder_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPokémon();
            FillComboNature();
        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            if (ComboPokémon.Text != "")
            {
                if (Première)
                    CurrentLevel = (int)NumUDNiveau.Value;
                Calculer();
            }
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            Nouveau();
        }

        private void btPrécédent_Click(object sender, EventArgs e)
        {
            if (Mémoire.Count > 0)
            {
                précédant = true;

                if (indexMémoire - 1 != -1)
                    indexMémoire--;

                int[] tab = (int[])Mémoire[indexMémoire];

                minPV = tab[0];
                maxPV = tab[1];
                minA = tab[2];
                maxA = tab[3];
                minD = tab[4];
                maxD = tab[5];
                minAS = tab[6];
                maxAS = tab[7];
                minDS = tab[8];
                maxDS = tab[9];
                minV = tab[10];
                maxV = tab[11];
                CurrentLevel = tab[12];

                lbNiveauEnAttente.Text = "Niveau en attente: " + CurrentLevel;

                AfficheResultats();
            }
        }

        private void txtPV_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtPV.Text); }
            catch { txtPV.Text = ""; }
        }

        private void txtAttaque_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtAttaque.Text); }
            catch { txtAttaque.Text = ""; }
        }

        private void txtDéfense_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtDéfense.Text); }
            catch { txtDéfense.Text = ""; }
        }

        private void txtAS_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtAS.Text); }
            catch { txtAS.Text = ""; }
        }

        private void txtDS_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtDS.Text); }
            catch { txtDS.Text = ""; }
        }

        private void txtVitesse_Leave(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(txtVitesse.Text); }
            catch { txtVitesse.Text = ""; }
        }

        private void txtPV_Enter(object sender, EventArgs e)
        {
            txtPV.SelectAll();
        }

        private void txtAttaque_Enter(object sender, EventArgs e)
        {
            txtAttaque.SelectAll();
        }

        private void txtDéfense_Enter(object sender, EventArgs e)
        {
            txtDéfense.SelectAll();
        }

        private void txtAS_Enter(object sender, EventArgs e)
        {
            txtAS.SelectAll();
        }

        private void txtDS_Enter(object sender, EventArgs e)
        {
            txtDS.SelectAll();
        }

        private void txtVitesse_Enter(object sender, EventArgs e)
        {
            txtVitesse.SelectAll();
        }
    }
}