//3 Este programa permite calcular el prmedio de peso de 5 personas, siendo el usuario quien ingresa el peso 
using System;

namespace PromedioPesoManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Promedio de Peso\n");

            double[] pesos = new double[5];
            double suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa el peso de la persona {i + 1} (en kg): ");
                pesos[i] = double.Parse(Console.ReadLine());
                suma += pesos[i];
            }

            double promedio = suma / 5;

            Console.Clear();
            Console.WriteLine(" Resultados\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Persona {i + 1}: {pesos[i]} kg");
            }

            Console.WriteLine($"\n Peso total: {suma} kg");
            Console.WriteLine($" Promedio de peso: {promedio:F2} kg");

            Console.WriteLine("\n=== ANÁLISIS ===");
            for (int i = 0; i < 5; i++)
            {
                if (pesos[i] > promedio)
                    Console.WriteLine($"Persona {i + 1}: {pesos[i]} kg (Por ENCIMA del promedio)");
                else if (pesos[i] < promedio)
                    Console.WriteLine($"Persona {i + 1}: {pesos[i]} kg (Por DEBAJO del promedio)");
                else
                    Console.WriteLine($"Persona {i + 1}: {pesos[i]} kg ( Promedio)");
            }
        }
    }
}