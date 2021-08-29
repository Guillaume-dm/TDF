using System;

namespace TDF
{
    class Couleurs
    {
        public Couleurs(int avance)
        {
            if (avance >= 5)
            {
                Console.ForegroundColor = ConsoleColor.White;  // Annule l'ensemble des précédantes colorations
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;  // Passe la colorisation en jaune fesant référance au groupe maillot jaune ouvrant la route
            }
        }
    }
}
