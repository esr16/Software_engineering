namespace Delegue2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    
public delegate void delg();

public class A
{
    public void ma()
    {
        Console.WriteLine("ma");
    }
}
public class B
{
    public void mb()
    {
        Console.WriteLine("mb");
    }
}

public class C
{
    delegate void delegue(); //définir un délégué
    List<delegue> listdelegue = new List<delegue>();
    
    
    public C()
    {
        listdelegue.Add(Mondelegue1);
        listdelegue.Add(Mondelegue2);
        listdelegue.Add(Mondelegue3);
    }
    
    void Mondelegue1()
    {
        Console.WriteLine("Hello depuis Mondelegue1");
    }
    void Mondelegue2()
    {
        Console.WriteLine("Hello depuis Mondelegue2");
    }
    void Mondelegue3()
    {
        Console.WriteLine("Hello depuis Mondelegue3");
    }

    

}