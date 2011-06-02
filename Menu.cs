using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace URA_Pokemon
{
    public partial class Menu : Form
    {
        Loading Loadform;
        public Menu()
        {
            InitializeComponent();
            Xblood.CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
        }

        private void btAccouplement_Click(object sender, EventArgs e)
        {
            FormAccouplement f = new FormAccouplement();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();

        }

        private void btDescription_Click(object sender, EventArgs e)
        {
            FormDescription f = new FormDescription();
            if (!Xblood.PKlistisFilled)
            {

                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btTypes_Click(object sender, EventArgs e)
        {
            FormTypes ft = new FormTypes();
            ft.Show();
        }

        private void btDV_Click(object sender, EventArgs e)
        {
            FormDVFinder f = new FormDVFinder();
            if (!Xblood.PKlistisFilled)
            {

                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btStats_Click(object sender, EventArgs e)
        {
            FormStats f = new FormStats();
            if (!Xblood.PKlistisFilled)
            {

                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btFiche_Click(object sender, EventArgs e)
        {
            FormPokéFiche f = new FormPokéFiche();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btCapacités_Click(object sender, EventArgs e)
        {
            FormCapacites f = new FormCapacites();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btDegats_Click(object sender, EventArgs e)
        {
            FormDegats f = new FormDegats();
            f.Focus();
            f.Show();
        }

        private void btFiltrer_Click(object sender, EventArgs e)
        {
            FormFiltrer f = new FormFiltrer();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btCapSpe_Click(object sender, EventArgs e)
        {
            FormCapSpe f = new FormCapSpe();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            FormCompare f = new FormCompare();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void btEquipe_Click(object sender, EventArgs e)
        {

            FormEquipe f = new FormEquipe();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPCfinder f = new formPCfinder();
            f.Show();
        }

        private void btDescription_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "PokéDescription :\r\n" +
                "Visualiser les infos sur un pokémon, comme les capacités qu'il peut apprendre ou bien ses stats de bases.\r\n" +
                "Cliquez sur le nom ou sur le numéro pour changer de pokémon.";
        }

        private void btDescription_MouseLeave(object sender, EventArgs e)
        {
            lbdef.Text = "";
        }

        private void btCapacités_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Capacités :\r\nToutes les informations sur les capacités:\r\nPuissance, précision, PP, effets associées.";
        }
        

        private void btCapSpe_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Capacités Spé :\r\nLes descriptions de toutes les capacités spéciales.";
        }


        private void btAccouplement_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Accouplement :\r\nCalculez les accouplements nécessaires pour transmettre des capacités à un pokémon.";
        }

        private void btDV_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "IV Finder :\r\nCalculez les IV de vos pokémon.\r\nMunissez-vous de super bonbons et de pokémons n'ayant aucun EV, c'est à dire n'ayant jamais combattus.";
        }

        private void btPCFinder_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "PC Finder :\r\nCalculez le type et la force de la PUIS. CACHEE de votre pokémon.\r\nMais avant cela vous devrez calculez ses IV.";
        }

        private void btStats_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Stats : \r\nPermet de calculer précisément les statistiques d'un pokémon à un niveau donné.\r\nVous avez plusieurs méthodes possibles d'indiquer les EV:\r\nMaxi: Met toutes les stats au maximum.\r\nglobal: indique la quantité de points d'efforts pour toutes les stats.\r\nPar stat: spécifie individuellement les points d'efforts de chaque stat.";
            //"Affiche "
        }

        private void btDegats_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Dégâts :\r\ncalculez les degats que votre pokémon infligera a un autre ou l'inverse.\r\npour cela vous devrez connaitre l'attaque(ou attaque spé) du pokémon attaquant et la defense (ou defense spé) du pokémon opossant.Les resultats sont donné en Pv perdu.";
        }

        private void btFiltrer_MouseHover(object sender, EventArgs e)
        {
            lbdef.Text = "Permet d'afficher une liste filtré par les critères sélectionnés (cochez la case correspondante et entrez une valeur) dans le menu de gauche (j'espère que vous êtes pas en 800x600).\r\n" +
    "Vous pouvez trier les colonnes en cliquant sur l'en-tête et les afficher/masquer avec un click droit.\r\n" +
    "Attention un double click fait apparaitre la fiche du pokémon sélectionné, même quand on double clic sur l'en-tête...\r\n" +
    "Les colonnes bleu clair représentent les stats de base et les colonnes orange les points d'efforts.\r\n" +
    "Laissez la case vide ou décocher l'option si vous ne voulez plus qu'une condition soit prise en compte.\r\n" +
    "Avant de filtrer par moyenne, choisissez les stats sur lequelles la moyenne est calculé.\r\n" +
    "Cliquez juste sur Filtrer pour afficher tout les pokémons.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormTab f = new FormTab();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filtre2 f = new Filtre2();
            if (!Xblood.PKlistisFilled)
            {
                Loadform = new Loading(f);
                Loadform.ShowDialog();
                f.Focus();
            }
            else
                f.Show();
        }

    }
}