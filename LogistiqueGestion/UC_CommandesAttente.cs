
namespace LogistiqueGestion
{
    public partial class UC_CommandesAttente : UserControl
    {
        API _api;
        public UC_CommandesAttente(int commandeId)
        {
            InitializeComponent();
            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_CommandesAttente_Load;

            // Center le titre de la colonne du tableau, Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Remplace 'dataGridView1' par le nom de ton tableau si besoin
            // Le chiffre 2 correspond à ta 3ème colonne (N° commande = 0, Date = 1, Nombre de produits = 2)
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /// Abonner l'événement au clic sur une cellule du tableau
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        // L'événement Load permet d'utiliser 'async void' en toute sécurité dans WinForms
        private async void UC_CommandesAttente_Load(object sender, EventArgs e)
        {
            _api = new();
            // appel methode pour afficher les commandes
            await ChargerCommandes();
        }


        //ouverture de UC_PrepaCommande (lien preparer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que c'est la colonne "préparer" qui est cliquée et pas l'en-tête
            if (dataGridView1.Columns[e.ColumnIndex].Name == "preparer" && e.RowIndex >= 0)
            {
                //  RÉCUPÉRER L'ID DE LA COMMANDE DANS LA LIGNE CLIQUÉE (1ère colonne / index 0)
                int selectedCommandeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                // Créer une instance du UserControl UC_PrepasCommande
                UC_PrepasCommande uc = new UC_PrepasCommande(selectedCommandeId);

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
                /* ------------------------------------
                  Tableau des commandes en attentes
                  ------------------------------------
                */

                // DONNÉES TEMPORAIRES (placées ici au lieu du Paint)
                var resultLigneCommAttente = await _api.GetRESTAsync<GetLigneCommandeResponse>("http://localhost:5287/api/LigneCommandes/EnAttente");
                
                var lignecommandesAttente = (resultLigneCommAttente?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();

                // Regroupement par CommandeId
                var commandesGroupees = lignecommandesAttente
                    .GroupBy(l => l.CommandeId)
                    .Select(g => new
                    {
                        CommandeId = g.Key,
                        // Récupère la date de la première ligne
                        Date = g.First().Date,
                        // Somme des quantités de produits
                        QuantiteTotale = g.Sum(x => x.Quantite),
                        // Somme du (PrixUnitaire * Quantite) ou PrixTotal de chaque ligne
                        PrixTotalCommande = g.Sum(x => x.PrixTotal) // Somme directe du PrixTotal déjà calculé dans la requette
                    });


                // Vider le tableau
                dataGridView1.Rows.Clear();

                foreach (var item in commandesGroupees)
                {
                    dataGridView1.Rows.Add(
                        item.CommandeId.ToString(),
                        item.Date,
                        item.QuantiteTotale,
                        item.PrixTotalCommande.ToString() + " €",
                        "Préparer"
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de contacter l'API : " + ex.Message);
            }
        }


    }
}
