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
    public partial class UC_ToutesCommandeAEmballees : UserControl
    {
        public UC_ToutesCommandeAEmballees()
        {
            InitializeComponent();

            /* Mettre titre colonne au centre */
            // Le chiffre 3 correspond à la 4ème colonne
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Le chiffre 2 correspond à la 3ème colonne
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Le chiffre 4 correspond à la 5ème colonne
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

            // 1. On récupères l'image depuis les ressources Windows Forms
            // (Remplace 'mon_image_produit' par le vrai nom de l'image dans le projet)
            Image imgProduitCasque = Properties.Resources.casque;
            Image imgProduitCoque = Properties.Resources.coque;
            Image imgProduitSouris = Properties.Resources.souris;
            Image imgProduitIpad = Properties.Resources.ipad;

            // donnée tableau en attendant d'avoir les vrais valeurs 
            dataGridView1.Rows.Add("#0001", "20/05/2026", "3", "3500€", "Emballer");
            dataGridView1.Rows.Add("#0002", "20/05/2026", "8", "120€", "Emballer" +
                "");
            dataGridView1.Rows.Add("#0003", "20/05/2026", "1", "20€", "Emballer" +
                "");
            dataGridView1.Rows.Add("#0004", "20/05/2026", "1", "20€", "Emballer" +
                "");
            dataGridView1.Rows.Add("#0005", "20/05/2026", "1", "20€", "Emballer" +
                "");
            dataGridView1.Rows.Add("#0006", "20/05/2026", "1", "20€", "Emballer" +
                "");
        }

        //ouverture de UC_PrepaCommande (lien preparer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que c'est la colonne "préparer" qui est cliquée et pas l'en-tête
            if (dataGridView1.Columns[e.ColumnIndex].Name == "emballer" && e.RowIndex >= 0)
            {
                // Créer une instance du UserControl UC_PrepasCommande
                UC_CommandeEmbal uc = new UC_CommandeEmbal();

                // Le faire occuper tout l'espace disponible
                uc.Dock = DockStyle.Fill;

                // Vider le contenu actuel
                this.Controls.Clear();

                // Afficher le UserControl UC_PrepasCommande
                this.Controls.Add(uc);
            }
        }

    }
}
