using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormEvalPoke : Form
    {
        Stack<Pokemon> StackPoke = null;

        public FormEvalPoke(Stack<Pokemon> p)
        {
            InitializeComponent();
            StackPoke = p;
        }

        private void FormEvalPoke_Load(object sender, EventArgs e)
        {
            Calculer2();
        }

        void Calculer()
        {
            dataGridView3.Rows.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            //tableau des types contenant le nombre de neutralités/résistances/faiblesses/immunités
            int[,] tabTypeFaiblRes = new int[17, 4];

            //POKEMONS EQUIPE
            for (int i = 0; i < 17; i++)
            {
                int num = dataGridView5.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                DataGridViewColumn col = dataGridView5.Columns[num];
                col.HeaderText = ((Type)i).ToString();
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;
            }
            
            //On stocke les valeurs de toute l'équipe
            foreach (Pokemon p in StackPoke)
            {
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
                    }
                    else if (p.TableauFaiblRes[i] >= 2)
                    {
                        tabTypeFaiblRes[i, 2]++;
                        cell.Value = "F";
                        cell.Style.BackColor = Color.Red;
                    }
                    else if (p.TableauFaiblRes[i] == 0)
                        tabTypeFaiblRes[i, 0]++;
                    else if (p.TableauFaiblRes[i] <= -2)
                    {
                        tabTypeFaiblRes[i, 1]++;
                        cell.Value = "R";
                        cell.Style.BackColor = Color.Yellow;
                    }

                    r.Cells.Add(cell);
                }
                dataGridView5.Rows.Add(r);
            }

            //TABLEAU FAIBLESSES
            for (int i = 0; i < 17; i++)
            {
                int num = dataGridView3.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                DataGridViewColumn col = dataGridView3.Columns[num];
                col.HeaderText = ((Type)i).ToString();
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;
            }

            DataGridViewRow row = new DataGridViewRow();
            row.HeaderCell.Value = "Equipe";
            //if (dataGridView3.RowTemplate != null)


            for (int i = 0; i < 17; i++)
            {

                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                if (tabTypeFaiblRes[i, 2] != 0)
                {
                    cell.Value = tabTypeFaiblRes[i, 2];
                    listBox4.Items.Add(tabTypeFaiblRes[i, 2] + " faiblesse(s) à " + ((Type)i).ToString());
                }
                row.Cells.Add(cell);

                if (tabTypeFaiblRes[i, 1] == 0 && tabTypeFaiblRes[i, 3] == 0)
                    listBox5.Items.Add("Personne ne résiste à " + ((Type)i).ToString());
            }

            dataGridView3.Rows.Add(row);
        }

        void Calculer2()
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            int num = dataGridView3.Columns.Add("ColFaibl", "Faiblesses");
            DataGridViewColumn col = dataGridView3.Columns[num];
            col.HeaderText = "Faiblesses";
            col.SortMode = DataGridViewColumnSortMode.Automatic;
            col.Resizable = DataGridViewTriState.False;

            num = dataGridView3.Columns.Add("ColRes", "Résistances");
             col = dataGridView3.Columns[num];
            col.HeaderText = "Résistances";
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Resizable = DataGridViewTriState.False;

            num = dataGridView3.Columns.Add("ColNeu", "Neutralités");
             col = dataGridView3.Columns[num];
            col.HeaderText = "Neutralités";
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Resizable = DataGridViewTriState.False;

            num = dataGridView3.Columns.Add("ColImm", "Immunités");
             col = dataGridView3.Columns[num];
            col.HeaderText = "Immunités";
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            col.Resizable = DataGridViewTriState.False;

            //tableau des types contenant le nombre de neutralités/résistances/faiblesses/immunités
            int[,] tabTypeFaiblRes = new int[17, 4];

            //POKEMONS EQUIPE
            for (int i = 0; i < 17; i++)
            {
                 num = dataGridView5.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                 col = dataGridView5.Columns[num];
                col.HeaderText = ((Type)i).ToString();
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;
            }

            //On stocke les valeurs de toute l'équipe
            foreach (Pokemon p in StackPoke)
            {
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
                    }
                    else if (p.TableauFaiblRes[i] >= 2)
                    {
                        tabTypeFaiblRes[i, 2]++;
                        cell.Value = "F";
                        cell.Style.BackColor = Color.Red;
                    }
                    else if (p.TableauFaiblRes[i] == 0)
                        tabTypeFaiblRes[i, 0]++;
                    else if (p.TableauFaiblRes[i] <= -2)
                    {
                        tabTypeFaiblRes[i, 1]++;
                        cell.Value = "R";
                        cell.Style.BackColor = Color.Yellow;
                    }

                    r.Cells.Add(cell);
                }
                dataGridView5.Rows.Add(r);
            }

            //TABLEAU FAIBLESSES
            for (int i = 0; i < 17; i++)
            {
                //int num = dataGridView3.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                //DataGridViewColumn col = dataGridView3.Columns[num];
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

                dataGridView3.Rows.Add(row);
            }

            //DataGridViewRow row = new DataGridViewRow();
            //row.HeaderCell.Value = "Equipe";
            //if (dataGridView3.RowTemplate != null)


            for (int i = 0; i < 17; i++)
            {

                DataGridViewCell cell = null;
                if (tabTypeFaiblRes[i, 2] != 0)
                {
                    cell = dataGridView3[0, i];
                    cell.Value = tabTypeFaiblRes[i, 2];
                    listBox4.Items.Add(tabTypeFaiblRes[i, 2] + " faiblesse(s) à " + ((Type)i).ToString());
                }
                if (tabTypeFaiblRes[i, 1] != 0)
                {
                    cell = dataGridView3[1, i];
                    cell.Value = tabTypeFaiblRes[i, 1];
                }
                if (tabTypeFaiblRes[i, 0] != 0)
                {
                    cell = dataGridView3[2, i];
                    cell.Value = tabTypeFaiblRes[i, 0];
                }
                if (tabTypeFaiblRes[i, 3] != 0)
                {
                    cell = dataGridView3[3, i];
                    cell.Value = tabTypeFaiblRes[i, 3];
                }

                //row.Cells.Add(cell);

                if (tabTypeFaiblRes[i, 1] == 0 && tabTypeFaiblRes[i, 3] == 0)
                    listBox5.Items.Add("Personne ne résiste à " + ((Type)i).ToString());
            }

            //dataGridView3.Rows.Add(row);
        }

        private void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dataGridView3.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dataGridView3.ColumnHeadersHeight < titleSize.Width)
                    this.dataGridView3.ColumnHeadersHeight = titleSize.Width + 20;

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), this.Font, Brushes.Black, new PointF(rect.Y, rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
        }

        private void dataGridView5_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dataGridView5.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dataGridView5.ColumnHeadersHeight < titleSize.Width)
                    this.dataGridView5.ColumnHeadersHeight = titleSize.Width + 20;

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