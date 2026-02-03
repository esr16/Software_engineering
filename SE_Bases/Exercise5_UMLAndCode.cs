using System.Data.Common;

namespace SE_Bases;

public class Adresses
{
    private string _adresse;

    public string Adresse
    {
        get { return _adresse; }
        set { if (_adresse!=null && value != null){_adresse = value;}else{Console.WriteLine("Adresse is empty");} }
    }

    public Adresses(string adresse)
    {
        _adresse = adresse;
    }
}
public class Client
{
    private string _name;
    private int _age;
    public Adresses Adresse;
    

    public string Name // le nom ne peut pas être nul
    {
        get
        {
            return string.Empty;
        }
        set
        {
            if (value != null)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("New Name is empty");
            }
        }
    }

    public int Age // l'âge peut être nul
    {
        get { return _age; }
        set { _age = value; }
    }

    public Client(string name, int age, Adresses adresse)
    {
        _name = name;
        _age = age;
        Adresse = adresse;
    }
}

public class LigneCommande2
{
    private string _produit;
    private int _quantite;

    public string Produit
    {
        get { return _produit; }
        set {if(_produit!=null && value != null){_produit = value;}else{Console.WriteLine("Produit is empty");} }
    }
    public int Quantite
    {
        get { return _quantite; }
        set { _quantite = value; }
    }

    public LigneCommande2(string produit, int quantite)
    {
        _produit = produit;
        _quantite = quantite;
    }
    
}
public class Commande2
{
    private List<LigneCommande2> lignes = new();

    public Commande2()
    {
    }

    public void AddLignesCommandes(string produit, int quantite)
    {
        lignes.Add(new LigneCommande2(produit, quantite));
    }
    
}


public interface IPaiement2
{
    public bool Payer(Commande2 commande2);
    public void Valider(IPaiement2 paiement, Commande2 commande2);
}

public class Paypal2 : IPaiement2
{
    
    public bool Payer(Commande2 commande2)
    {
        if (commande2 != null)
        {
            Console.WriteLine("Paiement par Paypal");
            return true;
        }
        else
        {
            Console.WriteLine("Commande est nulle, vous pouvez pas payer");
            return false;
        }
    }
    public void Valider(IPaiement2 paiement,Commande2 commande2)
    {
        if (paiement.Payer(commande2))
        {
            Console.WriteLine("Payer valider");
        }
        else
        {
            Console.WriteLine("Payer pas valider");
        }
    }
}

public class CarteBleue2 : IPaiement2
{
    public bool Payer(Commande2 commande2)
    {
        if (commande2 != null)
        {
            Console.WriteLine("Paiement par CarteBleue");
            return true;
        }
        else
        {
            Console.WriteLine("Commande est nulle, vous pouvez pas payer");
            return false;
        }
    }
    
    public void Valider(IPaiement2 paiement, Commande2 commande2)
    {
        if (paiement.Payer(commande2))
        {
            Console.WriteLine("Payer valider");
        }
        else
        {
            Console.WriteLine("Payer pas valider");
        }
    }
}