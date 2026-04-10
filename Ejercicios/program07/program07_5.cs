using System;

namespace DolarAPeso
{
    class Program
    {
        const double FACTOR_CONVERSION = 1374;

        static void Main(string[] args)
        {
            Console.WriteLine("Convertir Dolares a Pesos\n");

            Console.Write("Ingresa la Cantidad en Dolares: ");
            double dolares = double.Parse(Console.ReadLine());

            double pesos = dolares * FACTOR_CONVERSION;

            Console.WriteLine($"\n Resultado:");
            Console.WriteLine($"{dolares} USD = {pesos:F4} ARG");
        }
    }
}
