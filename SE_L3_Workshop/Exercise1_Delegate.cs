namespace Delegue;

public class ClassDelegate
{
    public delegate int mondelegue(int v1, int v2);

    public int mamethode(int v1, int v2)
    {
        int result = v1 + v2;
        Console.WriteLine($"Mon délégué : {result} (5)");
        return result;
    }
}
