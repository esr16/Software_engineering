namespace SE_Bases;

// Classe abstraite : classe incomplète qui ne peut pas être instanciée
abstract class AbstractClass
{
    public abstract void AbstractMethods();
};

// Classe scéllée : classe qui ne peut pas être dérivée (pas de base pour héritage)
sealed class SealedClass
{
    private string Parameters;

    public SealedClass()
    {
        Parameters = "Sealed";
    }

    public void DisplayParameters()
    {
        Console.WriteLine($"Sealed Class : {Parameters}");
    }
}

// Classe statique : classe qui ne peut pas être instanciée
static class StaticClass
{
    public static int Parameters;

    static StaticClass()
    {
        Parameters = 2;
    }
    public static int AddParameters(int a)
    {
        int result = a + Parameters;
        return result;
    }
}

// Classe partielle : classe qui peut être définie en plusieurs fois
partial class PartialClass
{
    public string Parameter1;
}

partial class PartialClass
{
    public PartialClass(string parameter1)
    {
        Parameter1 = parameter1;
    }

    public void DisplayParameters()
    {
        Console.WriteLine($"Partial class,: Parameter = {Parameter1}");
    }
}

// Classe générique : classe dont le type n'est pas fixé à la définition mais peut être spécifié au moment de l'utilisation 
class GenericClass<T>
{
    public T Parameter;
    // Si on spécifie pas de constructeurs, ça sera null, 0, false par défaut
    // Sinon on mais un constructeur spécifique

    public GenericClass(T parameter)
    {
        Parameter = parameter;
    }
    
    public void DisplayParameters()
    {
        Console.WriteLine($"Generic Class : {Parameter}");
    }
}