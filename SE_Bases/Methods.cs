namespace SE_Bases;

public class MethodsNormal
{
    public string Parameter1;

    public MethodsNormal(string parameter1)
    {
        Parameter1 = parameter1;
    }
    
    //Fonction void : ne retourne rien, sert à faire un truc genre modifier un étate, afficher un truc
    public void DisplayParameter()
    {
        Console.WriteLine($"Classe classique, methode void : {Parameter1}");
    }
    
    // Fonction avec type pour retourner / transformer une information
    public string UppercaseParameter(string parameter)
    {
        var upper =  parameter.ToUpper();
        Console.WriteLine($"Classe classique, methode string : {upper}");
        return parameter.ToUpper();
    }
}

public class MethodsStatic
{
    public static string Parameter;

    static MethodsStatic()
    {
        Parameter = "parameter";
    }

    public static void DisplayParameter()
    {
        Console.WriteLine(Parameter);
    }

    public static string UpperParameter(string parameter)
    {
        return parameter.ToUpper();
    }
}

public class MethodsVirtuelSuperClass
{
    public string Parameter;

    public MethodsVirtuelSuperClass(string parameter)
    {
        Parameter = parameter;
    }

    public virtual void Behavior()
    {
        Console.WriteLine($"Virtual behavior : {Parameter}");
    }

    public virtual string TransformParameter(string parameter)
    {
        var upper = parameter.ToUpper();
        Console.WriteLine($"Virtual Transform : {upper}");
        return upper;
    }
}

public class MethodsVirtualSubClass : MethodsVirtuelSuperClass
{
    public MethodsVirtualSubClass(string parameter) : base(parameter)
    {}

    public override void Behavior()
    {
        Console.WriteLine($"Override of VirtualBehavior: {Parameter}");
    }

    public override string TransformParameter(string parameter)
    {
        var lower = parameter.ToLower();
        Console.WriteLine($"Override of Virtual Transform : {lower}");
        return lower;
    }
}


public abstract class MethodsAbstract
{
    public string Parameter;

    public MethodsAbstract(string parameter)
    {
        Parameter = parameter;
    }

    public abstract void Behavior();
}

public class MethodsAbstractImplementation : MethodsAbstract
{
    public MethodsAbstractImplementation(string parameter) : base(parameter)
    {
        
    }

    public override void Behavior()
    {
        Console.WriteLine($"Override Behavior de abstract: {Parameter}");
    }
}