using System;

namespace ClassOpdracht1
{
    internal class ClassStructureExercise
    {
        // Constructor met een parameter voor accountnaam
        private readonly string accountName;

        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }

        // Methode om een begroeting in de console te tonen
        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        // Methode om de getallen van 1 tot 10 in de console te tonen
        internal void Show1To10()
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i.ToString());
            }
        }

        // Methode om de afstand tussen twee punten te berekenen
        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;
        }

        // Methode om een getal met zichzelf te vermenigvuldigen
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }

        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
        }
    }
}
