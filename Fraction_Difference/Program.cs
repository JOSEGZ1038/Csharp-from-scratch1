using System;

namespace FractionDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numerador de la primera fracción: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Denominador de la primera fracción: ");
            int d1 = int.Parse(Console.ReadLine()!);
            Console.Write("Numerador de la segunda fracción: ");
            int n2 = int.Parse(Console.ReadLine()!);
            Console.Write("Denominador de la segunda fracción: ");
            int d2 = int.Parse(Console.ReadLine()!);

            int numResultado = n1 * d2 - n2 * d1;
            int denResultado = d1 * d2;

            if (numResultado == 0)
            {
                Console.WriteLine("Resultado: 0");
                return;
            }

            int divisor = MaximoComunDivisor(Math.Abs(numResultado), Math.Abs(denResultado));
            numResultado /= divisor;
            denResultado /= divisor;

            if (denResultado < 0)
            {
                denResultado *= -1;
                numResultado *= -1;
            }

            Console.WriteLine($"Resultado: {numResultado}/{denResultado}");
        }

        static int MaximoComunDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

