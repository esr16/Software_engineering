using System.Text;

namespace SE_Bases;

public class Person
{
    public string Name;
    private int _age;
    public  int Age
    {
        get { return _age;} set{_age = value; }}
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayOwner()
    {
        Console.WriteLine($"{this.Name}, {this.Age}");
    }
    
}

public class BankAccount
{
    public Person Owner;
    private decimal _solde;
    public decimal Solde
    {
        get { return _solde;} set{_solde = value;} }

    public BankAccount(Person owner, decimal solde)
    {
        Owner = owner;
        Solde = solde;
    }

    public decimal Deposer(decimal montant)
    {
        Console.WriteLine($"Votre montant est maintenant de {this.Solde+montant} ");
       return Solde = Solde + montant;
    }

    public decimal Retirer(decimal montant)
    {
        if (Solde - montant < 0)
        {
            Console.Write("Solde insuffisant \n");
            return Solde;
        }
        else
        {
            Console.WriteLine($"Votre montant de {Solde} ");
            return Solde = Solde - montant;
        }
    }

    public void DisplaySolde()
    {
        Console.WriteLine($"Owner : {Owner.Name}, {Owner.Age} ans , Solde: {this.Solde}"); //pourquoi je peux pas faire Owner.Age
    }

}