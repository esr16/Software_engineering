using Models;
using ViewModels;
using Views;

public class Program
{
    static void Main(string[] args)
    {
        var mod = new User();
        var vm = new UserViewModel(mod);
        var view = new UserView(vm);
        view.Run();
    }
}