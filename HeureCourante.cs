using System;

namespace TDF
{
    class HeureCourante
    {
        public HeureCourante(string Date)
        {
            Console.WriteLine("On est le : " + Date);
            Console.ReadLine();
            if (Date == "25-12") // Pour savoir si on est le jour de Noël
            {
                Console.ForegroundColor = ConsoleColor.Red; // Changement de couleur auto pour Noël
                Console.WriteLine("Joyeux Noël !!!"); // Affichage d'un message surprise en lien avec le jour de Noël.
                Console.ReadLine();
            }
            if (Date == "01-01") // Pour savioir si on est le jour de l'an
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Changement de couleur auto pour le jour de l'an
                Console.WriteLine("Bonne année à toi :)"); // Affichage d'un message surprise en lien avec le nouvel an.
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
