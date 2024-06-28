using System;

namespace FunctionOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eerst even uit de static ontsnappen
            Program program = new Program();

            // 3) Roep hier de function aan
            program.AskForAge();
        }

        // 2) Maak hier je function met naam AskForAge
        private void AskForAge()
        {
            // 1) Zet deze 3 regels in een function (AskForAge) in program, en roep deze aan 
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"You're age is {age}");
            // Eind
        }
    }
}
