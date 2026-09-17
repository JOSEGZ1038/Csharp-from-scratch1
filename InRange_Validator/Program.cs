using System;

namespace InRangeValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número: ");
            int n = int.Parse(Console.ReadLine()!);

            if (n >= 10 && n <= 20)
            {
                Console.WriteLine("Está en el rango.");
            }
            else
            {
                Console.WriteLine("Fuera del rango.");
            }
        }
    }
}
