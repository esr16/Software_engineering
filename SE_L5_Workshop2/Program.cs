using SE_L5_Workshop2;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            ProcessLauncher test1 =  new ProcessLauncher();
            test1.LaunchAndWait("SE_L5_Workshop2", "Elodie 1000");
            Thread.Sleep(2000);
            test1.LaunchAndWait("explorer.exe",null);
            Thread.Sleep(2000);
            test1.LaunchAndWait("notepad.exe",null);
        }
        else
        {
            ConsoleHelloWorld test = new ConsoleHelloWorld(args);  
        }
        
        
        
    }
}