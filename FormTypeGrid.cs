using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class FormTypeGrid : Form
    {

        
        public FormTypeGrid()
        {
            InitializeComponent();
        }

        public FormTypeGrid(Type t1, Type t2, Type t3, Type t4)
        {
            InitializeComponent();
            SetGrid(t1, t2, t3, t4);
        }

        private void FormTypeGrid_Load(object sender, EventArgs e)
        {
            
        }

        public void SetGrid(Type t1,Type t2,Type t3,Type t4)
        {
            if (Xblood.TypesExistants == null)
                Xblood.FillTypesExistants();

            int length0 = Xblood.TypesExistants.GetLength(0);
            int length1 = Xblood.TypesExistants.GetLength(1);

            for (int i = 0; i < length1; i++)
            {
                int num = dataGridView1.Columns.Add("Col" + ((Type)i).ToString(), ((Type)i).ToString());
                DataGridViewColumn col = dataGridView1.Columns[num];
                col.HeaderText = ((Type)i).ToString();
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;

            }

            for (int j = 0; j < length0; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = ((Type)j).ToString();
                if (dataGridView1.RowTemplate != null)
                    dataGridView1.Rows.Add(row);
            }

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length0; j++)
                {
                    if (i == j || (!Xblood.TypesExistants[j, i] /*&& !Xblood.TypesExistants[i, j]*/))
                    {
                        dataGridView1[i, j].Style.BackColor = Color.Gray;

                    }
                    else
                    {
                        int eff1 = Efficacite(t1, (Type)i, (Type)j);
                        int eff2 = Efficacite(t2, (Type)i, (Type)j);
                        int eff3 = Efficacite(t3, (Type)i, (Type)j);
                        int eff4 = Efficacite(t4, (Type)i, (Type)j);

                        if (eff1 == 7 && eff2 == 7 && eff3 == 7 && eff4 == 7)
                        {
                            dataGridView1[i, j].Value = "A";
                        }
                        else if ((eff1 >= 2 && eff1 != 7) || (eff2 >= 2 && eff2 != 7) || (eff3 >= 2 && eff3 != 7) || (eff4 >= 2 && eff4 != 7))
                        {
                            dataGridView1[i, j].Value = "O";
                            //dataGridView1[j, i].Value = "O";
                        }
                        else if (eff1 == 0 || eff2 == 0 || eff3 == 0 || eff4 == 0)
                            ;//rien
                        else if (eff1 <= -2 || eff2 <= -2 || eff3 <= -2 || eff4 <= -2)
                        {
                            dataGridView1[i, j].Value = "X";
                            //dataGridView1[j, i].Value = "X";
                        }
                        

                    }
                    
                }
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dataGridView1.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dataGridView1.ColumnHeadersHeight < titleSize.Width)
                    this.dataGridView1.ColumnHeadersHeight = titleSize.Width + 20;

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