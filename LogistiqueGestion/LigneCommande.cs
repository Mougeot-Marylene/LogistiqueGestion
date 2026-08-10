


namespace LogistiqueGestion;

internal class LigneCommande
{
    public int Id { get; set; }
    public int CommandeId { get; set; }
    public int ProduitId { get; set; }
    public string? NomProduit { get; set; }
    public int Quantite { get; set; }
    public bool EstRamasse { get; set; }
    public bool EstEmballe { get; set; }
    public string? NomClient { get; set; }
    public string? PrenomClient { get; set; }

    public static implicit operator int(LigneCommande v)
    {
        throw new NotImplementedException();
    }
}

internal class GetLigneCommandeResponse
{
    public IEnumerable<LigneCommande>? Items { get; set; }
}