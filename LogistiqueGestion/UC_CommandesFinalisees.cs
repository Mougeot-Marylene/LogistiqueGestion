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
    public partial class UC_CommandesFinalisees : UserControl
    {
        public UC_CommandesFinalisees()
        {
            InitializeComponent();

            // Center le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
 


        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

            // donnée tableau en attendant d'avoir les vrais valeurs 
            dataGridView1.Rows.Add("#0021", "20/05/2026", "3", "3500€", "Afficher");
            dataGridView1.Rows.Add("#0022", "20/05/2026", "8", "120€", "Afficher");
            dataGridView1.Rows.Add("#0023", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0024", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0025", "20/05/2026", "1", "20€", "Afficher");
            dataGridView1.Rows.Add("#0026", "20/05/2026", "1", "20€", "Afficher");
        }
    }
}
