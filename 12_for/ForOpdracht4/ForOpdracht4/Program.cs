using System;

namespace ForOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            float[] vectors = new float[] { 6, 7, 8, 1, 4, 0 }; //2 vectoren (6,7,8) en (1,4,0) achter elkaar net als bij shaders

            //nu willen we per vector door de array lopen dat moet dus met stappen van 3
            for (int i = 0; i < vectors.Length; i += 3)//zorg ervoor dat we niet i + 1 doen maar +3
            {
                float x = vectors[i];     // x is de waarde op index i
                float y = vectors[i + 1]; // y is de waarde op index i + 1
                float z = vectors[i + 2]; // z is de waarde op index i + 2
                Console.WriteLine($"vector {x}, {y}, {z}");
            }
        }
    }
}
