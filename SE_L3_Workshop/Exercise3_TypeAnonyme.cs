namespace TypeAnonyme;

public class ClassTypeAnonyme
{
    
    // Type dans méthode
    public void MethodeAnonyme()
    {
        var anonyme = new { Nom = "Louis bébé d'amour", Age = 20 };
        Console.WriteLine($"Type dans méthode void : {anonyme.Nom}, {anonyme.Age}");
    }
    
    // Type dans dynamic

    public dynamic MethodeAnonyme2()
    {
        return new { Nom = "Louis bébé d'amour", Age = 20 };
    }
    
    // Type dans object
    
}