namespace SE_Bases;

public interface IPaiement //Pas de champ
{
    public bool Payer();
}

public class CarteBleue : IPaiement
{
    public bool Payer()
    {
        Console.WriteLine("Paiement par Carte Bleue");
        return true;
    }
}

public class Paypal : IPaiement
{
    public bool Payer()
    {
        Console.WriteLine("Paiement par Paypal");
        return true;
    }
}

public class Command
{
    public IPaiement Paiement;

    public Command(IPaiement paiement)
    {
        Paiement = paiement;
    }

    public void Valider(IPaiement p)
    {
        if (p.Payer())
        {
            Console.WriteLine("Paiement validé");
        }
        else
        {
            Console.WriteLine("Paiement non validé");
        }
    }
    
}