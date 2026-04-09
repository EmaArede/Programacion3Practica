// 4. En este programa el usuario ingresa la cantidad de alumnos y también la edad de cada uno para calculcar su promedio 
// Además el programa muestra los alumnos que están por encima y por debajo del promedio de edad
using System;

namespace PromedioEdadesManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROMEDIO DE EDADES - 6° SECUNDARIO ===\n");

            Console.Write("¿Cuántos alumnos hay en 6°? ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] edades = new int[cantidad];
            int suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingresa la edad del alumno {i + 1}: ");
                edades[i] = int.Parse(Console.ReadLine());
                suma += edades[i];
            }

            double promedio = (double)suma / cantidad;

            Console.Clear();
            Console.WriteLine("=== RESULTADOS ===\n");
            Console.WriteLine($" Total de alumnos: {cantidad}");
            Console.WriteLine($" Suma de edades: {suma}");
            Console.WriteLine($" Promedio de edades: {promedio:F2} años");

            
            int arriba = 0, abajo = 0;
            foreach (int edad in edades)
            {
                if (edad > promedio)
                    arriba++;
                else if (edad < promedio)
                    abajo++;
            }

            Console.WriteLine($"\n Alumnos con edad mayor al promedio: {arriba}");
            Console.WriteLine($" Alumnos con edad menor al promedio: {abajo}");
        }
    }
}