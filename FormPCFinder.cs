using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class formPCfinder : Form
    {
        public formPCfinder()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            int pv = Convert.ToInt32(txtpv.Value);
            int att = Convert.ToInt32(txtatt.Value);
            int def = Convert.ToInt32(txtdef.Value);
            int attspé = Convert.ToInt32(txtattspé.Value);
            int defspé = Convert.ToInt32(txtdefspé.Value);
            int vit = Convert.ToInt32(txtvit.Value);


            int A = stat(pv, 1);
            int B = stat(att, 2);
            int C = stat(def, 4);
            int F = stat(vit, 8);
            int D = stat(attspé, 16);
            int E = stat(defspé, 32);

            lbforce.Text = Convert.ToString((int)Math.Truncate((A + B + C + D + E + F) * 40d / 63d + 30));

            A = pair(pv, 1);
            B = pair(att, 2);
            C = pair(def, 4);
            F = pair(vit, 8);
            D = pair(attspé, 16);
            E = pair(defspé, 32);
            

            int type = (int)Math.Truncate((A + B + C + D + E + F) * 15d / 63d);

            string strtype = "";
            switch (type)
            {
                case 0:
                    strtype = "combat";
                    break;
                case 1:
                    strtype = "vol";
                    break;
                case 2:
                    strtype = "poison";
                    break;
                case 3:
                    strtype = "sol";
                    break;
                case 4:
                    strtype = "roche";
                    break;
                case 5:
                    strtype = "insecte";
                    break;
                case 6:
                    strtype = "spectre";
                    break;
                case 7:
                    strtype = "acier";
                    break;
                case 8:
                    strtype = "feu";
                    break;
                case 9:
                    strtype = "eau";
                    break;
                case 10:
                    strtype = "plante";
                    break;
                case 11:
                    strtype = "electrique";
                    break;
                case 12:
                    strtype = "psy";
                    break;
                case 13:
                    strtype = "glace";
                    break;
                case 14:
                    strtype = "dragon";
                    break;
                case 15:
                    strtype = "ténèbres";
                    break;
                default:
                    strtype = "inconnu";
                    break;
            }
            lbtype.Text = strtype;


        }

        int stat(int IV, int val)
        {
            int modulo = IV % 4;
            if (modulo == 2 || modulo == 3)
            {
                return val;

            }
            else
                return 0;
        }
        int pair(int IV, int val)
        {
            int modulo = IV % 2;
            if (modulo == 1)
            {
                return val;

            }
            else
                return 0;
        }

        
    }
}
