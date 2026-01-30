using Elements_ns;
using Universe_ns;
    public class Program
    {
        static void Main(string[] args)
        {
            Universe u = new Universe(4,2);
            
            List<Elements> elementslist = new List<Elements>();
            {
          
                elementslist.Add(new Elements(u.DimensionX, u.DimensionY,1,2,"Carbone", "C", 12.01074 )); //on peu mettre Elements Carbone ou var Carbone C# comprend tout seul à partir du constructeur
                elementslist.Add(new Elements(u.DimensionX, u.DimensionY,2,-1,"Hydrogene", "H", 1.00794));
                elementslist.Add(new Elements(u.DimensionX, u.DimensionY,1,2,"Lithium", "L", 6.941));
                //elementslist.Add(new Elements(u.DimensionX, u.DimensionY,2,4,"Lithium", "L", 6.941));
            }
            ;

            foreach (Elements e in elementslist)
            {
                
                e.DisplayElements();
            }
            
            //u.CheckDouble(elementslist);
            u.CheckPosition(elementslist);
            
        }
    
    
    }
