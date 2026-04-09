// 4 Programa para calcular el promedio de temperatura en 5 días (con datos predefinidos en el código)

using System;

namespace PromedioTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Promedio de Temperatura\n");

            // Temperaturas en grados Celsius (con decimales)
            double[] temperaturas = { 22.5, 23.8, 21.3, 24.0, 22.7 };
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            double suma = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
                Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C");
            }

            double promedio = suma / temperaturas.Length;

            Console.WriteLine($"\n Suma de temperaturas: {suma}°C");
            Console.WriteLine($" Promedio de temperatura: {promedio:F2}°C");
        }
    }
}
