namespace SE_L5_Workshop2;

public class ConsoleHelloWorld
{
    public ConsoleHelloWorld(string[] args)
    {
        Displays(args);
    }
    public void Displays(string[] args)
    {
        Console.WriteLine($"Hello World {args[0]}, {args[1]}!");
    }
}