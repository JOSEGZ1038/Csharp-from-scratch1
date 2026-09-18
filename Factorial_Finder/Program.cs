using System;

namespace FactorialFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número: ");
            int n = int.Parse(Console.ReadLine()!);

            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Resultado: {factorial}");
        }
    }
}
