using System;

namespace CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine()!);

            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {Math.Round(perimetro, 2)}");
        }
    }
}
