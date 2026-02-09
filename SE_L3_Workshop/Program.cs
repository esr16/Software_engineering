using System.Reflection.Metadata.Ecma335;
using Delegue;
using LambdaAndAnonyme;
using System;
using System.Threading;
using TypeAnonyme;
using System.Collections.Generic;
using Delegue2;

class Program
{
    static void Main()

    /*
    // Délégué
    ClassDelegate mondelegue = new ClassDelegate();
    mondelegue.mamethode(2,3);
    Console.WriteLine("----");

    // Lambda publique
    ClassLambdaAndAnonyme lambda_carre = new ClassLambdaAndAnonyme();
    int resultat = lambda_carre.carre(4);
    Console.WriteLine($"Résultat lambda public : {resultat} (16)");
    Console.WriteLine("----");

    // Lambda encapsulé
    // 1 - Récupérer avec getter
    ClassLambdaAndAnonyme lambda_addition = new ClassLambdaAndAnonyme();
    int resultat_addition = lambda_addition.Addition(3,4);
    Console.WriteLine($"Résultat du getter de addition : {resultat_addition} (7)");
    Console.WriteLine("----");

    // 2 - Changer avec setter
    lambda_addition.Addition = (x,y) => x*y;
    int resultat_multiplication = lambda_addition.Addition(3, 4);
    Console.WriteLine($"Résultat du setter de addition à multiplication : {resultat_multiplication} (12)");
    Console.WriteLine("----");


    // 3 - changer avec méthode
    Func<int,int,int> division = (x,y) => x/y;
    int resultat_division = lambda_addition.Division(division, 6, 2);
    Console.WriteLine($"Changement de addition à division : {resultat_division} (3)");



    //Exercice 2b - Lambda et Loops

    delegate int DELG2(int v);

    class Q2b

    {

        static void Main(string[] args)

        {

            DELG2 d = x => //lambda

            {
                int res = x * x; //resultat de d = le carre de x
                return res;

            };


            Thread[] Threads = new Thread[10]; //on instancie un Thread


            for (int i = 0; i < Threads.Length; i++) // i allant de 0 a 9

            {
                int local = i; // j=0 puis j=1

                Threads[local] = new Thread(() => //on remplit le thread avec le carré de j
                {
                    int res = d(local);
                    Console.WriteLine(res);
                });
            }


            foreach (Thread t in Threads)

            { t.Start();

                t.Join();

            }

        }

    }


    // Exercice 3 : les types anonymes

    // Type dans méthode

    ClassTypeAnonyme objet_anonyme= new ClassTypeAnonyme();
    objet_anonyme.MethodeAnonyme();

    //Type dans dynamic

    ClassTypeAnonyme objet_anonyme2 = new ClassTypeAnonyme();
    var a = objet_anonyme2.MethodeAnonyme2();
    Console.WriteLine($"Type dans méthode dynamic : {a.Nom}, {a.Age}");

    */

    // Exercice 4 : Délégué

    A a = new A(); //Allocation de la mémoire à a grâce à new
    B b = new B(); //Allocation de la mémoire à b grâce à new
    

    
   
}
