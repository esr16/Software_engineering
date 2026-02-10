namespace SE_L5_Workshop;
public class FatherProcessus
{
    public FatherProcessus()
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Démarrage exercice1");
        SonProcessus program = new SonProcessus("Louis", 12);
        Console.WriteLine("Finish");
        Console.WriteLine("---");
        Console.WriteLine("Démarrage exercice2");
        Explorer explorer = new Explorer();
        Console.WriteLine("Finish");
        Console.WriteLine("---");
        Console.WriteLine("Démarrage exercice3");
        Notepad notepad = new Notepad();
        Console.WriteLine("Finish");
    }
    
}