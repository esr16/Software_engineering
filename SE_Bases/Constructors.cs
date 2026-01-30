namespace SE_Bases;

public class ConstructorsWithoutParameters
{
  public string Parameters;

  public ConstructorsWithoutParameters()
  {
   Parameters = "without parameters";
  }

  public void DisplayParameters()
  {
      Console.WriteLine($"Constructor without parameter : {Parameters}");
  }
};

public class ConstructorWithParameters
{
  public string Parameters;

  public ConstructorWithParameters(string parameters)
  {
   Parameters = parameters;
  }
  public void DisplayParameters()
  {
      Console.WriteLine($"Constructor with parameter : {Parameters}");
  }
}

public class ConstructorWithAndWithoutParameters
{
    public string Parameter;
    
    public ConstructorWithAndWithoutParameters()
    {
      Parameter = "sans parametres";
    }

    public ConstructorWithAndWithoutParameters(string parameters)
    {
        Parameter = parameters;
    }
    
    public void DisplayParameters()
    {
        Console.WriteLine($"Constructor with and without parameter : {Parameter}");
    }
}