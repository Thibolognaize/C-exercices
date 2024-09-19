using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
//Projet Exercice3 : (Calcul_IMC)
//L’objectif de ce projet est de permettre une saisie sécurisée des différents renseignements dans une application C# en
//mode console. L’application réalisée doit être robuste et fiable. Elle ne doit pas planter. Le développeur devra tout
//mettre en œuvre pour la sécuriser.
//Réaliser l’application Calcul_IMC qui permet à l’utilisateur de :
//• Saisir son nom et prénom
//• Saisir son poids en kg et sa taille en centimètre.
//• Lire le résultat de son IMC
//En cas d’erreur de saisie, l’application doit aider l’utilisateur à corriger sa saisi

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            double weight_kg;
            double height_cm;
            double imc;
            //Rappel formule imc : poids / taille x taille

            Console.WriteLine("Veuillez entrer votre prénom: ");
            firstName = Console.ReadLine();
                    

            Console.WriteLine("Veuillez entrer votre nom: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Vous vous appellez " + firstName + " " + lastName + ".");

            Console.WriteLine("Veuillez entrer votre poids (en kg): ");
            weight_kg = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer votre taille (en cm): ");
            height_cm = double.Parse(Console.ReadLine());
            imc = weight_kg / (height_cm / 100 * height_cm / 100);
            //imc = poids(KG) / (Taille (m)²)
            Console.WriteLine("Votre imc est de: " + imc + ".");
            Console.ReadKey(true);
        }
    }
}
