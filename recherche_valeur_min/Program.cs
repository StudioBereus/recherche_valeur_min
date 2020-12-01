using System;

namespace recherche_valeur_min
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille;
            Console.WriteLine("Programme de recherche d'un nombre ");
            int j, min, max;
            min = 0;
            max = 0;
            int[] tableau = new int[4] { 1, 2, 3, 99 };
            for (j = 0; j < tableau.Length; j++)
            {
                if (tableau[j] > max)
                {
                    max = tableau[j];
                }
                else if (tableau[j] < min)
                {
                    min = tableau[j];
                }
               
            }
            Console.WriteLine("La valeur minimale est : " + min + "\nLa valeur maximale est: " + max);
        }
    }
}
