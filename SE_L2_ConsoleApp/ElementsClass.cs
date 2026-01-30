using Universe_ns;

namespace Elements_ns;

public class Elements : Universe
{
    //quand on a le constructeur, on peut enlever cette partie et le C# comprend tout seul les attributs
    public double PositionX;
    public double PositionY;
    public string Name;
    public string Symbole;
    public double Mass;

    public Elements(double dimensionx, double dimensiony, double positionx, double positiony, string name, string symbole, double mass)//Quand name methode = nom classe, le C# comprend que c'est le constructeur et il l'interprète en void direct
        : base(dimensionx, dimensiony)
    { 
        DimensionX = dimensionx;
        DimensionY = dimensiony;
        PositionX = positionx;
        PositionY = positiony;
        Name = name;
        Symbole = symbole;
        Mass = mass;
    }

    public void DisplayElements()
    {
        Console.WriteLine($"Elements constructor : x:{DimensionX}, y:{DimensionY}, {Name}, {Symbole}, {Mass}");
    }
}