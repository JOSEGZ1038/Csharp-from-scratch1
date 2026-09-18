using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá una palabra: ");
            string palabra = Console.ReadLine()!.ToLower();

            string vocales = "aeiou";
            int contador = 0;

            foreach (char letra in palabra)
            {
                if (vocales.Contains(letra))
                {
                    contador++;
                }
            }

            Console.WriteLine($"Resultado: {contador}");
        }
    }
}
