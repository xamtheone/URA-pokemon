using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormEquipe : Form
    {
        Pokemon poke1;
        Pokemon poke2;
        Pokemon poke3;
        Pokemon poke4;
        Pokemon poke5;
        Pokemon poke6;

        Equipe equipe;

        int NumSelected = 1;

        Pokemon CurrentPokemon;
        string[] Fichetab = new string[6];

        Xblood xb;

        public FormEquipe()
        {
            InitializeComponent();

        }

        void FillComboPokemon()
        {
            ComboPoke.Text = "";
            ComboPoke.Items.Clear();

            ComboPoke.Items.Add("(vide)");
            foreach (Pokemon p in xb.PKlist)
            {
                ComboPoke.Items.Add(p.Nom);
            }
        }

        private void evaluerLéquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stack<Pokemon> stp = new Stack<Pokemon>();
            if (poke1 != null)
                stp.Push(poke1);
            if (poke2 != null)
                stp.Push(poke2);
            if (poke3 != null)
                stp.Push(poke3);
            if (poke4 != null)
                stp.Push(poke4);
            if (poke5 != null)
                stp.Push(poke5);
            if (poke6 != null)
                stp.Push(poke6);

            FormEvalPoke f = new FormEvalPoke(stp);
            f.Show();


        }

        void SetFiche(string path, int numpoke)
        {
            Fichetab[numpoke - 1] = path;
        }
        //stocke un pokémon selon sa place approprié
        void SetSelectedPokemonTo(Pokemon poke)
        {
            if (rbPoke1.Checked)
            {
                poke1 = poke;
                if (poke != null)
                    rbPoke1.Text = poke.Nom;
                else
                    rbPoke1.Text = "(aucun)";
            }
            else if (rbPoke2.Checked)
            {
                poke2 = poke;
                if (poke != null)
                    rbPoke2.Text = poke.Nom;
                else
                    rbPoke2.Text = "(aucun)";
            }
            else if (rbPoke3.Checked)
            {
                poke3 = poke;
                if (poke != null)
                    rbPoke3.Text = poke.Nom;
                else
                    rbPoke3.Text = "(aucun)";
            }
            else if (rbPoke4.Checked)
            {
                poke4 = poke;
                if (poke != null)
                    rbPoke4.Text = poke.Nom;
                else
                    rbPoke4.Text = "(aucun)";
            }
            else if (rbPoke5.Checked)
            {
                poke5 = poke;
                if (poke != null)
                    rbPoke5.Text = poke.Nom;
                else
                    rbPoke5.Text = "(aucun)";
            }
            else if (rbPoke6.Checked)
            {
                poke6 = poke;
                if (poke != null)
                    rbPoke6.Text = poke.Nom;
                else
                    rbPoke6.Text = "(aucun)";
            }
        }

        //charge un pokémon dans l'affichage réservé
        void ChangeSelectedPokemon(Pokemon poke)
        {

            CurrentPokemon = poke;

            ComboC1.Items.Clear();
            ComboC2.Items.Clear();
            ComboC3.Items.Clear();
            ComboC4.Items.Clear();

            ComboC1.Items.Add("(vide)");
            ComboC2.Items.Add("(vide)");
            ComboC3.Items.Add("(vide)");
            ComboC4.Items.Add("(vide)");

            ComboCapaciteSpe.Items.Clear();

            if (poke != null)
            {
                if (!string.IsNullOrEmpty(poke.Pseudo))
                    lbSurnom1.Text = poke.Pseudo;
                else
                    lbSurnom1.Text = poke.Nom;

                switch (NumSelected)
                {
                    case 1:
                        mitemPK1.Text = poke.Nom;
                        break;
                    case 2:
                        mitemPK2.Text = poke.Nom;
                        break;
                    case 3:
                        mitemPK3.Text = poke.Nom;
                        break;
                    case 4:
                        mitemPK4.Text = poke.Nom;
                        break;
                    case 5:
                        mitemPK5.Text = poke.Nom;
                        break;
                    case 6:
                        mitemPK6.Text = poke.Nom;
                        break;
                    default:
                        break;
                }

                ComboPoke.SelectedIndexChanged -= new EventHandler(ComboPokémon_SelectedIndexChanged);
                ComboPoke.SelectedItem = poke.Nom;
                ComboPoke.SelectedIndexChanged += new EventHandler(ComboPokémon_SelectedIndexChanged);



                Capacite[] cap = Xblood.ListofMoves(poke);
                foreach (Capacite c in cap)
                {
                    ComboC1.Items.Add(c.Nom);
                    ComboC2.Items.Add(c.Nom);
                    ComboC3.Items.Add(c.Nom);
                    ComboC4.Items.Add(c.Nom);
                }

                ComboC1.SelectedIndexChanged -= new EventHandler(ComboC1_SelectedIndexChanged);
                ComboC2.SelectedIndexChanged -= new EventHandler(ComboC2_SelectedIndexChanged);
                ComboC3.SelectedIndexChanged -= new EventHandler(ComboC3_SelectedIndexChanged);
                ComboC4.SelectedIndexChanged -= new EventHandler(ComboC4_SelectedIndexChanged);
                if (poke.Capacités_fiche[0] != null)
                    ComboC1.SelectedItem = poke.Capacités_fiche[0].Nom;
                else
                    ComboC1.SelectedIndex = 0;
                if (poke.Capacités_fiche[1] != null)
                    ComboC2.SelectedItem = poke.Capacités_fiche[1].Nom;
                else
                    ComboC2.SelectedIndex = 0;
                if (poke.Capacités_fiche[2] != null)
                    ComboC3.SelectedItem = poke.Capacités_fiche[2].Nom;
                else
                    ComboC3.SelectedIndex = 0;
                if (poke.Capacités_fiche[3] != null)
                    ComboC4.SelectedItem = poke.Capacités_fiche[3].Nom;
                else
                    ComboC4.SelectedIndex = 0;

                ComboC1.SelectedIndexChanged += new EventHandler(ComboC1_SelectedIndexChanged);
                ComboC2.SelectedIndexChanged += new EventHandler(ComboC2_SelectedIndexChanged);
                ComboC3.SelectedIndexChanged += new EventHandler(ComboC3_SelectedIndexChanged);
                ComboC4.SelectedIndexChanged += new EventHandler(ComboC4_SelectedIndexChanged);

                foreach (string cs in poke.CapacitésSpé)
                {
                    if (cs != null)
                        ComboCapaciteSpe.Items.Add(cs);
                }

                ComboCapaciteSpe.SelectedIndexChanged -= new EventHandler(ComboCapaciteSpe_SelectedIndexChanged);

                ComboCapaciteSpe.SelectedItem = poke.CapacitéSpé;

                ComboCapaciteSpe.SelectedIndexChanged += new EventHandler(ComboCapaciteSpe_SelectedIndexChanged);

                lbType11.Text = poke.Type1.ToString();
                if (poke.Type2 != Type.AUCUN)
                    lbType21.Text = poke.Type2.ToString();
                else
                    lbType21.Text = "";

                gbMovesetCurrent.Text = "Moveset de " + poke.Nom;



            }
            else
            {
                ComboPoke.SelectedIndexChanged -= new EventHandler(ComboPokémon_SelectedIndexChanged);
                ComboPoke.SelectedItem = "(vide)";
                ComboPoke.SelectedIndexChanged += new EventHandler(ComboPokémon_SelectedIndexChanged);

                ComboC1.SelectedIndex = 0;
                ComboC2.SelectedIndex = 0;
                ComboC3.SelectedIndex = 0;
                ComboC4.SelectedIndex = 0;

                switch (NumSelected)
                {
                    case 1:
                        mitemPK1.Text = "(aucun)";
                        break;
                    case 2:
                        mitemPK2.Text = "(aucun)";
                        break;
                    case 3:
                        mitemPK3.Text = "(aucun)";
                        break;
                    case 4:
                        mitemPK4.Text = "(aucun)";
                        break;
                    case 5:
                        mitemPK5.Text = "(aucun)";
                        break;
                    case 6:
                        mitemPK6.Text = "(aucun)";
                        break;
                    default:
                        break;
                }

                gbMovesetCurrent.Text = "Moveset de (vide)";
                lbSurnom1.Text = "";

                SetFiche(null, NumSelected);
            }
            CalcEquipe();
            CalcMoveSet();
            CalcMoveSetSelected(CurrentPokemon);
        }

        void ShowCalcEquipe()
        {
            Queue<Pokemon> QueuePoke = new Queue<Pokemon>();
            if (poke1 != null)
                QueuePoke.Enqueue(poke1);
            if (poke2 != null)
                QueuePoke.Enqueue(poke2);
            if (poke3 != null)
                QueuePoke.Enqueue(poke3);
            if (poke4 != null)
                QueuePoke.Enqueue(poke4);
            if (poke5 != null)
                QueuePoke.Enqueue(poke5);
            if (poke6 != null)
                QueuePoke.Enqueue(poke6);

            FormTabEquipe f = new FormTabEquipe(QueuePoke);
            f.Show();
        }

        void CalcEquipe()
        {
            int nbRes = 0;
            int nbFaib = 0;
            int nbImm = 0;
            int nbNeut = 0;

            //dgvEquipe.Rows.Clear();
            //dgvEquipe.Columns.Clear();
            dgvDetail.Rows.Clear();
            //dgvDetail.Columns.Clear();
            //listBox1.Items.Clear();

            //if (dgvEquipe.Columns.Count == 0)
            //{
            //    int num = dgvEquipe.Columns.Add("ColFaibl", "Faiblesses  ");
            //    DataGridViewColumn col = dgvEquipe.Columns[num];
            //    //col.HeaderText = "Faiblesses  ";
            //    col.SortMode = DataGridViewColumnSortMode.Automatic;
            //    col.Resizable = DataGridViewTriState.False;

            //    num = dgvEquipe.Columns.Add("ColRes", "Résistances  ");
            //    col = dgvEquipe.Columns[num];
            //    //col.HeaderText = "Résistances  ";
            //    col.SortMode = DataGridViewColumnSortMode.Automatic;
            //    col.Resizable = DataGridViewTriState.False;

            //    num = dgvEquipe.Columns.Add("ColNeu", "Neutralités  ");
            //    col = dgvEquipe.Columns[num];
            //    //col.HeaderText = "Neutralités  ";
            //    col.SortMode = DataGridViewColumnSortMode.Automatic;
            //    col.Resizable = DataGridViewTriState.False;

            //    num = dgvEquipe.Columns.Add("ColImm", "Immunités  ");
            //    col = dgvEquipe.Columns[num];
            //    //col.HeaderText = "Immunités  ";
            //    col.SortMode = DataGridViewColumnSortMode.Automatic;
            //    col.Resizable = DataGridViewTriState.False;

            //    num = dgvEquipe.Columns.Add("ColTypes", "Types  ");
            //    col = dgvEquipe.Columns[num];
            //    col.SortMode = DataGridViewColumnSortMode.Automatic;
            //    col.Resizable = DataGridViewTriState.False;
            //}

            //tableau des types contenant le nombre de neutralités/résistances/faiblesses/immunités
            int[,] tabTypeFaiblRes = new int[17, 4];

            //POKEMONS EQUIPE
            if (dgvDetail.Columns.Count == 0)
            {
                int num;
                for (int i = 0; i < 17; i++)
                {
                    num = dgvDetail.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                    DataGridViewColumn col = dgvDetail.Columns[num];
                    col.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
                    col.HeaderText = ((Type)i).ToString();
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                }

                num = dgvDetail.Columns.Add("ColFaible", "Nb Faib.");
                DataGridViewColumn endcol = dgvDetail.Columns[num];
                endcol.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
                endcol.HeaderText = "Nb Faib.";
                endcol.SortMode = DataGridViewColumnSortMode.NotSortable;
                endcol.Resizable = DataGridViewTriState.False;

                num = dgvDetail.Columns.Add("ColFaible", "Nb Neut.");
                endcol = dgvDetail.Columns[num];
                endcol.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
                endcol.HeaderText = "Nb Neut.";
                endcol.SortMode = DataGridViewColumnSortMode.NotSortable;
                endcol.Resizable = DataGridViewTriState.False;

                num = dgvDetail.Columns.Add("ColFaible", "Nb Res.");
                endcol = dgvDetail.Columns[num];
                endcol.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
                endcol.HeaderText = "Nb Res.";
                endcol.SortMode = DataGridViewColumnSortMode.NotSortable;
                endcol.Resizable = DataGridViewTriState.False;

                num = dgvDetail.Columns.Add("ColFaible", "Nb Imm.");
                endcol = dgvDetail.Columns[num];
                endcol.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
                endcol.HeaderText = "Nb Imm.";
                endcol.SortMode = DataGridViewColumnSortMode.NotSortable;
                endcol.Resizable = DataGridViewTriState.False;
            }

            Queue<Pokemon> QueuePoke = new Queue<Pokemon>();
            if (poke1 != null)
                QueuePoke.Enqueue(poke1);
            if (poke2 != null)
                QueuePoke.Enqueue(poke2);
            if (poke3 != null)
                QueuePoke.Enqueue(poke3);
            if (poke4 != null)
                QueuePoke.Enqueue(poke4);
            if (poke5 != null)
                QueuePoke.Enqueue(poke5);
            if (poke6 != null)
                QueuePoke.Enqueue(poke6);

            //On stocke les valeurs de toute l'équipe
            foreach (Pokemon p in QueuePoke)
            {
                int totalimmu = 0;
                int totalneutre = 0;
                int totalfaible = 0;
                int totalres = 0;

                DataGridViewRow r = new DataGridViewRow();
                r.HeaderCell.Value = p.Nom;
                for (int i = 0; i < 17; i++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    /*
                     * 0 = neutre
                     * 1 = résistant
                     * 2 = faible
                     * 3 = immunisé
                    */
                    if (p.TableauFaiblRes[i] == 7)
                    {
                        tabTypeFaiblRes[i, 3]++;
                        cell.Value = "I";
                        cell.Style.BackColor = Color.Purple;
                        totalimmu++;
                    }
                    else if (p.TableauFaiblRes[i] >= 2)
                    {
                        tabTypeFaiblRes[i, 2]++;
                        if (p.TableauFaiblRes[i] > 2)
                            cell.Value = "x4";
                        else
                            cell.Value = "F";

                        cell.Style.BackColor = Color.Red;
                        totalfaible++;
                    }
                    else if (p.TableauFaiblRes[i] == 0)
                    {
                        tabTypeFaiblRes[i, 0]++;
                        //cell.Value = "";
                        totalneutre++;
                    }
                    else if (p.TableauFaiblRes[i] <= -2)
                    {
                        tabTypeFaiblRes[i, 1]++;
                        if (p.TableauFaiblRes[i] < -2)
                            cell.Value = "x4";
                        else
                            cell.Value = "R";
                        cell.Style.BackColor = Color.Yellow;
                        totalres++;
                    }

                    r.Cells.Add(cell);
                }

                DataGridViewTextBoxCell endcell = new DataGridViewTextBoxCell();
                endcell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                endcell.Value = totalfaible;
                r.Cells.Add(endcell);

                endcell = new DataGridViewTextBoxCell();
                endcell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                endcell.Value = totalneutre;
                r.Cells.Add(endcell);

                endcell = new DataGridViewTextBoxCell();
                endcell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                endcell.Value = totalres;
                r.Cells.Add(endcell);

                endcell = new DataGridViewTextBoxCell();
                endcell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                endcell.Value = totalimmu;
                r.Cells.Add(endcell);

                dgvDetail.Rows.Add(r);
            }

            ////TABLEAU FAIBLESSES
            //for (int i = 0; i < 17; i++)
            //{
            //    //int num = dgvEquipe.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
            //    //DataGridViewColumn col = dgvEquipe.Columns[num];
            //    //col.HeaderText = ((Type)i).ToString();
            //    //col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //    //col.Resizable = DataGridViewTriState.False;

            //    DataGridViewRow row = new DataGridViewRow();
            //    row.HeaderCell.Value = ((Type)i).ToString();
            //    for (int j = 0; j < 4; j++)
            //    {
            //        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            //        row.Cells.Add(cell);
            //    }

            //    dgvEquipe.Rows.Add(row);
            //}


            for (int i = 0; i < 17; i++)
            {

                //DataGridViewCell cell = null;
                //faiblesses
                if (tabTypeFaiblRes[i, 2] != 0)
                {
                    //cell = dgvEquipe[0, i];
                    //cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 2]);
                    //cell.Value = tabTypeFaiblRes[i, 2];
                    nbFaib += tabTypeFaiblRes[i, 2];
                    //listBox4.Items.Add(tabTypeFaiblRes[i, 2] + " faiblesse(s) à " + ((Type)i).ToString());
                }
                //résistances
                if (tabTypeFaiblRes[i, 1] != 0)
                {
                    //cell = dgvEquipe[1, i];
                    ////cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 1]);
                    //cell.Value = tabTypeFaiblRes[i, 1];
                    nbRes += tabTypeFaiblRes[i, 1];
                }
                //neutralités
                if (tabTypeFaiblRes[i, 0] != 0)
                {
                    //cell = dgvEquipe[2, i];
                    ////cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 0]);
                    //cell.Value = tabTypeFaiblRes[i, 0];
                    nbNeut += tabTypeFaiblRes[i, 0];
                }
                //immunités
                if (tabTypeFaiblRes[i, 3] != 0)
                {
                    //cell = dgvEquipe[3, i];
                    ////cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 3]);
                    //cell.Value = tabTypeFaiblRes[i, 3];
                    nbImm += tabTypeFaiblRes[i, 3];
                }

                //cell = dgvEquipe[4, i];
                //cell.Value = i + 1;


                //if (tabTypeFaiblRes[i, 1] == 0 && tabTypeFaiblRes[i, 3] == 0)
                //    listBox1.Items.Add("Personne ne résiste à " + ((Type)i).ToString());
            }

            lbFaiblesses.Text = "Faiblesse: " + nbFaib;
            lbResistances.Text = "Résistances: " + nbRes;
            lbNeutralitesTypes.Text = "Neutralités: " + nbNeut;
            lbImmunitesEquipe.Text = "Immunités: " + nbImm;
        }

        void SetTypeFromPokemon(Pokemon poke, out Type t1, out Type t2, out Type t3, out Type t4)
        {

            t1 = Type.AUCUN;
            t2 = Type.AUCUN;
            t3 = Type.AUCUN;
            t4 = Type.AUCUN;
            if (poke != null)
            {
                if (poke.Capacités_fiche[0] != null && poke.Capacités_fiche[0].NatureDegat != NatureDegat.Aucun)
                    t1 = poke.Capacités_fiche[0].TypeAttaque;
                if (poke.Capacités_fiche[1] != null && poke.Capacités_fiche[1].NatureDegat != NatureDegat.Aucun)
                    t2 = poke.Capacités_fiche[1].TypeAttaque;
                if (poke.Capacités_fiche[2] != null && poke.Capacités_fiche[2].NatureDegat != NatureDegat.Aucun)
                    t3 = poke.Capacités_fiche[2].TypeAttaque;
                if (poke.Capacités_fiche[3] != null && poke.Capacités_fiche[3].NatureDegat != NatureDegat.Aucun)
                    t4 = poke.Capacités_fiche[3].TypeAttaque;
            }
        }

        void CalcMoveSet()
        {
            Type t1; Type t2; Type t3; Type t4;
            Type t5; Type t6; Type t7; Type t8;
            Type t9; Type t10; Type t11; Type t12;
            Type t13; Type t14; Type t15; Type t16;
            Type t17; Type t18; Type t19; Type t20;
            Type t21; Type t22; Type t23; Type t24;

            int nbEff = 0;
            int nbNeut = 0;
            int nbInn = 0;
            int nbImm = 0;

            if (Xblood.TypesExistants == null)
                Xblood.FillTypesExistants();


            //dgvMoveSet.Rows.Clear();
            //dgvMoveSet.Columns.Clear();

            SetTypeFromPokemon(poke1, out t1, out t2, out t3, out t4);
            SetTypeFromPokemon(poke2, out t5, out t6, out t7, out t8);
            SetTypeFromPokemon(poke3, out t9, out t10, out t11, out t12);
            SetTypeFromPokemon(poke4, out t13, out t14, out t15, out t16);
            SetTypeFromPokemon(poke5, out t17, out t18, out t19, out t20);
            SetTypeFromPokemon(poke6, out t21, out t22, out t23, out t24);

            int length0 = Xblood.TypesExistants.GetLength(0);
            int length1 = Xblood.TypesExistants.GetLength(1);

            //if (dgvMoveSet.Columns.Count == 0)
            //{
            //    for (int i = 0; i < length1; i++)
            //    {
            //        int num = dgvMoveSet.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
            //        DataGridViewColumn col = dgvMoveSet.Columns[num];
            //        col.HeaderText = ((Type)i).ToString();
            //        col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //        col.Resizable = DataGridViewTriState.False;

            //    }
            //}

            //if (dgvMoveSet.Rows.Count == 0)
            //{
            //    for (int j = 0; j < length0; j++)
            //    {
            //        DataGridViewRow row = new DataGridViewRow();
            //        row.HeaderCell.Value = ((Type)j).ToString();
            //        if (dgvMoveSet.RowTemplate != null)
            //            dgvMoveSet.Rows.Add(row);
            //    }
            //}

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i == j || (!Xblood.TypesExistants[j, i] /*&& !Xblood.TypesExistants[i, j]*/))
                    {
                        //dgvMoveSet[i, j].Style.BackColor = Color.Gray;

                    }
                    else
                    {
                        //dgvMoveSet[i, j].Style.BackColor = Color.White;

                        int eff1 = Efficacite(t1, (Type)i, (Type)j);
                        int eff2 = Efficacite(t2, (Type)i, (Type)j);
                        int eff3 = Efficacite(t3, (Type)i, (Type)j);
                        int eff4 = Efficacite(t4, (Type)i, (Type)j);
                        int eff5 = Efficacite(t5, (Type)i, (Type)j);
                        int eff6 = Efficacite(t6, (Type)i, (Type)j);
                        int eff7 = Efficacite(t7, (Type)i, (Type)j);
                        int eff8 = Efficacite(t8, (Type)i, (Type)j);
                        int eff9 = Efficacite(t9, (Type)i, (Type)j);
                        int eff10 = Efficacite(t10, (Type)i, (Type)j);
                        int eff11 = Efficacite(t11, (Type)i, (Type)j);
                        int eff12 = Efficacite(t12, (Type)i, (Type)j);
                        int eff13 = Efficacite(t13, (Type)i, (Type)j);
                        int eff14 = Efficacite(t14, (Type)i, (Type)j);
                        int eff15 = Efficacite(t15, (Type)i, (Type)j);
                        int eff16 = Efficacite(t16, (Type)i, (Type)j);
                        int eff17 = Efficacite(t17, (Type)i, (Type)j);
                        int eff18 = Efficacite(t18, (Type)i, (Type)j);
                        int eff19 = Efficacite(t19, (Type)i, (Type)j);
                        int eff20 = Efficacite(t20, (Type)i, (Type)j);
                        int eff21 = Efficacite(t21, (Type)i, (Type)j);
                        int eff22 = Efficacite(t22, (Type)i, (Type)j);
                        int eff23 = Efficacite(t23, (Type)i, (Type)j);
                        int eff24 = Efficacite(t24, (Type)i, (Type)j);

                        if (eff1 == 7 && eff2 == 7 && eff3 == 7 && eff4 == 7 && eff5 == 7 && eff6 == 7 && eff7 == 7 && eff8 == 7 && eff9 == 7 && eff10 == 7 && eff11 == 7 && eff12 == 7 && eff13 == 7 && eff14 == 7 && eff15 == 7 && eff16 == 7 && eff17 == 7 && eff18 == 7 && eff19 == 7 && eff20 == 7 && eff21 == 7 && eff22 == 7 && eff23 == 7 && eff24 == 7)
                        {
                            //dgvMoveSet[i, j].Value = "A";
                            nbImm++;
                        }
                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7) || (eff5 >= 2 && eff5 != 7) || (eff6 >= 2 && eff6 != 7) || (eff7 >= 2 && eff7 != 7) || (eff8 >= 2 && eff8 != 7) || (eff9 >= 2 && eff9 != 7) || (eff10 >= 2 && eff10 != 7) || (eff11 >= 2 && eff11 != 7) || (eff12 >= 2 && eff12 != 7) || (eff13 >= 2 && eff13 != 7) || (eff14 >= 2 && eff14 != 7) || (eff15 >= 2 && eff15 != 7) || (eff16 >= 2 && eff16 != 7) || (eff17 >= 2 && eff17 != 7) || (eff18 >= 2 && eff18 != 7) || (eff19 >= 2 && eff19 != 7) || (eff20 >= 2 && eff20 != 7) || (eff21 >= 2 && eff21 != 7) || (eff22 >= 2 && eff22 != 7) || (eff23 >= 2 && eff23 != 7) || (eff24 >= 2 && eff24 != 7))
                        {
                            //dgvMoveSet[i, j].Value = "O";
                            nbEff++;
                        }
                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0 || eff5 == 0 || eff6 == 0 || eff7 == 0 || eff8 == 0 || eff9 == 0 || eff10 == 0 || eff11 == 0 || eff12 == 0 || eff13 == 0 || eff14 == 0 || eff15 == 0 || eff16 == 0 || eff17 == 0 || eff18 == 0 || eff19 == 0 || eff20 == 0 || eff21 == 0 || eff22 == 0 || eff23 == 0 || eff24 == 0)
                        {
                            nbNeut++;
                            //dgvMoveSet[i, j].Value = "";
                        }
                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2 || eff5 <= -2 || eff6 <= -2 || eff7 <= -2 || eff8 <= -2 || eff9 <= -2 || eff10 <= -2 || eff11 <= -2 || eff12 <= -2 || eff13 <= -2 || eff14 <= -2 || eff15 <= -2 || eff16 <= -2 || eff17 <= -2 || eff18 <= -2 || eff19 <= -2 || eff20 <= -2 || eff21 <= -2 || eff22 <= -2 || eff23 <= -2 || eff24 <= -2)
                        {
                            //dgvMoveSet[i, j].Value = "X";
                            nbInn++;
                        }


                    }

                }
            }

            lbEfficacites.Text = "Efficacités: " + nbEff + "/95";
            lbNeutralitesMoveSet.Text = "Neutralités: " + nbNeut + "/95";
            lbInnefficacites.Text = "Innefficacités: " + nbInn + "/95";
            lbimmunitesMoveSet.Text = "Immunités: " + nbImm + "/95";
        }

        void CalcMoveSetSelected(Pokemon poke)
        {
            Type t1; Type t2; Type t3; Type t4;


            int nbEff = 0;
            int nbNeut = 0;
            int nbInn = 0;
            int nbImm = 0;

            if (Xblood.TypesExistants == null)
                Xblood.FillTypesExistants();


            //dgvMoveSet.Rows.Clear();
            //dgvMoveSet.Columns.Clear();

            SetTypeFromPokemon(poke1, out t1, out t2, out t3, out t4);

            int length0 = Xblood.TypesExistants.GetLength(0);
            int length1 = Xblood.TypesExistants.GetLength(1);

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i == j || (!Xblood.TypesExistants[j, i] /*&& !Xblood.TypesExistants[i, j]*/))
                    {

                    }
                    else
                    {

                        int eff1 = Efficacite(t1, (Type)i, (Type)j);
                        int eff2 = Efficacite(t2, (Type)i, (Type)j);
                        int eff3 = Efficacite(t3, (Type)i, (Type)j);
                        int eff4 = Efficacite(t4, (Type)i, (Type)j);

                        if (eff1 == 7 && eff2 == 7 && eff3 == 7 && eff4 == 7)
                            nbImm++;

                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7))
                            nbEff++;

                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0)
                            nbNeut++;

                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2)
                            nbInn++;
                    }

                }
            }

            lbEfficacitesIND.Text = "Efficacités: " + nbEff + "/95";
            lbNeutralitesMoveSetIND.Text = "Neutralités: " + nbNeut + "/95";
            lbInnefficacitesIND.Text = "Innefficacités: " + nbInn + "/95";
            lbimmunitesMoveSetIND.Text = "Immunités: " + nbImm + "/95";
        }

        void ShowCalcMoveSet()
        {
            FormTabMoveSet f = new FormTabMoveSet(poke1, poke2, poke3, poke4, poke5, poke6);
            f.Show();
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

        private void ComboPokémon_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Pokemon poke = xb.GetPokémon(ComboPoke.Text);
            SetFiche(null, NumSelected);
            SetSelectedPokemonTo(poke);
            ChangeSelectedPokemon(poke);
             */
            ChangeCurrentPokemon();
        }

        private void FormEquipe_Load(object sender, EventArgs e)
        {
            xb = new Xblood();
            FillComboPokemon();
        }

        private void rbPoke1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke1.Checked)
            {
                ChangeSelectedPokemon(poke1);
                NumSelected = 1;
            }
        }

        private void rbPoke2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke2.Checked)
            {
                ChangeSelectedPokemon(poke2);
                NumSelected = 2;
            }
        }

        private void rbPoke3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke3.Checked)
            {
                ChangeSelectedPokemon(poke3);
                NumSelected = 3;
            }
        }

        private void rbPoke4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke4.Checked)
            {
                ChangeSelectedPokemon(poke4);
                NumSelected = 4;
            }
        }

        private void rbPoke5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke5.Checked)
            {
                ChangeSelectedPokemon(poke5);
                NumSelected = 5;
            }
        }

        private void rbPoke6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoke6.Checked)
            {
                ChangeSelectedPokemon(poke6);
                NumSelected = 6;
            }
        }

        private void dgvDetail_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvDetail.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), dgvDetail.ColumnHeadersDefaultCellStyle.Font); //e.CellStyle.Font
                if (this.dgvDetail.ColumnHeadersHeight < titleSize.Width)
                    this.dgvDetail.ColumnHeadersHeight = titleSize.Width + 20;

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
        }

        private void ComboC1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboC1.Text != null)
            {
                Capacite cap = Xblood.GetCapacite(ComboC1.Text);
                if (CurrentPokemon != null)
                    CurrentPokemon.Capacités_fiche[0] = cap;

                CalcMoveSetSelected(CurrentPokemon);
                CalcMoveSet();
            }

        }

        private void ComboC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboC2.Text != null)
            {
                Capacite cap = Xblood.GetCapacite(ComboC2.Text);
                if (CurrentPokemon != null)
                    CurrentPokemon.Capacités_fiche[1] = cap;
                CalcMoveSetSelected(CurrentPokemon);
                CalcMoveSet();
            }

        }

        private void ComboC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboC3.Text != null)
            {
                Capacite cap = Xblood.GetCapacite(ComboC3.Text);
                if (CurrentPokemon != null)
                    CurrentPokemon.Capacités_fiche[2] = cap;
                CalcMoveSetSelected(CurrentPokemon);
                CalcMoveSet();
            }
        }

        private void ComboC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboC4.Text != null)
            {
                Capacite cap = Xblood.GetCapacite(ComboC4.Text);
                if (CurrentPokemon != null)
                    CurrentPokemon.Capacités_fiche[3] = cap;
                CalcMoveSetSelected(CurrentPokemon);
                CalcMoveSet();
            }
        }

        bool OuvrirFiche(int pokeNum)
        {
            FormFicheOpen f = new FormFicheOpen();

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Pokemon p = new Pokemon(f.Filename, FileType.Fiche);
                    ChargerPokemon(pokeNum, p, f.Filename);
                }
                catch
                {
                    return false;
                }
            }
            else return false;
            return true;
        }

        private void ChargerPokemon(int pokeNum, Pokemon p, string path)
        {
            if (p != null)
            {
                if (p.Nom != null)
                {
                    SetFiche(path, pokeNum);

                    Pokemon tempoké = xb.GetPokémon(p.Nom);

                    p.Type1 = tempoké.Type1;
                    p.Type2 = tempoké.Type2;

                    p.CapacitésCS = tempoké.CapacitésCS;
                    p.CapacitésCT = tempoké.CapacitésCT;
                    p.CapacitésLevelUp = tempoké.CapacitésLevelUp;
                    p.CapacitésOeuf = tempoké.CapacitésOeuf;
                    p.CapacitésSpé = tempoké.CapacitésSpé;
                    p.CapacitéSpé = tempoké.CapacitéSpé;

                    bool RBchecked = false;
                    switch (pokeNum)
                    {
                        case 1:
                            poke1 = p;
                            rbPoke1.Text = poke1.Nom;
                            mitemPK1.Text = poke1.Nom;
                            RBchecked = rbPoke1.Checked;
                            break;
                        case 2:
                            poke2 = p;
                            rbPoke2.Text = poke2.Nom;
                            mitemPK2.Text = poke2.Nom;
                            RBchecked = rbPoke2.Checked;
                            break;
                        case 3:
                            poke3 = p;
                            rbPoke3.Text = poke3.Nom;
                            mitemPK3.Text = poke3.Nom;
                            RBchecked = rbPoke3.Checked;
                            break;
                        case 4:
                            poke4 = p;
                            rbPoke4.Text = poke4.Nom;
                            mitemPK4.Text = poke4.Nom;
                            RBchecked = rbPoke4.Checked;
                            break;
                        case 5:
                            poke5 = p;
                            rbPoke5.Text = poke5.Nom;
                            mitemPK5.Text = poke5.Nom;
                            RBchecked = rbPoke5.Checked;
                            break;
                        case 6:
                            poke6 = p;
                            rbPoke6.Text = poke6.Nom;
                            mitemPK6.Text = poke6.Nom;
                            RBchecked = rbPoke6.Checked;
                            break;
                    }

                    if (RBchecked)
                        ChangeSelectedPokemon(p);
                    else
                    {
                        CalcEquipe();
                        CalcMoveSet();
                    }
                }
                else
                    MessageBox.Show("Fiche non valide!");
            }
            else
            {
                bool RBchecked = false;

                switch (pokeNum)
                {
                    case 1:
                        poke1 = null;
                        rbPoke1.Text = "(aucun)";
                        mitemPK1.Text = "(aucun)";
                        RBchecked = rbPoke1.Checked;
                        break;
                    case 2:
                        poke2 = null;
                        rbPoke2.Text = "(aucun)";
                        mitemPK2.Text = "(aucun)";
                        RBchecked = rbPoke2.Checked;
                        break;
                    case 3:
                        poke3 = null;
                        rbPoke3.Text = "(aucun)";
                        mitemPK3.Text = "(aucun)";
                        RBchecked = rbPoke3.Checked;
                        break;
                    case 4:
                        poke4 = null;
                        rbPoke4.Text = "(aucun)";
                        mitemPK4.Text = "(aucun)";
                        RBchecked = rbPoke4.Checked;
                        break;
                    case 5:
                        poke5 = null;
                        rbPoke5.Text = "(aucun)";
                        mitemPK5.Text = "(aucun)";
                        RBchecked = rbPoke5.Checked;
                        break;
                    case 6:
                        poke6 = null;
                        rbPoke6.Text = "(aucun)";
                        mitemPK6.Text = "(aucun)";
                        RBchecked = rbPoke6.Checked;
                        break;
                }

                if (RBchecked)
                    ChangeSelectedPokemon(p);
                else
                {
                    CalcEquipe();
                    CalcMoveSet();
                }

            }
        }

        private void OpenFicheCurrent_Click(object sender, EventArgs e)
        {
            OuvrirFiche(NumSelected);
        }

        private void CloseFiche1_Click(object sender, EventArgs e)
        {
            EffacePokemon(Convert.ToInt32(((PictureBox)sender).Tag));
        }
        /*
        private void CloseFiche2_Click(object sender, EventArgs e)
        {
            poke2 = null;
            rbPoke2.Text = "(aucun)";
            mitemPK2.Text = "(aucun)";
            if (rbPoke2.Checked)
                ChangeSelectedPokemon(null);
            else
            {
                SetFiche(null, 2);
                CalcEquipe();
                CalcMoveSet();
            }
        }

        private void CloseFiche3_Click(object sender, EventArgs e)
        {
            poke3 = null;
            rbPoke3.Text = "(aucun)";
            mitemPK3.Text = "(aucun)";
            if (rbPoke3.Checked)
                ChangeSelectedPokemon(null);
            else
            {
                SetFiche(null, 3);
                CalcEquipe();
                CalcMoveSet();
            }
        }

        private void CloseFiche4_Click(object sender, EventArgs e)
        {
            poke4 = null;
            rbPoke4.Text = "(aucun)";
            mitemPK4.Text = "(aucun)";
            if (rbPoke4.Checked)
                ChangeSelectedPokemon(null);
            else
            {
                SetFiche(null, 4);
                CalcEquipe();
                CalcMoveSet();
            }
        }

        private void CloseFiche5_Click(object sender, EventArgs e)
        {
            poke5 = null;
            rbPoke5.Text = "(aucun)";
            mitemPK5.Text = "(aucun)";
            if (rbPoke5.Checked)
                ChangeSelectedPokemon(null);
            else
            {
                SetFiche(null, 5);
                CalcEquipe();
                CalcMoveSet();
            }
        }

        private void CloseFiche6_Click(object sender, EventArgs e)
        {
            poke6 = null;
            rbPoke6.Text = "(aucun)";
            mitemPK6.Text = "(aucun)";
            if (rbPoke6.Checked)
                ChangeSelectedPokemon(null);
            else
            {
                SetFiche(null, 6);
                CalcEquipe();
                CalcMoveSet();
            }
        }
        */

        private void OpenFiche1_Click(object sender, EventArgs e)
        {
            OuvrirFiche(Convert.ToInt32(((PictureBox)sender).Tag));
        }
        /*
        private void OpenFiche2_Click(object sender, EventArgs e)
        {
            OuvrirFiche(2);
        }

        private void OpenFiche3_Click(object sender, EventArgs e)
        {
            OuvrirFiche(3);
        }

        private void OpenFiche4_Click(object sender, EventArgs e)
        {
            OuvrirFiche(4);
        }

        private void OpenFiche5_Click(object sender, EventArgs e)
        {
            OuvrirFiche(5);
        }

        private void OpenFiche6_Click(object sender, EventArgs e)
        {
            OuvrirFiche(6);
        }
        */
        private void CloseFicheCurrent_Click(object sender, EventArgs e)
        {

        }

        private void dossierFicheToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //TODO Regrouper les fiches du dossier concerné par lettre
        }

        private void enregistrerÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEquipe.ShowDialog() == DialogResult.OK)
            {
                equipe = new Equipe();
                
                equipe.PokemonsFiles = Fichetab;
                equipe.Save(sfdEquipe.FileName);
            }
        }

        private void enregistrerÉquipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (equipe == null)
                enregistrerÉquipeToolStripMenuItem_Click(null, null);
            else
            {
                equipe.PokemonsFiles = Fichetab;
                equipe.Save(equipe.file);
            }
        }

        private void ouvrirÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEquipe.ShowDialog() == DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(ofdEquipe.FileName);
                switch (extension)
                {
                    case ".eqp":
                        Equipe eq = null;
                        try
                        {
                            eq = new Equipe();
                            eq.Load(ofdEquipe.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fichier invalide.");
                            return;
                        }

                        equipe = eq;
                        equipe.LoadPokemons();


                        if (equipe.Pokemons[0] != null)
                            ChargerPokemon(1, equipe.Pokemons[0], equipe.PokemonsFiles[0]);
                        else
                            poke1 = null;
                        if (equipe.Pokemons[1] != null)
                            ChargerPokemon(2, equipe.Pokemons[1], equipe.PokemonsFiles[1]);
                        else
                            poke2 = null;
                        if (equipe.Pokemons[2] != null)
                            ChargerPokemon(3, equipe.Pokemons[2], equipe.PokemonsFiles[2]);
                        else
                            poke3 = null;
                        if (equipe.Pokemons[3] != null)
                            ChargerPokemon(4, equipe.Pokemons[3], equipe.PokemonsFiles[3]);
                        else
                            poke4 = null;
                        if (equipe.Pokemons[4] != null)
                            ChargerPokemon(5, equipe.Pokemons[4], equipe.PokemonsFiles[4]);
                        else
                            poke5 = null;
                        if (equipe.Pokemons[5] != null)
                            ChargerPokemon(6, equipe.Pokemons[5], equipe.PokemonsFiles[5]);
                        else
                            poke6 = null;

                        rbPoke1.Checked = true;
                        break;
                    case ".eqx":
                        EquipeExport equipeex = null;
                        try
                        {
                            equipeex = new EquipeExport();
                            equipeex.Load(ofdEquipe.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fichier invalide.");
                            return;
                        }


                        ChargerPokemon(1, equipeex.Pokemons[0], null);
                        ChargerPokemon(2, equipeex.Pokemons[1], null);
                        ChargerPokemon(3, equipeex.Pokemons[2], null);
                        ChargerPokemon(4, equipeex.Pokemons[3], null);
                        ChargerPokemon(5, equipeex.Pokemons[4], null);
                        ChargerPokemon(6, equipeex.Pokemons[5], null);

                        break;
                    default:
                        break;
                }

            }
        }

        private void SaveCurrent_Click(object sender, EventArgs e)
        {
            //TODO
            DialogResult result = MessageBox.Show("Enregistrer les modifications? Cliquez \"Non\" pour voir la fiche avant.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormFicheSave f = new FormFicheSave();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("TODO");
                    //TODO reprendre quelque part la méthode d'enregistrement dans la fiche
                    //(prendre en argument un pokémon?)
                }
            }
            else if (result == DialogResult.No)
            {
                VoirFiche(CurrentPokemon, NumSelected);
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VoirFiche(poke1, 1);
        }

        private void ComboCapaciteSpe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void VoirFiche(Pokemon p, int num)
        {
            if (p != null || Fichetab[num - 1] != null)
            {
                FormPokéFiche f = new FormPokéFiche();
                f.Show();

                if (Fichetab[num - 1] != null)
                {
                    if (!System.IO.File.Exists(Fichetab[num - 1]))
                        MessageBox.Show("Le fichier n'existe plus!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        f.Ouvrir(Fichetab[num - 1]);
                }
                else
                    f.Ouvrir(p);
            }
            else
            {
                MessageBox.Show("Pas de pokémon.", "Slot vide");
            }
        }

        private void pokémon2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoirFiche(poke2, 2);
        }

        private void pokémon3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoirFiche(poke3, 3);
        }

        private void pokémon4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoirFiche(poke4, 4);
        }

        private void pokémon5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoirFiche(poke5, 5);
        }

        private void pokémon6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoirFiche(poke6, 6);
        }

        private void btTabEquipe_Click(object sender, EventArgs e)
        {
            ShowCalcEquipe();
        }

        private void btTabMoveSet_Click(object sender, EventArgs e)
        {
            FormTabMoveSet f = new FormTabMoveSet(poke1, poke2, poke3, poke4, poke5, poke6);
            f.Show();
        }

        private void btTabMoveSetCurrent_Click(object sender, EventArgs e)
        {
            FormTabMoveSet f = new FormTabMoveSet(CurrentPokemon, null, null, null, null, null);

            //Type t1 = Type.AUCUN;
            //Type t2 = Type.AUCUN;
            //Type t3 = Type.AUCUN;
            //Type t4 = Type.AUCUN;

            //SetTypeFromPokemon(CurrentPokemon, out t1, out t2, out t3, out t4);
            //f.SetGrid(t1, t2, t3, t4);
            f.Show();
        }

        private void fichierURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEquipeEx.ShowDialog() == DialogResult.OK)
            {
                EquipeExport equipeex = new EquipeExport();
                equipeex.Pokemons = new Pokemon[6];
                equipeex.Pokemons[0] = poke1;
                equipeex.Pokemons[1] = poke2;
                equipeex.Pokemons[2] = poke3;
                equipeex.Pokemons[3] = poke4;
                equipeex.Pokemons[4] = poke5;
                equipeex.Pokemons[5] = poke6;
                equipeex.Save(sfdEquipeEx.FileName);
            }
        }

        void EffacePokemon(int numpoké)
        {
            switch (numpoké)
            {
                case 1:
                    poke1 = null;
                    rbPoke1.Text = "(aucun)";
                    mitemPK1.Text = "(aucun)";
                    break;
                case 2:
                    poke2 = null;
                    rbPoke2.Text = "(aucun)";
                    mitemPK2.Text = "(aucun)";
                    break;
                case 3:
                    poke3 = null;
                    rbPoke3.Text = "(aucun)";
                    mitemPK3.Text = "(aucun)";
                    break;
                case 4:
                    poke4 = null;
                    rbPoke4.Text = "(aucun)";
                    mitemPK4.Text = "(aucun)";
                    break;
                case 5:
                    poke5 = null;
                    rbPoke5.Text = "(aucun)";
                    mitemPK5.Text = "(aucun)";
                    break;
                case 6:
                    poke6 = null;
                    rbPoke6.Text = "(aucun)";
                    mitemPK6.Text = "(aucun)";
                    break;
            }

            SetFiche(null, numpoké);

            if (numpoké == NumSelected)
                EffaceCurrentPokemon();
        }

        void EffaceCurrentPokemon()
        {
            CurrentPokemon = null;

            EffaceControlesCapEtCapSpe();

            ComboPoke.SelectedIndexChanged -= new EventHandler(ComboPokémon_SelectedIndexChanged);
            ComboPoke.SelectedItem = "(vide)";
            ComboPoke.SelectedIndexChanged += new EventHandler(ComboPokémon_SelectedIndexChanged);

            ComboC1.SelectedIndex = 0;
            ComboC2.SelectedIndex = 0;
            ComboC3.SelectedIndex = 0;
            ComboC4.SelectedIndex = 0;

            gbMovesetCurrent.Text = "Moveset de (vide)";
            lbSurnom1.Text = "";
        }

        void ChangeCurrentPokemon()
        {
            Pokemon poke = xb.GetPokémon(ComboPoke.Text);
            CurrentPokemon = poke;
            EffaceControlesCapEtCapSpe();
            SetFiche(null, NumSelected);

            if (poke == null)
                EffacePokemon(NumSelected);
            else
            {
                switch (NumSelected)
                {
                    case 1:
                        poke1 = poke;
                        rbPoke1.Text = poke.Nom;
                        mitemPK1.Text = poke.Nom;
                        break;
                    case 2:
                        poke2 = poke;
                        rbPoke2.Text = poke.Nom;
                        mitemPK2.Text = poke.Nom;
                        break;
                    case 3:
                        poke3 = poke;
                        rbPoke3.Text = poke.Nom;
                        mitemPK3.Text = poke.Nom;
                        break;
                    case 4:
                        poke4 = poke;
                        rbPoke4.Text = poke.Nom;
                        mitemPK4.Text = poke.Nom;
                        break;
                    case 5:
                        poke5 = poke;
                        rbPoke5.Text = poke.Nom;
                        mitemPK5.Text = poke.Nom;
                        break;
                    case 6:
                        poke6 = poke;
                        rbPoke6.Text = poke.Nom;
                        mitemPK6.Text = poke.Nom;
                        break;
                }

                ComboPoke.SelectedIndexChanged -= new EventHandler(ComboPokémon_SelectedIndexChanged);
                ComboPoke.SelectedItem = poke.Nom;
                ComboPoke.SelectedIndexChanged += new EventHandler(ComboPokémon_SelectedIndexChanged);

                Capacite[] cap = Xblood.ListofMoves(poke);
                foreach (Capacite c in cap)
                {
                    ComboC1.Items.Add(c.Nom);
                    ComboC2.Items.Add(c.Nom);
                    ComboC3.Items.Add(c.Nom);
                    ComboC4.Items.Add(c.Nom);
                }

                
                foreach (string cs in poke.CapacitésSpé)
                {
                    if (cs != null)
                        ComboCapaciteSpe.Items.Add(cs);
                }

                
                lbType11.Text = poke.Type1.ToString();
                if (poke.Type2 != Type.AUCUN)
                    lbType21.Text = poke.Type2.ToString();
                else
                    lbType21.Text = "";

                gbMovesetCurrent.Text = "Moveset de " + poke.Nom;
            }

        }

        //à utiliser
        void ChargeCurrentFiche(Pokemon poke)
        {
            ComboC1.SelectedIndexChanged -= new EventHandler(ComboC1_SelectedIndexChanged);
            ComboC2.SelectedIndexChanged -= new EventHandler(ComboC2_SelectedIndexChanged);
            ComboC3.SelectedIndexChanged -= new EventHandler(ComboC3_SelectedIndexChanged);
            ComboC4.SelectedIndexChanged -= new EventHandler(ComboC4_SelectedIndexChanged);
            if (poke.Capacités_fiche[0] != null)
                ComboC1.SelectedItem = poke.Capacités_fiche[0].Nom;
            else
                ComboC1.SelectedIndex = 0;
            if (poke.Capacités_fiche[1] != null)
                ComboC2.SelectedItem = poke.Capacités_fiche[1].Nom;
            else
                ComboC2.SelectedIndex = 0;
            if (poke.Capacités_fiche[2] != null)
                ComboC3.SelectedItem = poke.Capacités_fiche[2].Nom;
            else
                ComboC3.SelectedIndex = 0;
            if (poke.Capacités_fiche[3] != null)
                ComboC4.SelectedItem = poke.Capacités_fiche[3].Nom;
            else
                ComboC4.SelectedIndex = 0;

            ComboC1.SelectedIndexChanged += new EventHandler(ComboC1_SelectedIndexChanged);
            ComboC2.SelectedIndexChanged += new EventHandler(ComboC2_SelectedIndexChanged);
            ComboC3.SelectedIndexChanged += new EventHandler(ComboC3_SelectedIndexChanged);
            ComboC4.SelectedIndexChanged += new EventHandler(ComboC4_SelectedIndexChanged);

            ComboCapaciteSpe.SelectedIndexChanged -= new EventHandler(ComboCapaciteSpe_SelectedIndexChanged);

            ComboCapaciteSpe.SelectedItem = poke.CapacitéSpé;

            ComboCapaciteSpe.SelectedIndexChanged += new EventHandler(ComboCapaciteSpe_SelectedIndexChanged);
        }

        private void EffaceControlesCapEtCapSpe()
        {
            ComboC1.Items.Clear();
            ComboC2.Items.Clear();
            ComboC3.Items.Clear();
            ComboC4.Items.Clear();

            ComboC1.Items.Add("(vide)");
            ComboC2.Items.Add("(vide)");
            ComboC3.Items.Add("(vide)");
            ComboC4.Items.Add("(vide)");

            ComboCapaciteSpe.Items.Clear();

        }

        void debugprint()
        {
            
            string eq = "";
            if (equipe == null)
                eq = "equipe = null";
            else
            {
                eq = "equipe = {\n";
                int i = 1;
                foreach (Pokemon p in equipe.Pokemons)
                {
                    eq += (p == null) ? "poke" + i + " = null" : "poke" + i + " = " + p.Nom + " (" + p.GetHashCode() + ")";
                    eq += "\n";
                    i++;
                }
                eq += "}";
            }

            string f = "";
            for (int i = 1; i <= Fichetab.Length; i++)
            {
                string str = Fichetab[i - 1];
                f += (str == null) ? "fiche" + i + " = null\n" : "fiche" + i + " = " + str + "\n";
            }
                

            string p1 = (poke1 == null) ? "poke1 = null" : "poke1 = " + poke1.Nom + " (" + poke1.GetHashCode() + ")";
            string p2 = (poke2 == null) ? "poke2 = null" : "poke2 = " + poke2.Nom + " (" + poke2.GetHashCode() + ")";
            string p3 = (poke3 == null) ? "poke3 = null" : "poke3 = " + poke3.Nom + " (" + poke3.GetHashCode() + ")";
            string p4 = (poke4 == null) ? "poke4 = null" : "poke4 = " + poke4.Nom + " (" + poke4.GetHashCode() + ")";
            string p5 = (poke5 == null) ? "poke5 = null" : "poke5 = " + poke5.Nom + " (" + poke5.GetHashCode() + ")";
            string p6 = (poke6 == null) ? "poke6 = null" : "poke6 = " + poke6.Nom + " (" + poke6.GetHashCode() + ")";

            string cp = (CurrentPokemon == null) ? "CurrentPokemon = null" : "CurrentPokemon = " + CurrentPokemon.Nom + " (" + CurrentPokemon.GetHashCode() + ")";

            Console.WriteLine("NumSelected = " + NumSelected);
            Console.WriteLine(cp);
            Console.WriteLine(eq);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", p1, p2, p3, p4, p5, p6);
            Console.WriteLine(f);
            Console.WriteLine(" ----- ");
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugprint();
        }
    }
}