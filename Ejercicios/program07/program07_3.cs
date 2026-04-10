using System;

namespace LibrasAKilos
{
    class Program
    {
       
        const double LIBRA_A_KILO = 0.453592;

        static void Main(string[] args)
        {
            Console.WriteLine("Libras a Kg\n");

            Console.Write("Ingresa el peso en libras: ");
            double libras = double.Parse(Console.ReadLine());

            double kilogramos = libras * LIBRA_A_KILO;

            Console.WriteLine($"\n Resultado:");
            Console.WriteLine($"{libras} lb = {kilogramos:F4} kg");
        }
    }
}
