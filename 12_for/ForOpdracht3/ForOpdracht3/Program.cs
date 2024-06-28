using System;

namespace ForOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

          
            Enemies[] enemies = new Enemies[]
            {
                new Enemies() { defeated = true, name = "isdead" },
                new Enemies() { defeated = false, name = "stillalive" }
            };

           
            for (int i = 0; i < enemies.Length; i++)
            {
               
                if (enemies[i].defeated)
                {
                    
                    Console.WriteLine($"{enemies[i].name} is defeated.");
                }
            }
        }
    }

