using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;

            //koop 2 controllers
            controllersInMandje += 2;

            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5
            ps5++;

            //koop de games:
            int eldenRing = 1;
            int shantae = 1;
            int spongebob = 1;

            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            eldenRing--;

            //nu nog de prijs
            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;

            double totaalControllerPrijs = controllersInMandje * controllerPrijs;
            double totaalGamePrijs = (eldenRing + shantae + spongebob) * gamePrijs;

            double totaalPrijs = totaalControllerPrijs + totaalGamePrijs + ps5Prijs;

            //er moet nu 759.95 staan
            Console.WriteLine($"Totaalprijs: {totaalPrijs}");
        }
    }
}
