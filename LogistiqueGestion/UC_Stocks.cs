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
    public partial class UC_Stocks : UserControl
    {
        public UC_Stocks()
        {
            InitializeComponent();

            /* partie bouton augmenter */
            // 1. On dit à ton tableau que la colonne "Augmenter" est bien une colonne de boutons
            var colAugmenter = (DataGridViewButtonColumn)dataGridView1.Columns["Augmenter"];

            // 2. On applique le style Flat directement sur la colonne de boutons
            colAugmenter.FlatStyle = FlatStyle.Flat;

            // 3. On applique la couleur verte de fond et le texte en blanc
            colAugmenter.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            colAugmenter.DefaultCellStyle.ForeColor = Color.White;


            /* Mettre titre colonne au centre */
            // Le chiffre 3 correspond à la 4ème colonne
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
     
            // Le chiffre 2 correspond à la 3ème colonne
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void tlp_card_Paint(object sender, PaintEventArgs e)
        {
            // 1. On récupères l'image depuis les ressources Windows Forms
         // (Remplace 'mon_image_produit' par le vrai nom de l'image dans le projet)
            Image imgProduitCasque = Properties.Resources.casque;
            Image imgProduitCoque = Properties.Resources.coque;
            Image imgProduitSouris = Properties.Resources.souris;
            Image imgProduitIpad = Properties.Resources.ipad;

            // donnée tableau en attendant d'avoir les vrais valeurs 
            // 2. On ajoutes la ligne en mettant l'objet image en tout premier position !
            dataGridView1.Rows.Add(imgProduitCasque, "Casque bluetooth", "CAS-BT-001","300", "3500€", "Augmenter", "Afficher");
            dataGridView1.Rows.Add(imgProduitCoque, "20/05/2026", "CAS-BT-001", "300", "3500€", "Augmenter", "Afficher");
            dataGridView1.Rows.Add(imgProduitSouris, "20/05/2026", "CAS-BT-001","300", "3500€", "Augmenter", "Afficher");
            dataGridView1.Rows.Add(imgProduitIpad, "20/05/2026", "CAS-BT-001","300", "3500€", "Augmenter", "Afficher");

        }
    }
}
