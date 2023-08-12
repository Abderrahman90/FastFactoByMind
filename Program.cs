using System;

namespace TestIBMbyMind
{
    class Program
    {
        static void Main(string[] args)
        {

            // je veux connaitre le factoreil de 5

            long nb;
            long resultat = 1;
            Console.Write("veuillez saisir un nombre pour avoir son factoreil ");
            nb = Convert.ToInt64(Console.ReadLine());

            for (long i =1; i <= nb; i++)
            {
                resultat *= i;
            }
            if (nb < 0)
            {
                Console.WriteLine("errur de saisie, veuillez entrer un nombre positif +");

            }
            else
            Console.WriteLine(resultat);

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // je déclare mes variables
            //int nb;
            //int resultat = 1;
            //Console.WriteLine("veuillez écrire le nombre dont vous voulez son factoriel");
            //nb = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= nb; i++)
            //{
            //    resultat *= i;
            //}
            //Console.WriteLine($"le factoriel de {nb}! est de " + resultat);














            //return resultat;
            // en faisant avec le return tu dois changé la méthode Main (notre point d'entrée de l'application ou programme)
            // à la place de void mettre int mais je pense pour moi ce n'est pas la bonne pratique (clean code)
            // en effet on ne doit pas changer la méthode Main et de plus avec le return le résultat 
            // sera exécuté et affiché en bout de sortie voir ci dessous :

              //             veuillez écrire le nombre dont vous voulez son factoriel
             //              5

            //         Sortie de C: \Users\Abder\source\repos\TestIBMbyMind\bin\Debug\netcoreapp3.1\TestIBMbyMind.exe(processus 14508).Code : 120.

        }
    }
}
