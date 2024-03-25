using System;

namespace ClassOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Maak een nieuwe instantie van GameEngine
            GameEngine engine = new GameEngine();

            // Roep de RunGameLoop-methode aan van de GameEngine instantie
            engine.RunGameLoop();
        }
    }
}
