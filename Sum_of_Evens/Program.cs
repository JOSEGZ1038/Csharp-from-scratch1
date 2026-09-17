using System;

namespace SumOfEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Resultado: {suma}");
        }
    }
}
