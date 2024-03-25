using System;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Maak een instantie van ShopGreeter
            ShopGreeter greeter = new ShopGreeter();

            // Roep de methode GreetCustomer aan van de ShopGreeter instantie
            greeter.GreetCustomer();
        }
    }
}
