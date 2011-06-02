using System;
using System.Windows.Forms;


namespace URA_Pokemon
{
    class Boot
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Menu());
        }
    }
}
