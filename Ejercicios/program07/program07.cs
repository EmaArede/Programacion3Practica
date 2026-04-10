using System;

namespace PiesAMetrosConstante
{
    class Program
    {
        const double FACTOR_CONVERSION = 0.3048;

        static void Main(string[] args)
        {
            Console.WriteLine("Convertir Pies a Metros\n");

            Console.Write("Ingresa la longitud en pies: ");
            double pies = double.Parse(Console.ReadLine());

            double metros = pies * FACTOR_CONVERSION;

            Console.WriteLine($"\n Resultado:");
            Console.WriteLine($"{pies} pies = {metros:F4} metros");
        }
    }
}
