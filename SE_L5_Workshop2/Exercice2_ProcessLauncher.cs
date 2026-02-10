using System.Diagnostics;

namespace SE_L5_Workshop2;

public class ProcessLauncher
{
    public void Execute(string exe, string? arg0)
    {
        Console.WriteLine($"Lancement de {exe}");
        if (arg0 != null)
        {
            Process process = Process.Start(exe, arg0);
            Console.WriteLine($"Processus {process.ProcessName} n° {process.Id}");
            Console.WriteLine("---");
        }
        else
        {
            Process process = Process.Start(exe);
            Console.WriteLine($"Processus {process.ProcessName} n° {process.Id}");
            Console.WriteLine("---");
        }
    }

    public void LaunchAndWait(string exe, string? arg0)
    {
        if (arg0 != null)
        {
            Process process = Process.Start(exe, arg0);
            Console.WriteLine($"Processus {process.ProcessName} n° {process.Id}");
            process.WaitForExit();
            Console.WriteLine("---");
        }
        else
        {
            Process process = Process.Start(exe);
            Console.WriteLine($"Processus {process.ProcessName} n° {process.Id}");
            process.WaitForExit();
            Console.WriteLine("---");
        } 
    }
    
    
}