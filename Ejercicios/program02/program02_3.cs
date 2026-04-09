//3 Un programa para calcular el promedio de las notas pero esta vez utilizand listas (notas predefinidas en el código)
// Incluye la opción de agregar un alumno junto con una nota adicional
using System;

namespace NotasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double> { 7.5, 8.0, 5.5, 9.0, 4.0, 6.5, 10.0 };

            Console.WriteLine("Notas \n");

            for (int i = 0; i < notas.Count; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {notas[i]}");
            }

            notas.Add(6.0);
            Console.WriteLine($"\n Se agregó una nueva nota: 6.0 (Alumno {notas.Count})");

            double suma = 0;
            foreach (double nota in notas)
            {
                suma += nota;
            }
            double promedio = suma / notas.Count;

            Console.WriteLine($"\n📊 Promedio de la clase: {promedio:F2}");
        }
    }
}