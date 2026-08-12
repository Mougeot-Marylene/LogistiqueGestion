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
        API _api;
        public UC_ToutesCommandeAEmballees()
        {
            InitializeComponent();
            // CETTE LIGNE EST OBLIGATOIRE POUR QUE L'ÉVÉNEMENT SE DÉCLENCHE !
            this.Load += UC_ToutesCommandeAEmballees_Load;

            /* Mettre titre colonne au centre */
            // Le chiffre 3 correspond à la 4ème colonne
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Le chiffre 2 correspond à la 3ème colonne
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Le chiffre 4 correspond à la 5ème colonne
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // L'événement Load permet d'utiliser 'async void' en toute sécurité dans WinForms
        private async void UC_ToutesCommandeAEmballees_Load(object sender, EventArgs e)
        {
            _api = new();
            // appel methode pour afficher les commandes en attentes
            await ChargerCommandes();
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

        private async Task ChargerCommandes()
        {

            try
            {
                /* ------------------------------------
                  Tableau des commandes à emballées
                  ------------------------------------
                */

                // DONNÉES TEMPORAIRES (placées ici au lieu du Paint)
                var resultLigneCommEmballer = await _api.GetRESTAsync<GetLigneCommandeResponse>("http://localhost:5287/api/LigneCommandes/Emballer");
                //dataGridView1.Rows.Add(item.Id.ToString(), "20/05/2026", "3", "3500€", "Préparer"); 
                var lignecommandesEmballer = (resultLigneCommEmballer?.Items ?? Enumerable.Empty<LigneCommande>()).ToList();

                // Regroupement par CommandeId
                var commandesGroupees = lignecommandesEmballer
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
                        "Emballer"
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
