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
    public partial class UC_TableauDeBord : UserControl
    {
        public UC_TableauDeBord()
        {
            InitializeComponent();
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Centert le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void tlp_ConteneurPrincipal_Paint(object sender, PaintEventArgs e)
        {
            // On s'assure que le tableau est vide avant d'ajouter les lignes
            dataGridView1.Rows.Clear();

            // donnée tableau en attendant d'avoir les vrais valeurs 
            dataGridView1.Rows.Add("#0001", "20/05/2026", "3", "3500€", "Afficher");
            dataGridView1.Rows.Add("#0002", "20/05/2026", "8", "120€", "Afficher");
            dataGridView1.Rows.Add("#0003", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0004", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0005", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0006", "20/05/2026", "1", "20€", "Afficher");
        }

    }
}
