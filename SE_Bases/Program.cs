using SE_Bases;

public class Program
{
    public static void Main(string[] args)
    {
        // Constructeurs
        Console.WriteLine("Sortie des constructeurs!");
        ConstructorsWithoutParameters without = new ConstructorsWithoutParameters();
        without.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithParameters with = new ConstructorWithParameters("with");
        with.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithAndWithoutParameters withandwithout1 = new ConstructorWithAndWithoutParameters();
        withandwithout1.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithAndWithoutParameters withandwithout2 = new ConstructorWithAndWithoutParameters("withandwithout");
        withandwithout2.DisplayParameters();
        Console.WriteLine("=================================================");
        
        // Classes
        Console.WriteLine("Sortie des classes!");
        
        int result = StaticClass.AddParameters(3);
        Console.WriteLine($"sortie de class static (cense etre 5) : result = {result}");
        Console.WriteLine("---");
        
        SealedClass seal = new SealedClass();
        seal.DisplayParameters();
        Console.WriteLine("---");
        
        PartialClass part = new PartialClass("partial");
        part.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<string> gen = new GenericClass<string>("generic string");
        gen.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<int> gen2 = new GenericClass<int>(5);
        gen2.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<bool> gen3 = new GenericClass<bool>(true);
        gen3.DisplayParameters();
        Console.WriteLine("=================================================");

        // Methods
        Console.WriteLine("Sortie des méthodes!");
        MethodsNormal normalvoid = new MethodsNormal("method void normal");
        normalvoid.DisplayParameter();
        normalvoid.UppercaseParameter(normalvoid.Parameter1);
        Console.WriteLine("---");

        MethodsStatic.DisplayParameter();
        MethodsVirtuelSuperClass virtualsuper = new MethodsVirtuelSuperClass("virtualsuper");
        virtualsuper.Behavior();
        virtualsuper.TransformParameter(virtualsuper.Parameter);
        Console.WriteLine("---");
        
        MethodsVirtualSubClass overridevirtual = new MethodsVirtualSubClass("OVERRIDEVIRTUAL");
        overridevirtual.Behavior();
        overridevirtual.TransformParameter(overridevirtual.Parameter);
        Console.WriteLine("---");
        
        MethodsAbstractImplementation abstractimplementation = new MethodsAbstractImplementation("abstractimplementation");
        abstractimplementation.Behavior();
        Console.WriteLine("Fin");
        
    }
}