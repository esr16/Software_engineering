using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM;

public class MainViewModel : INotifyPropertyChanged
{
    
    //Propriétés
    private string _nameinput;
    private string _firstnameinput;
    private int _ageinput;
    
    public string NameInput
    {
        get { return _nameinput; }
        set
        {
            _nameinput = value;
            OnPropertyChange(nameof(NameInput));
        }
    }
    
    public string FirstnameInput
    {
        get { return _firstnameinput; }
        set
        {
            _firstnameinput = value;
            OnPropertyChange(nameof(FirstnameInput));
        }
    }
    
    public int AgeInput
    {
        get { return _ageinput; }
        set
        {
            _ageinput = value;
            OnPropertyChange(nameof(AgeInput));
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChange(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
    }
    
    
    // Liste des personnes Observable au lieu d'une liste de base
    public ObservableCollection<Person> Personnes { get; } = new();
    
    // Commande pour bouton

    public RelayCommand ValiderCommand { get; }
    public MainViewModel()
    {
        ValiderCommand = new RelayCommand(Valider);
    }
    private void Valider()
    {
        Personnes.Add(new Person(NameInput, FirstnameInput, AgeInput));
        NameInput = string.Empty;
        FirstnameInput = string.Empty;
        AgeInput = 0;
    }
    
    //INotifyPropertyChanged
    private static void Person_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        Console.WriteLine($"Propriété modifiée : {e.PropertyName}");
    }
    
    
    
}