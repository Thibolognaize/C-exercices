using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Projet Exercice2 :
Ecrire le programme qui permet à l’utilisateur de saisir 5 notes comprises entre 0 et 20. La saisie est redemandée
jusqu’à ce qu’une note correcte soit saisie.
Le programme calcul ensuite la moyenne des notes l’affiche et affiche avec la mention correspondante ("très bien " à
partir de 16, "bien" à partir de 14, "assez bien" à partir de 12, "passable" à partir de 10, "recalé" en dessous de 10)*/

namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] notes = new float[5];

            for (int i = 0; i < 5; i++)
            {
                bool goodNote = true;
                do
                {
                    Console.WriteLine("Entrez une note entre 0 et 20 (Note " + (i + 1) + ") :");
                    string note = Console.ReadLine();

                    try
                    {
                        int intNote = int.Parse(note);
                        if (intNote >= 0 && intNote <= 20)
                        {
                            notes[i] = intNote;
                            goodNote = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Merci d'entrer une note valide !");
                    }
                }
                while (goodNote);
            }

            long result = 0;

            Console.Clear();

            foreach (int note in notes)
            {
                result += note;
                Console.WriteLine("Note : " + note);
            }
            result = result / 5;
            Console.WriteLine("Résultat : " + result + "/20");

            if (result > 16)
            {
                Console.WriteLine("Mention : Très bien.");
            }
            else if (result > 14)
            {
                Console.WriteLine("Mention : Bien.");
            }
            else if (result > 12)
            {
                Console.WriteLine("Mention : Assez bien.");
            }
            else if (result > 10)
            {
                Console.WriteLine("Mention : Passable.");
            }
            else
            {
                Console.WriteLine("Mention : Recalé.");
            }

            Console.WriteLine("Appuyes sur une touche pour fermer le programme.");
            Console.ReadKey();
            Console.ReadKey(true); 
        }
    }
}
