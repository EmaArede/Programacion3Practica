// 5. Calculo de promedio de temperatura en 5 días, siendo el usuario quien ingresa las temperaturas

using System;

namespace PromedioTemperaturaManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio de Temperatura\n");

            double[] temperaturas = new double[5];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            double suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa la temperatura del {dias[i]} (en °C): ");
                temperaturas[i] = double.Parse(Console.ReadLine());
                suma += temperaturas[i];
            }

            double promedio = suma / 5;

            Console.Clear();
            Console.WriteLine("Resultado de Temperaturas\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C");
            }

            Console.WriteLine($"\n Temperatura total: {suma}°C");
            Console.WriteLine($" Promedio de temperatura: {promedio:F2}°C");

            // Mostrar días con temperatura arriba y abajo del promedio
            Console.WriteLine("\n=== ANÁLISIS ===");
            for (int i = 0; i < 5; i++)
            {
                if (temperaturas[i] > promedio)
                    Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C (Por ENCIMA del promedio)");
                else if (temperaturas[i] < promedio)
                    Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C (Por DEBAJO del promedio)");
                else
                    Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C (Promedio)");
            }
        }
    }
}
