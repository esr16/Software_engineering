using System.Threading.Tasks.Dataflow;
using Models;
using static System.Console;

namespace ViewModels;

public class UserViewModel
{
    private readonly User _user;
    public UserViewModel(User user)
    {
        _user = user;
    }

    public bool CheckNumberChar(string chaine)
    {
        var length = chaine.Length;
        if (length < 8 && length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Transform(string chaine)
    {
        bool entry = CheckNumberChar(chaine);
        if (entry)
        {
            return _user.TransformChar(chaine);
        }
        else
        {
            Console.WriteLine($"Error : {_user.Chaine} has more that 8 characters");
            return string.Empty;
        }
        
    }
        
    
}