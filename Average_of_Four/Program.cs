using System;

namespace AverageOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el primer número: ");
            double n1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingresá el segundo número: ");
            double n2 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingresá el tercer número: ");
            double n3 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingresá el cuarto número: ");
            double n4 = double.Parse(Console.ReadLine()!);

            double promedio = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"Resultado: {promedio}");
        }
    }
}
