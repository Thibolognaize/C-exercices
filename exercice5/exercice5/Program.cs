using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Projet Exercice5:
//Soit un tableau d’entiers initialisé comme suite : int[] tab = { 12, 15, 13, 10, 8, 9, 13, 14 };
//Ecrire une fonction remplace qui demande à l’utilisateur de saisir un entier et un indice et met cet entier dans le
//tableau à cet indice. Il faudra vérifier que l’indice correspond bien à une case du tableau (par exemple 0 ou 3 sont
//corrects, mais -1 ou 123 ne sont pas des indices corrects pour ce tableau). Le programme affichera le contenu du
//tableau avant et après cette transformation. 
namespace exercice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 12, 15, 13, 10, 8, 9, 13, 14 };
            int indice = 0;
            int entier = 0;
            Boolean terminer = false;

            while (terminer == false) { 

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine(tab[i]);
                }
                Console.WriteLine("donner l'indice du tableau :");
                indice = int.Parse(Console.ReadLine());
                if (indice < 0 || indice > tab.Length)
                {
                    Console.WriteLine("error mauvais saisie");
 
                } else { 
                    Console.WriteLine("donner l'entier a ajouter :");
                    entier = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    tab[indice] = entier;

                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    terminer = true;    
            
                }
            }
            Console.ReadKey(true);
        }
    }
}
