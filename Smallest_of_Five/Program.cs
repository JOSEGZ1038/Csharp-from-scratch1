using System;

namespace SmallestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresá el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine()!);
            }

            int menor = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"Resultado: {menor}");
        }
    }
}
