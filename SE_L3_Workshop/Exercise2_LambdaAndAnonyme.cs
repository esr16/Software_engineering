namespace LambdaAndAnonyme;

public class ClassLambdaAndAnonyme
{
    public Func<int,int> carre = x => x * x;

    private Func<int,int,int> _addition = (x, y) => x + y;
    
    
    private readonly Func<int,int,int> _substraction = (x, y) => x - y;

    // Propriétés pour lambda
    public Func<int, int, int> Addition
    {
        get { return _addition; }
        set //le setter attend un lambda mais pas en paramètres
        {
            if (value != null)
            {
                _addition = value;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
    
    // lambda mais qu'on veut pas modifier du tout (readonly)

    public Func<int, int, int> Substraction
    {
        get { return _substraction; }
        
    }
    
    // bricolage de setter pour changer lambda en un autre
    public int Division(Func<int,int,int> division, int x, int y)
    {
        division = _addition;
        return division(x, y);
    }
}