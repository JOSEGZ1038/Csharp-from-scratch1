using System;

namespace DoubleOrTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el primer número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Ingresá el segundo número: ");
            int b = int.Parse(Console.ReadLine()!);

            if (a >= b)
            {
                Console.WriteLine($"Resultado: {a * 2}");
            }
            else
            {
                Console.WriteLine($"Resultado: {b * 3}");
            }
        }
    }
}
