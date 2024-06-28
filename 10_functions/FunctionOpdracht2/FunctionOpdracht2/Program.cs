using System;

namespace FunctionOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int nummer = program.MijnFavorietNummer(); // deze werkt nu

            Console.WriteLine($"mijn favoriet nummer {nummer}");
        }

        // Laat deze function een 'int' teruggeven
        private int MijnFavorietNummer()
        {
            // Maak hier een variable van het type 'int' en geef die een waarde
            int favorietNummer = 42;

            // Geef hier de variable terug
            return favorietNummer;
        }
    }
}
