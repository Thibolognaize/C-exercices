using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            string choix;
            Boolean terminer = false;

            affiche_tab(tab);
            while (terminer == false)
            {
                Console.WriteLine("Que voulez vous faire?");
                Console.WriteLine("1 : entrer une valeur");
                Console.WriteLine("2 : affiche tableau");
                Console.WriteLine("3 : affiche valeur en diagonale");
                Console.WriteLine("q : quitter");
                choix = Console.ReadLine();

                if (choix.Equals("q"))
                {
                    terminer = true;
                }
                else if (choix.Equals("1"))
                {
                    tab = rempli_tab(tab);
                }
                else if (choix.Equals("2"))
                {
                    affiche_tab(tab);
                }
                else if (choix.Equals("3"))
                {
                    Console.WriteLine("\ntableau en diagonale : ");
                    affiche_diag(tab);
                }
                else
                {
                    Console.WriteLine("erreur saisie ! ");
                }
            }
            
            Console.ReadKey();
        }

        private static int[,] rempli_tab(int[,] tab)
        {
            int indice1;
            int indice2;
            int entier;

            Console.WriteLine("Donnez indice 1 :");
            indice1 = int.Parse(Console.ReadLine());
            if (indice1 < 0 || indice1 > tab.Length)
            {
                Console.WriteLine("error de saisie");
            }

            Console.WriteLine("Donnez indice 2 :");
            indice2 = int.Parse(Console.ReadLine());
            if (indice2 < 0 || indice2 > tab.Length)
            {
                Console.WriteLine("error de saisie");
            }

            Console.WriteLine("donnez entier :");
            entier = int.Parse(Console.ReadLine());
            tab[indice1, indice2] = entier;
 
            return tab;

        }

        private static void affiche_tab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("[" + tab[i, j] + "]");
                }
                Console.Write("\n");
            }
        }

        private static void affiche_diag(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("Element({0},{1})={2}", i, i, tab[i, i]);
            }
        }
    }
}
