﻿// Premier essai de programmation en C#
// Une application console pour ma candidature

using System;


namespace Candidature
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Candidature au poste de développeur .NET");

            // Readkey permet d'afficher la ligne jusqu'à ce que l'utilisateur appuie sur une touche

            Console.WriteLine("Appuyer sur n'importe quelle touche pour continuer la présentation");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thomas, 31 ans, admis au sein du BTS SIO Solutions logicielles à Vitrolles ");
            Console.ResetColor();
            Console.ReadKey();

            Console.WriteLine("Ceci est ma première application en C#");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aujourd'hui débutant, j'ai le potentiel pour devenir un programmeur de talent");
            Console.ResetColor();
            Console.ReadKey();

            Console.WriteLine("Cette reconversion dynamique que je choisi me pousse à exceller");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Et une alternance au sein de votre société me permettrais d'apprendre et de m'épanouir");
            Console.ResetColor();
            Console.ReadKey();

            Console.WriteLine("Lundi, mardi, mercredi dans votre entreprise, jeudi et vendredi en formation");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Une structure où mettre en oeuvre mes compétences pour moi, et un collaborateur motivé pour vous");
            Console.ResetColor();
            Console.ReadKey();

            Console.WriteLine("Débutant très capable, je suis ouvert à travailler sur tout langage de programmation et tout IDE");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;           
            Console.WriteLine("Si vous êtes intéressés contactez soit Thomas.raguin@free.fr ou alors stephanie.ohannessian@m2sformation.com");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
