using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormTabEquipe : Form
    {
        public FormTabEquipe(Queue<Pokemon> QueuePoke)
        {
            InitializeComponent();
            CalcEquipe(QueuePoke);
        }

        private void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvEquipe.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dgvEquipe.ColumnHeadersHeight < titleSize.Width)
                    this.dgvEquipe.ColumnHeadersHeight = titleSize.Width + 20;

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
        }

        void CalcEquipe(Queue<Pokemon> QueuePoke)
        {
            int nbRes = 0;
            int nbFaib = 0;
            int nbImm = 0;
            int nbNeut = 0;

            dgvEquipe.Rows.Clear();
            //dgvEquipe.Columns.Clear();
            //dgvDetail.Rows.Clear();
            //dgvDetail.Columns.Clear();
            //listBox1.Items.Clear();

            //On ajoute les colonnes au besoin
            if (dgvEquipe.Columns.Count == 0)
            {
                int num = dgvEquipe.Columns.Add("ColFaibl", "Faiblesses  ");
                DataGridViewColumn col = dgvEquipe.Columns[num];
                //col.HeaderText = "Faiblesses  ";
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.Resizable = DataGridViewTriState.False;

                num = dgvEquipe.Columns.Add("ColRes", "Résistances  ");
                col = dgvEquipe.Columns[num];
                //col.HeaderText = "Résistances  ";
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.Resizable = DataGridViewTriState.False;

                num = dgvEquipe.Columns.Add("ColNeu", "Neutralités  ");
                col = dgvEquipe.Columns[num];
                //col.HeaderText = "Neutralités  ";
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.Resizable = DataGridViewTriState.False;

                num = dgvEquipe.Columns.Add("ColImm", "Immunités  ");
                col = dgvEquipe.Columns[num];
                //col.HeaderText = "Immunités  ";
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.Resizable = DataGridViewTriState.False;

                num = dgvEquipe.Columns.Add("ColTypes", "Types  ");
                col = dgvEquipe.Columns[num];
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                col.Resizable = DataGridViewTriState.False;
            }

            //tableau des types contenant le nombre de neutralités/résistances/faiblesses/immunités
            int[,] tabTypeFaiblRes = new int[17, 4];

            ////POKEMONS EQUIPE
            //if (dgvDetail.Columns.Count == 0)
            //{
            //    for (int i = 0; i < 17; i++)
            //    {
            //        int num = dgvDetail.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
            //        DataGridViewColumn col = dgvDetail.Columns[num];
            //        col.HeaderCell.Style = dgvDetail.ColumnHeadersDefaultCellStyle;
            //        col.HeaderText = ((Type)i).ToString();
            //        col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //        col.Resizable = DataGridViewTriState.False;
            //    }
            //}

            //Queue<Pokemon> QueuePoke = new Queue<Pokemon>();
            //if (poke1 != null)
            //    QueuePoke.Enqueue(poke1);
            //if (poke2 != null)
            //    QueuePoke.Enqueue(poke2);
            //if (poke3 != null)
            //    QueuePoke.Enqueue(poke3);
            //if (poke4 != null)
            //    QueuePoke.Enqueue(poke4);
            //if (poke5 != null)
            //    QueuePoke.Enqueue(poke5);
            //if (poke6 != null)
            //    QueuePoke.Enqueue(poke6);

            //On stocke les valeurs de toute l'équipe
            foreach (Pokemon p in QueuePoke)
            {
                //DataGridViewRow r = new DataGridViewRow();
                //r.HeaderCell.Value = p.Nom;
                for (int i = 0; i < 17; i++)
                {
                    //DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    //cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    /*
                     * 0 = neutre
                     * 1 = résistant
                     * 2 = faible
                     * 3 = immunisé
                    */
                    if (p.TableauFaiblRes[i] == 7)
                    {
                        tabTypeFaiblRes[i, 3]++;
                        //cell.Value = "I";
                        //cell.Style.BackColor = Color.Purple;
                    }
                    else if (p.TableauFaiblRes[i] >= 2)
                    {
                        tabTypeFaiblRes[i, 2]++;
                        //cell.Value = "F";
                        //cell.Style.BackColor = Color.Red;
                    }
                    else if (p.TableauFaiblRes[i] == 0)
                    {
                        tabTypeFaiblRes[i, 0]++;
                        //cell.Value = "";
                    }
                    else if (p.TableauFaiblRes[i] <= -2)
                    {
                        tabTypeFaiblRes[i, 1]++;
                        //cell.Value = "R";
                        //cell.Style.BackColor = Color.Yellow;
                    }

                    //r.Cells.Add(cell);
                }
                //dgvDetail.Rows.Add(r);
            }

            //TABLEAU FAIBLESSES
            for (int i = 0; i < 17; i++)
            {
                //int num = dgvEquipe.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                //DataGridViewColumn col = dgvEquipe.Columns[num];
                //col.HeaderText = ((Type)i).ToString();
                //col.SortMode = DataGridViewColumnSortMode.NotSortable;
                //col.Resizable = DataGridViewTriState.False;

                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = ((Type)i).ToString();
                for (int j = 0; j < 4; j++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    row.Cells.Add(cell);
                }

                dgvEquipe.Rows.Add(row);
            }


            for (int i = 0; i < 17; i++)
            {

                DataGridViewCell cell = null;
                //faiblesses
                if (tabTypeFaiblRes[i, 2] != 0)
                {
                    cell = dgvEquipe[0, i];
                    cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 2]);
                    cell.Value = tabTypeFaiblRes[i, 2];
                    nbFaib += tabTypeFaiblRes[i, 2];
                    //listBox4.Items.Add(tabTypeFaiblRes[i, 2] + " faiblesse(s) à " + ((Type)i).ToString());
                }
                //résistances
                if (tabTypeFaiblRes[i, 1] != 0)
                {
                    cell = dgvEquipe[1, i];
                    //cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 1]);
                    cell.Value = tabTypeFaiblRes[i, 1];
                    nbRes += tabTypeFaiblRes[i, 1];
                }
                //neutralités
                if (tabTypeFaiblRes[i, 0] != 0)
                {
                    cell = dgvEquipe[2, i];
                    //cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 0]);
                    cell.Value = tabTypeFaiblRes[i, 0];
                    nbNeut += tabTypeFaiblRes[i, 0];
                }
                //immunités
                if (tabTypeFaiblRes[i, 3] != 0)
                {
                    cell = dgvEquipe[3, i];
                    //cell.Style.BackColor = GetCellColorByGravity(tabTypeFaiblRes[i, 3]);
                    cell.Value = tabTypeFaiblRes[i, 3];
                    nbImm += tabTypeFaiblRes[i, 3];
                }

                cell = dgvEquipe[4, i];
                cell.Value = i + 1;
                //row.Cells.Add(cell);

                //if (tabTypeFaiblRes[i, 1] == 0 && tabTypeFaiblRes[i, 3] == 0)
                //    listBox1.Items.Add("Personne ne résiste à " + ((Type)i).ToString());
            }

            //lbFaiblesses.Text = "Faiblesse: " + nbFaib;
            //lbResistances.Text = "Résistances: " + nbRes;
            //lbNeutralitesTypes.Text = "Neutralités: " + nbNeut;
            //lbImmunitesEquipe.Text = "Immunités: " + nbImm;
        }

        Color GetCellColorByGravity(int gravity)
        {
            switch (gravity)
            {
                case 1:
                    return Color.FromArgb(255, 251, 214);
                case 2:
                    return Color.FromArgb(255, 218, 173);
                case 3:
                    return Color.FromArgb(255, 160, 135);
                case 4:
                    return Color.FromArgb(255, 117, 100);
                case 5:
                    return Color.FromArgb(255, 70, 60);
                case 6:
                    return Color.FromArgb(255, 20, 5);
                default:
                    return Color.White;
            }
        }
    }
}