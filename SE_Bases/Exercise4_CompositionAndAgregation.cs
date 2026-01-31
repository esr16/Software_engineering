namespace SE_Bases;

public class LigneCommande
{
    private string _produit;
    private int _quantite;

    public string Produit
    {
        get
        {
            if (_produit != null)
            {
                return _produit;
            }
            else
            {
                return string.Empty;
            }
        }
        set
        {
            if (value != null)
            {
                _produit = value;
            }
            else
            {
                Console.WriteLine("Error : Produit nul");
            }
        }
    }
    
    public int Quantite
    {
        get { return _quantite; }
        set { _quantite = value; }
    }

    public LigneCommande(string produit, int quantite)
    {
        _produit = produit;
        _quantite = quantite;
    }
}

public class Commande
{
    public List<LigneCommande> lignes = new(); // ce champ doit être public ? peut etre privé ?
    

    public Commande()
    {
        lignes.Add(new LigneCommande("Produit1", 4));
        lignes.Add(new LigneCommande("Produit2", 5));
        lignes.Add(new LigneCommande("Produit3", 6));
        lignes.Add(new LigneCommande("Produit4", 7));
        lignes.Add(new LigneCommande("Produit5", 8));
        
    }

    public virtual void DisplayLignes()
    {
        foreach (var ligne in lignes)
        {
            Console.WriteLine(ligne.Produit);
        }
    }
    
}

public class Panier : Commande
{
    public Commande Commande;

    public Panier(Commande commande)
    {
        Commande = commande;
    }
    
    
}