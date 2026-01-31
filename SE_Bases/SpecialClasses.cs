namespace SE_Bases;


// interface
public class IClass
{
    public string Iparameter { get; set; }

    public void DisplayIParameter(){}
}

public class IImplementation : IClass
{
    public IImplementation(string iparameter)
    {
        this.Iparameter = iparameter;
    }

    public void DisplayIParameter()
    {
        Console.WriteLine($"Iparameter override: {Iparameter}");
    }
}

// abstract

public abstract class AbstractClass2
{
    protected string Aparameter { get; set; }

    public AbstractClass2(string aparameter)
    {
        this.Aparameter = aparameter;
    }
    public abstract void DisplayIParameter();
    public void DefaultDisplay()
    {
        Console.WriteLine($"Abstract default display: {Aparameter}");
    }
}

public class AImplementation : AbstractClass2
{
    public AImplementation(string aparameter) : base(aparameter){}

    public override void DisplayIParameter()
    {
        Console.WriteLine($"Aparameter override: {Aparameter}");
    }
    
}

public class VirtualClass2
{
    public string Vparameter;
    
    public VirtualClass2(string vparameter)
    {
        Vparameter = vparameter;
    }

    public virtual void DisplayIParameter()
    {
        Console.WriteLine($"Vparameter default: {Vparameter}");
    }
}

public class VImplementation : VirtualClass2
{
    public VImplementation(string vparameter) : base(vparameter){}

    public override void DisplayIParameter()
    {
        Console.WriteLine($"Vparameter override: {Vparameter}");
    }
}

