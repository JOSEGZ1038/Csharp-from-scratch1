using System;

namespace RootOrSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número: ");
            double n = double.Parse(Console.ReadLine()!);

            if (n >= 0)
            {
                Console.WriteLine($"Resultado: {Math.Sqrt(n)}");
            }
            else
            {
                Console.WriteLine($"Resultado: {n * n}");
            }
        }
    }
}
