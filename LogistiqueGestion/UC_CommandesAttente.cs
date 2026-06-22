
namespace LogistiqueGestion
{
    public partial class UC_CommandesAttente : UserControl
    {
        public UC_CommandesAttente()
        {
            InitializeComponent();

            // Center le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /// Abonner l'événement au clic sur une cellule du tableau
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            // donnée tableau en attendant d'avoir les vrais valeurs 
            dataGridView1.Rows.Add("#0001", "20/05/2026", "3", "3500€", "Préparer");
            dataGridView1.Rows.Add("#0002", "20/05/2026", "8", "120€", "Préparer" +
                "");
            dataGridView1.Rows.Add("#0003", "20/05/2026", "1", "20€", "Préparer" +
                "");
            dataGridView1.Rows.Add("#0004", "20/05/2026", "1", "20€", "Préparer" +
                "");
            dataGridView1.Rows.Add("#0005", "20/05/2026", "1", "20€", "Préparer" +
                "");
            dataGridView1.Rows.Add("#0006", "20/05/2026", "1", "20€", "Préparer" +
                "");
        }

        //ouverture de UC_PrepaCommande (lien preparer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que c'est la colonne "préparer" qui est cliquée et pas l'en-tête
            if (dataGridView1.Columns[e.ColumnIndex].Name == "preparer" && e.RowIndex >= 0)
            {
                // Créer une instance du UserControl UC_PrepasCommande
                UC_PrepasCommande uc = new UC_PrepasCommande();

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
