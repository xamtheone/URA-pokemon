using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormTabMoveSet : Form
    {
        public FormTabMoveSet(Pokemon poke1, Pokemon poke2, Pokemon poke3, Pokemon poke4, Pokemon poke5, Pokemon poke6)
        {
            InitializeComponent();
            CalcMoveSet(poke1, poke2, poke3, poke4, poke5, poke6);
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

        void CalcMoveSet(Pokemon poke1,Pokemon poke2,Pokemon poke3,Pokemon poke4,Pokemon poke5,Pokemon poke6)
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

            if (dgvMoveSet.Columns.Count == 0)
            {
                for (int i = 0; i < length1; i++)
                {
                    int num = dgvMoveSet.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                    DataGridViewColumn col = dgvMoveSet.Columns[num];
                    col.HeaderText = ((Type)i).ToString();
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    col.Resizable = DataGridViewTriState.False;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            if (dgvMoveSet.Rows.Count == 0)
            {
                for (int j = 0; j < length0; j++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = ((Type)j).ToString();
                    if (dgvMoveSet.RowTemplate != null)
                        dgvMoveSet.Rows.Add(row);
                }
            }

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i == j || (!Xblood.TypesExistants[j, i] /*&& !Xblood.TypesExistants[i, j]*/))
                    {
                        dgvMoveSet[i, j].Style.BackColor = Color.Gray;

                    }
                    else
                    {
                        dgvMoveSet[i, j].Style.BackColor = Color.White;

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
                            dgvMoveSet[i, j].Value = "A";
                            dgvMoveSet[i, j].Style.BackColor = Color.Purple;
                            //nbImm++;
                        }
                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7) || (eff5 >= 2 && eff5 != 7) || (eff6 >= 2 && eff6 != 7) || (eff7 >= 2 && eff7 != 7) || (eff8 >= 2 && eff8 != 7) || (eff9 >= 2 && eff9 != 7) || (eff10 >= 2 && eff10 != 7) || (eff11 >= 2 && eff11 != 7) || (eff12 >= 2 && eff12 != 7) || (eff13 >= 2 && eff13 != 7) || (eff14 >= 2 && eff14 != 7) || (eff15 >= 2 && eff15 != 7) || (eff16 >= 2 && eff16 != 7) || (eff17 >= 2 && eff17 != 7) || (eff18 >= 2 && eff18 != 7) || (eff19 >= 2 && eff19 != 7) || (eff20 >= 2 && eff20 != 7) || (eff21 >= 2 && eff21 != 7) || (eff22 >= 2 && eff22 != 7) || (eff23 >= 2 && eff23 != 7) || (eff24 >= 2 && eff24 != 7))
                        {
                            dgvMoveSet[i, j].Value = "O";
                            dgvMoveSet[i, j].Style.BackColor = Color.Green;
                            //nbEff++;
                        }
                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0 || eff5 == 0 || eff6 == 0 || eff7 == 0 || eff8 == 0 || eff9 == 0 || eff10 == 0 || eff11 == 0 || eff12 == 0 || eff13 == 0 || eff14 == 0 || eff15 == 0 || eff16 == 0 || eff17 == 0 || eff18 == 0 || eff19 == 0 || eff20 == 0 || eff21 == 0 || eff22 == 0 || eff23 == 0 || eff24 == 0)
                        {
                            //nbNeut++;
                            dgvMoveSet[i, j].Value = "";
                        }
                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2 || eff5 <= -2 || eff6 <= -2 || eff7 <= -2 || eff8 <= -2 || eff9 <= -2 || eff10 <= -2 || eff11 <= -2 || eff12 <= -2 || eff13 <= -2 || eff14 <= -2 || eff15 <= -2 || eff16 <= -2 || eff17 <= -2 || eff18 <= -2 || eff19 <= -2 || eff20 <= -2 || eff21 <= -2 || eff22 <= -2 || eff23 <= -2 || eff24 <= -2)
                        {
                            dgvMoveSet[i, j].Value = "X";
                            dgvMoveSet[i, j].Style.BackColor = Color.Red;
                            //nbInn++;
                        }


                    }

                }
            }

            //lbEfficacites.Text = "Efficacités: " + nbEff + "/95";
            //lbNeutralitesMoveSet.Text = "Neutralités: " + nbNeut + "/95";
            //lbInnefficacites.Text = "Innefficacités: " + nbInn + "/95";
            //lbimmunitesMoveSet.Text = "Immunités: " + nbImm + "/95";
        }

        private void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvMoveSet.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dgvMoveSet.ColumnHeadersHeight < titleSize.Width)
                    this.dgvMoveSet.ColumnHeadersHeight = titleSize.Width + 20;

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
        }
    }
}