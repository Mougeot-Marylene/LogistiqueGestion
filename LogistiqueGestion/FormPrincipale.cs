using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogistiqueGestion
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();

            // Au démarrage, on affiche directement le tableau de bord
            AfficherTableau(new UC_TableauDeBord(), "Tableau de bord");
        }

        private void AfficherTableau(UserControl pageTableau, string titreDuHeader)
        {
            // 1. On change le titre du header en haut
            lbl_titre.Text = titreDuHeader;
            // 2. On vide le carré blanc et on y injecte le nouveau tableau
            pnlContenu.Controls.Clear();
            // 3. On dit au nouvel écran (le UC) de prendre toute la place disponible
            pageTableau.Dock = DockStyle.Fill;
            // 4. On l'injecte dans le panel central pour qu'il apparaisse à l'écran
            pnlContenu.Controls.Add(pageTableau);
        }

        // Lien tableau de bord
        private void liklab_tab_bord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_TableauDeBord(), "Tableau de bord");
        }

        //lien commandes en attente
        private void link_comm_attente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_CommandesAttente(), "Commandes en attente");
        }

        //Lien commandes en envoie
        private void link_comm_envoie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_CommandesEnvoie(), "Commandes en envoie");
        }

        private void link_comm_final_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_CommandesFinalisees(), "Commandes finalisées");
        }

        private void link_stock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_Stocks(), "Inventaires des produits");
        }

        private void link_embalage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfficherTableau(new UC_ToutesCommandeAEmballees(), "Commandes à emballées");
        }

    }
}
