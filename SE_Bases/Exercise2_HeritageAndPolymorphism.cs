namespace SE_Bases;

public abstract class Animal
{
    protected string _nom;

    public string Nom
    {
        get { return _nom;}

        set { _nom = value; }
    }

    public virtual void SePresenter()
    {
        Console.WriteLine($"Je m'appelle {Nom}");
    }
    public abstract void FaireDuBruit();

    public virtual void SeDeplacer()
    {
        Console.WriteLine("Je me déplace bitch");
    }
}

public class Chien : Animal
{
    public Chien(string nom)
    {
        Nom = nom;
    }
    public override void FaireDuBruit()
    {
        Console.WriteLine("Ouaf Ouaf");
    }

    public override void SeDeplacer()
    {
        Console.WriteLine("Je me déplace Ouaf Ouaf");
    }

    public override void SePresenter()
    {
        Console.WriteLine($"Je suis un chien, je m'appelle {Nom}");
    }
}

public class Chat : Animal
{
    public Chat(string nom)
    {
        Nom = nom;
    }
    public override void FaireDuBruit()
    {
        Console.WriteLine("Miaou Miaou");
        
    }

    public override void SeDeplacer()
    {
        Console.WriteLine("Je me déplace Miaou Miaou");
        ;
    }
    
    public override void SePresenter()
    {
        Console.WriteLine($"Je suis un chat, je m'appelle {Nom}");
    }
}