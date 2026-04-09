//5 Este programa permite agregar manualmente las edades de los alumnos utilizando una lisa
// tamién incluye una validación para asegurarse que las edades ingresadas sean hipoteticamente razonables

using System;
using System.Collections.Generic;

namespace PromedioEdadesList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROMEDIO DE EDADES - 6° SECUNDARIO ===\n");

            List<int> edades = new List<int>();
            string respuesta;

            do
            {
                Console.Write("Ingresa la edad del alumno: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 10 && edad <= 80)
                {
                    edades.Add(edad);
                }
                else
                {
                    Console.WriteLine(" Edad no válida. Debe estar entre 10 y 80 años.");
                }

                Console.Write("¿Quieres agregar otro alumno? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            if (edades.Count > 0)
            {
                int suma = 0;
                foreach (int edad in edades)
                {
                    suma += edad;
                }

                double promedio = (double)suma / edades.Count;

                Console.Clear();
                Console.WriteLine(" RESULTADO \n");
                Console.WriteLine("Edades ingresadas:");
                for (int i = 0; i < edades.Count; i++)
                {
                    Console.WriteLine($"   Alumno {i + 1}: {edades[i]} años");
                }

                Console.WriteLine($"\n Total de alumnos: {edades.Count}");
                Console.WriteLine($" Promedio de edades: {promedio:F2} años");
            }
            else
            {
                Console.WriteLine("No se ingresaron edades válidas.");
            }
        }
    }
}