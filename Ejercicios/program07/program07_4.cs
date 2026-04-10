using System;

namespace ConversorFuncion
{
    class Program
    {
        const double LIBRA_A_KILO = 0.453592;

        static void Main(string[] args)
        {
            Console.WriteLine("Libras a Kg\n");

            Console.Write("Ingresa las libras: ");
            double libras = double.Parse(Console.ReadLine());

            double kilogramos = ConvertirLibrasAKilos(libras);

            Console.WriteLine($"\n⚖️ {libras} lb = {kilogramos:F3} kg");
        }

        static double ConvertirLibrasAKilos(double libras)
        {
            return libras * LIBRA_A_KILO;
        }
    }
}