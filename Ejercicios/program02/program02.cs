using System;

namespace PromedioEdades
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("=== PROMEDIO DE EDADES - 6° SECUNDARIO ===\n");

            int[] edades = { 17, 18, 17, 16, 18, 17, 18, 19, 17, 18 };

            int suma = 0;
            for (int i = 0; i < edades.Length; i++)
            {
                suma += edades[i];
                Console.WriteLine($"Alumno {i + 1}: {edades[i]} años");
            }

            double promedio = (double)suma / edades.Length;

            Console.WriteLine($"\n📊 Total de alumnos: {edades.Length}");
            Console.WriteLine($"📊 Suma de edades: {suma}");
            Console.WriteLine($"📊 Promedio de edades: {promedio:F2} años");
            }
    }
}