using System;

namespace PositivePower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número: ");
            int n = int.Parse(Console.ReadLine()!);

            if (n > 0)
            {
                Console.WriteLine($"Resultado: {n * n}");
            }
            else if (n < 0)
            {
                Console.WriteLine("Número negativo.");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
    }
}
