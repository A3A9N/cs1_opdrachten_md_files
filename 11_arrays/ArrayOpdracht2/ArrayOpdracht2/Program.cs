﻿using System;

namespace ArrayOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Maak hier een nieuwe array met vulling gebruik new int[] { hier je cijfers };
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            // Kijk nu wat er gebeurt als je het programma runt
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
