using ViewModels;

namespace Views;

public class UserView
{
    private readonly UserViewModel _vm;
    public UserView(UserViewModel vm)
    {
        _vm = vm;
    }
    
    public void Run()
    {
        string chaine = Console.ReadLine();
        _vm.Transform(chaine);
        
    }   
}