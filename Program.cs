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

        // Exercice 3
        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p3);
        panier.Add(p2);
        Console.WriteLine(panier.Count);

        // Exercice 4
        ProduitPerissable article = new ProduitPerissable("B05","Lait",15,5);
        Console.WriteLine(article.GetType());

        // Exercice 5
        List<Object> Inventaire = new List<Object>();
        Inventaire.Add(5);
        Inventaire.Add("Dépot du nsm");
        Inventaire.Add(p1);
        foreach (var item in Inventaire)
        {
            Console.WriteLine(item.GetType());
            Console.WriteLine(item.ToString());
            if (item is Produit)
            {
                Produit prod = (Produit)item;
                Console.WriteLine(prod.GetCodeArticle());
            }
        }
    }
}
