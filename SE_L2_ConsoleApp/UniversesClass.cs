using Elements_ns;

namespace Universe_ns;

public class Universe
{
    public double DimensionX;
    public double DimensionY;

    public Universe(double dimensionX, double dimensionY)
    {
        DimensionX=dimensionX;
        DimensionY = dimensionY;
    }

    public void DisplayDimension()
    {
        Console.WriteLine($"Dimensions x : {DimensionX}, Dimensions Y : {DimensionY}");
    }

    public void CheckDouble(List<Elements> elementslist)
    {
        var count = 0;
        foreach (Elements i in elementslist)
        {
            foreach (Elements j in elementslist)
            {
                if (i != j)
                {
                    if ( j.Name == i.Name || j.Symbole == i.Symbole || j.Mass == i.Mass)
                    {
                        count += 1;
                        Console.WriteLine($"Element {i.Name} is duplicate in the Universe");
                    }
                }
            }
        }
        if (count==0)
        {
            Console.WriteLine($"No element is duplicate in the Universe");
        }
    }

    public void CheckPosition(List<Elements> elementslist)
    {
        var count = false;
        foreach (Elements i in elementslist)
        {
            foreach (Elements j in elementslist)
            {
                if (i != j)
                {
                    if (j.PositionX == i.PositionX && j.PositionY == i.PositionY)
                    {
                        count = true;
                        Console.WriteLine($"Element {i.Name} and {j.Name} are in the same position in the Universe");
                    }
                }
            }
        }

        if (!count)
        {
            Console.WriteLine($"No element has the same position in the Universe");
        }
    }

    public void CheckOutside(Elements e)
    {
        var range_vector = DimensionX*DimensionX + DimensionY*DimensionY;
        var element_is_inside = e.PositionX*e.PositionX - e.PositionX*e.PositionY;
        if (element_is_inside > range_vector)
        {
            Console.WriteLine($"Error : the element is outside of the Universe");
        }
    }
}
