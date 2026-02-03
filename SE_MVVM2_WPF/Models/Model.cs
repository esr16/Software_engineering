using System.ComponentModel;

namespace MVVM;


public class Person 
{
    private string _name;
    private string _firstname;
    private int _age;

    public string Name
    {
        get { return _name;}
        set
        {
            if (value != null)
            {
                _name = value;
            }
        }

    }

    public string FirstName
    {
        get { return _firstname;}
        set
        {
            if (value != null)
            {
                _firstname = value;
            }
        }
    }
    
    public int Age
    {
        get { return _age;}
        set
        {
            if (value != null)
            {
                _age = value;
            }
        }
    }

    public Person(string firstname, string lastname, int age)
    {
        Name = firstname;
        FirstName = lastname;
        Age = age;
    }
    

   
}