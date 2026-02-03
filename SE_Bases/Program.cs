using SE_Bases;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        // Constructeurs
        Console.WriteLine("Sortie des constructeurs!");
        ConstructorsWithoutParameters without = new ConstructorsWithoutParameters();
        without.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithParameters with = new ConstructorWithParameters("with");
        with.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithAndWithoutParameters withandwithout1 = new ConstructorWithAndWithoutParameters();
        withandwithout1.DisplayParameters();
        Console.WriteLine("---");
        ConstructorWithAndWithoutParameters withandwithout2 = new ConstructorWithAndWithoutParameters("withandwithout");
        withandwithout2.DisplayParameters();
        Console.WriteLine("=================================================");
        
        // Classes
        Console.WriteLine("Sortie des classes!");
        
        int result = StaticClass.AddParameters(3);
        Console.WriteLine($"sortie de class static (cense etre 5) : result = {result}");
        Console.WriteLine("---");
        
        SealedClass seal = new SealedClass();
        seal.DisplayParameters();
        Console.WriteLine("---");
        
        PartialClass part = new PartialClass("partial");
        part.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<string> gen = new GenericClass<string>("generic string");
        gen.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<int> gen2 = new GenericClass<int>(5);
        gen2.DisplayParameters();
        Console.WriteLine("---");
        
        GenericClass<bool> gen3 = new GenericClass<bool>(true);
        gen3.DisplayParameters();
        Console.WriteLine("=================================================");

        // Methods
        Console.WriteLine("Sortie des méthodes!");
        MethodsNormal normalvoid = new MethodsNormal("method void normal");
        normalvoid.DisplayParameter();
        normalvoid.UppercaseParameter(normalvoid.Parameter1);
        Console.WriteLine("---");

        MethodsStatic.DisplayParameter();
        MethodsVirtuelSuperClass virtualsuper = new MethodsVirtuelSuperClass("virtualsuper");
        virtualsuper.Behavior();
        virtualsuper.TransformParameter(virtualsuper.Parameter);
        Console.WriteLine("---");
        
        MethodsVirtualSubClass overridevirtual = new MethodsVirtualSubClass("OVERRIDEVIRTUAL");
        overridevirtual.Behavior();
        overridevirtual.TransformParameter(overridevirtual.Parameter);
        Console.WriteLine("---");
        
        MethodsAbstractImplementation abstractimplementation = new MethodsAbstractImplementation("abstractimplementation");
        abstractimplementation.Behavior();
        Console.WriteLine("Fin");
        Console.WriteLine("=================================================");
        
        
        // Special Classes
        IImplementation implementation = new IImplementation("interface parameter");
        implementation.DisplayIParameter();
        Console.WriteLine("---");

        AImplementation aimplementation = new AImplementation("abstract parameter");
        aimplementation.DisplayIParameter();
        Console.WriteLine("---");
        
        VirtualClass2 vimplementation1 = new VirtualClass2("virtual parameter default");
        vimplementation1.DisplayIParameter();
        Console.WriteLine("---");
        
        VImplementation vimplementation2 = new VImplementation("virtual parameter override");
        vimplementation2.DisplayIParameter();
        */
        
        // Person and BankAccount

        /*
        Person person1 = new Person("Olivier", 52);
        BankAccount bankaccount1 = new BankAccount(person1, 500);
        bankaccount1.Deposer(100);
        bankaccount1.Retirer(300);
        bankaccount1.DisplaySolde();
        Console.WriteLine("-------");
        
        Person person2 = new Person("Olivier2", 53);
        BankAccount bankaccount2 = new BankAccount(person2, 300);
        bankaccount2.Retirer(400);
        bankaccount2.DisplaySolde();
        */
        
        // Chat et Chien
        /*

        List<Animal> animals = new() ;
        
        animals.Add(new Chat("Myrtille"));
        animals.Add(new Chien("Madria mon bébé d'amour"));
        animals.Add(new Chat("Macaron le gros chat"));
        animals.Add(new Chien("Madria toujours mon bébé chéri"));

        foreach (Animal animal in animals)
        {
            animal.SePresenter();
            animal.SeDeplacer();
            animal.FaireDuBruit();
        }
        */
        
        // Paiement
        /*
        IPaiement paiement = new CarteBleue();
        paiement.Payer();

        Command commande = new Command(paiement);
        commande.Valider(paiement);
        
         */
        //Ligne de commande
        /*
        Commande commande = new Commande();
        Panier panier = new Panier(commande);
        panier.DisplayLignes();
        */

        /*
        Adresses adresse = new Adresses("45 rue pétale de fleur");
        Client client = new Client("Olivier Sandal", 45, adresse);
        
        Commande2 commande = new Commande2();
        commande.AddLignesCommandes("Produit1", 52);
        commande.AddLignesCommandes("Produit2", 43);
        commande.AddLignesCommandes("Produit3", 44);
        
        Commande2 commande2 = new Commande2();
        commande.AddLignesCommandes("Produit4", 52);
        commande.AddLignesCommandes("Produit5", 43);
        commande.AddLignesCommandes("Produit6", 44);
        
        IPaiement2 paiement = new CarteBleue2();
        paiement.Payer(commande);
        paiement.Valider(paiement, commande);
        IPaiement2 paiement2 = new Paypal2();
        paiement2.Payer(commande2);
        paiement2.Valider(paiement2, commande2);
        */

        Vehicule voiture1 = new Voiture();
        Vehicule voiture2 = new Voiture();
        Vehicule voiture3 = new Voiture();
        Vehicule moto1 = new Moto();
        Vehicule moto2 = new Moto();
        Vehicule moto3 = new Moto();

        Garage garage = new Garage();
        garage.AddVehicule(voiture1);
        garage.AddVehicule(voiture2);
        garage.AddVehicule(voiture3);
        garage.AddVehicule(moto1);
        garage.AddVehicule(moto2);
        garage.AddVehicule(moto3);
        garage.DemarrerTous();

    }
}