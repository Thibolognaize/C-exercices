using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValide = false;
            while (isValide == false)
            {
                Console.WriteLine("Saisir votre âge:");
                int age;
                try
                {
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vous avez " + age + " ans.");
                    int majorite = 18 - age;
                    if (age < 18)
                    {
                        Console.WriteLine("Vous êtes mineur !");
                        Console.WriteLine("Vous serez majeur dans " + majorite + " petites années...");
                        isValide = true;
                    }
                    else
                    {
                        Console.WriteLine("Vous êtes majeur !");
                        isValide = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Veuillez saisir un entier");
                }
                Console.ReadKey(true);
            }
        }
    }
}
