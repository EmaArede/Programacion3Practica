//2 Un programa para calcular el promedio de notas utilizando arrays finitos (las notas están predefinidas por el código)

using System;

namespace NotasConArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 7.5, 8.0, 5.5, 9.0, 4.0 };

            Console.WriteLine(" Notas del Examen\n");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {notas[i]}");
            }

            double suma = 0;
            foreach (double nota in notas)
            {
                suma += nota;
            }
            double promedio = suma / notas.Length;

            Console.WriteLine($"\n📊 Promedio de la clase: {promedio:F2}");
        }
    }
}