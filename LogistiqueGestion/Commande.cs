

namespace LogistiqueGestion;

internal class Commande
{
    public int Id { get; set; }
    public int Statut { get; set; }
    public  string NomUtilisateur { get; set; }
    public  string PrenomUtilisateur { get; set; }
}
internal class GetCommandeResponse
{
    public IEnumerable<Commande>? Items { get; set; }
}

