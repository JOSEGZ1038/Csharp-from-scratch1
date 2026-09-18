using System;

namespace MidweekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresá un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine()!);

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                default: Console.WriteLine("Número fuera del rango laboral."); break;
            }
        }
    }
}
