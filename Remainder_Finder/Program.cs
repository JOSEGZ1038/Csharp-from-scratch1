using System;

namespace RemainderFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el primer número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Ingresá el segundo número: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Resultado: {a % b}");
        }
    }
}
