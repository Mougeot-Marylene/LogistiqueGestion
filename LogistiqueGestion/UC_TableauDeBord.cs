
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Linq; // OBLIGATOIRE pour utiliser Enumerable.Empty et ToList

namespace LogistiqueGestion
{
    public partial class UC_TableauDeBord : UserControl
    {
        public UC_TableauDeBord()
        {
            InitializeComponent();

            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_TableauDeBord_Load;

            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Centert le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Abonner l'événement au clic sur une cellule du tableau
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
        // L'événement Load permet d'utiliser 'async void' en toute sécurité dans WinForms
        private async void UC_TableauDeBord_Load(object sender, EventArgs e)
        {
            // appel methode pour afficher els commandes en attentes
            await ChargerCommandes();
        }

        private void tlp_ConteneurPrincipal_Paint(object sender, PaintEventArgs e)
        {

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
        private async Task ChargerCommandes()
        {
            
            try
            {
                using HttpClient client = new HttpClient();

                var responseCommmAttente = await client.GetAsync("http://localhost:5287/api/LigneCommandes/EnAttente");
                responseCommmAttente.EnsureSuccessStatusCode();

                var result = await responseCommmAttente.Content.ReadFromJsonAsync<GetLigneCommandeResponse>();

                // On crée la variable "commandes"
                // → result?.Items : si "result" n'est pas null, on récupère sa propriété "Items"
                // → ?? : sinon, si "result?.Items" vaut null...
                // → Enumerable.Empty<LigneCommande>() : on utilise une liste vide de LigneCommande
                var commandesAttente = (result?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();
          
                // 2. Récupération du nombre total de commandesAttente
                int nb_comm_attente = commandesAttente.Count;

                // 3. Mise à jour de l'affichage dans votre interface graphique
                lbl_nb_comm.Text = nb_comm_attente.ToString();

                // Vider le tableau
                dataGridView1.Rows.Clear();

                // DONNÉES TEMPORAIRES (placées ici au lieu du Paint)
                dataGridView1.Rows.Add("#0001", "20/05/2026", "3", "3500€", "Préparer");
                dataGridView1.Rows.Add("#0002", "20/05/2026", "8", "120€", "Préparer");
                dataGridView1.Rows.Add("#0003", "20/05/2026", "1", "20€", "Préparer");
                dataGridView1.Rows.Add("#0004", "20/05/2026", "1", "20€", "Préparer");
                dataGridView1.Rows.Add("#0005", "20/05/2026", "1", "20€", "Préparer");
                dataGridView1.Rows.Add("#0006", "20/05/2026", "1", "20€", "Préparer");


               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de contacter l'API : " + ex.Message);
            }
        }


    }
}
