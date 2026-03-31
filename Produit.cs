using System.ComponentModel;

class Produit
{
    private string codeArticle;
    private string designation;
    private double prix;
    public Produit(string code, string nom, double px)
    {
        this.codeArticle = code;
        this.designation = nom;
        this.prix = px;
    }
    public string GetCodeArticle()
    {
        return codeArticle;
    }
    public string GetDesignation()
    {
        return designation;
    }
    public string GetPrix()
    {
        return prix.ToString();
    }
    public override string ToString()
    {
        return $"Code: {this.codeArticle}, Designation: {this.designation}, Prix: {this.prix}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Produit autre)
        {
            return this.codeArticle == autre.codeArticle;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return codeArticle.GetHashCode();
    }
}