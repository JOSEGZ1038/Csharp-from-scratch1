using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá el salario anual: ");
            double salario = double.Parse(Console.ReadLine()!);

            if (salario > 12000)
            {
                double impuesto = (salario - 12000) * 0.15;
                Console.WriteLine($"Resultado: {impuesto}");
            }
            else
            {
                Console.WriteLine("No debe impuestos.");
            }
        }
    }
}