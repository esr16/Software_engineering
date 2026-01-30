using System.ComponentModel;

namespace Models;

public class User 
{
    public string Chaine;

    public User()
    {
    }

    public string TransformChar(string chaine)
    {
        string chaineUp = chaine.ToString().ToUpper();
        return chaineUp;
    }
        
}