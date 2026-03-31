class ProduitPerissable : Produit
{
    private int joursAvantPeremption;
    public ProduitPerissable(string c, string n, double p, int j) : base(c, n, p)
    {
        this.joursAvantPeremption = j;
    }
    public int GetJoursAvantPeremption()
    {
        return joursAvantPeremption;
    }
}