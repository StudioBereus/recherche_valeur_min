using System;

namespace recherche_valeur_min
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Programme de recherche d'un nombre ");
            int j;
            int[] tableau = new int[4] { 99, 24,104,100};
            int min = tableau[0];
            int max = tableau[0];
            for (j = 0; j < tableau.Length; j++)
            {
                if  (tableau[j] < min )
                {
                    min=tableau[j];
                }
                else if (tableau[j] > max && tableau[j]>min)
                {
                    max=tableau[j];
                }
            }
            Console.WriteLine("La valeur minimale est : " + min + "\nLa valeur maximale est: " + max);
        }
    }
}
