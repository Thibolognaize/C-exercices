/**
 * Jeu du nombre caché
 * author : Emds
 * date : 19/09/2024
 */
using System;

namespace NombreCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre à chercher : ");
            int number = 0;
            int essai;
            int compt = 1;
            bool tryTermine = false;
            //saisie d'un nombre a chercher
            while (tryTermine == false)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    tryTermine = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie");
                }
            }
            Console.Clear();
            // saisie du premier essai
            Console.WriteLine("Entrez un essai : ");
            essai = int.Parse(Console.ReadLine());

            //boucle sur les essais
            while (essai != number)
            {
                //test essai par rapport à valeur à chercher
                if (essai > number)
                {
                    Console.WriteLine(" --> trop grand !\n");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !\n");
                }
                //saisie de l'essai suivant
                Console.WriteLine("Entrez un essai : ");
                essai = int.Parse(Console.ReadLine());

                // compteur d'essai
                compt++;
            }
            // valeur trouvée
            Console.Clear() ;
            Console.WriteLine("Bravo, vous avez trouvé !!\nLe nombre était : {0}, vous avez trouvé en {1} fois !", number, compt);
            Console.ReadKey();
        }
    }
}
