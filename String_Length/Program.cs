using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá una palabra: ");
            string palabra = Console.ReadLine()!;

            Console.WriteLine("Resultado: " + palabra.Length);
        }
    }
}