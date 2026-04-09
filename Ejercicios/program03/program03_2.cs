// 2 Programa que calculael promedio de peso (predefinido en el código) de 5 personas (predefinidas en el código) de una edad hipotética
using System;

namespace PromedioPeso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Promedio de Peso \n");

            double[] pesos = { 65.5, 72.3, 58.0, 80.1, 69.8 };

            double suma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                suma += pesos[i];
                Console.WriteLine($"Persona {i + 1}: {pesos[i]} kg");
            }

            double promedio = suma / pesos.Length;

            Console.WriteLine($"\n Peso total: {suma} kg");
            Console.WriteLine($" Promedio de peso: {promedio:F2} kg");
        }
    }
}
