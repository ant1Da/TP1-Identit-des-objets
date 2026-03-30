namespace TP1_Classe_Object;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit("1754863254","LEGO Batman 4",69.99);
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p1);

        // Exercice 2
        Produit p2 = new Produit("AO", "Souris", 15);
        Produit p3 = new Produit("AO", "Souris", 15);
        Console.WriteLine(p2.Equals(p3));
        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p3);
        panier.Add(p2);
        Console.WriteLine(panier.Count);
    }
}
