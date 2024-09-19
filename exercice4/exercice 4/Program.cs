using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Projet Exercice4:
//Ecrire le programme qui doit permettre de saisir les noms des étudiants et pour chaque étudiant, sa moyenne.A la
//fin, il faut afficher les noms des étudiants qui sont au-dessus de la moyenne de la classe.
//Le nombre d’étudiants doit être saisi dès le début du programme.Il doit servir de dimension à votre tableau.
namespace exercice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students;
            int[] moyennes;
            string student;
            int moyenne;
            int moyenne_classe;
            int nb_student;
            int moyenne_count = 0;

            Console.WriteLine("Combien d'etudiants voulez entrez : \n");
            nb_student = int.Parse(Console.ReadLine());
            students = new string[nb_student];
            moyennes = new int[nb_student];

            for (int i = 0; i < nb_student; i++) { 
                Console.WriteLine("Veuillez entrer le nom de votre etudiant numero " + i + " : \n");
                student = Console.ReadLine();

                Console.WriteLine("Veuillez entrer sa moyenne: \n");
                moyenne = int.Parse(Console.ReadLine());

                students[i] = student;
                moyennes[i] = moyenne;

            }

            for (int i = 0; i < nb_student; i++)
            {
                moyenne_count += moyennes[i];
            }
            moyenne_classe = moyenne_count / nb_student;
            Console.WriteLine("La moyenne de la classe est de: " + moyenne_classe);


            for (int i = 0; i < nb_student; i++)
            {
                if (moyenne_classe < moyennes[i])
                    Console.WriteLine(students[i] + " moyenne : " + moyennes[i]);

            }
            Console.ReadKey(true);
        }
    }
}
