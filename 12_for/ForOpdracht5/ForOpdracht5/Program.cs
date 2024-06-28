using System;

namespace ForOpdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nummers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Pas de for-loop aan zodat alleen nummers 3 tot en met 7 op de console komen
            for (int i = 3; i <= 7; i++)
            {
                Console.WriteLine(nummers[i]);
            }
        }
    }
}
