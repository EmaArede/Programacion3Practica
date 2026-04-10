using System;

namespace ConversorFuncion
{
    class Program
    {
        const double PIE_A_METRO = 0.3048;

        static void Main(string[] args)
        {
            Console.WriteLine("Pies a Metros\n");

            Console.Write("Ingresa los pies: ");
            double pies = double.Parse(Console.ReadLine());

            double metros = ConvertirPiesAMetros(pies);

            Console.WriteLine($"\n📏 {pies} pies = {metros:F3} metros");
        }

        static double ConvertirPiesAMetros(double pies)
        {
            return pies * PIE_A_METRO;
        }
    }
}