namespace SE_Bases;

public abstract class Vehicule
{
    public abstract void Demarrer();
}

public class Voiture : Vehicule
{
    public override void Demarrer()
    {
        Console.WriteLine("Je démarre je suis une voiture vroom vroom");
    }
}

public class Moto : Vehicule
{
    public override void Demarrer()
    {
        Console.WriteLine("Je démarre je suis une moto mmeeeeh mmeeeh");
    }
}

public class Garage

{
    public List<Vehicule> Vehicules = new();

    public Garage()
    {
    }

    public void AddVehicule(Vehicule vehicule)
    {
        Vehicules.Add(vehicule);
    }

    public void DemarrerTous()
    {
        Console.WriteLine("C'est le garage");
        foreach (Vehicule vehicule in Vehicules)
        {
            vehicule.Demarrer();
        }
    }
}
