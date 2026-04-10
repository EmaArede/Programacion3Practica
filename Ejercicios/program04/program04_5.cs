//
using System;

namespace AgregarConcatenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string misStrings = "";
            string misChars = "";

            Console.WriteLine("Almacenar Texto y Letras\n");
            Console.WriteLine("(Escribe 'salir' para terminar)\n");

            // Agregar strings
            Console.WriteLine("--- Agergar Texto ---");
            while (true)
            {
                Console.Write("Texto: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "salir") break;
                misStrings += input + " ";
                Console.WriteLine($"Textos almacenados: {misStrings}");
            }

            // Agregar chars
            Console.WriteLine("\n --- Agregar Letras ---");
            while (true)
            {
                Console.Write("Letra: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "salir") break;
                if (input.Length > 0)
                {
                    misChars += input[0] + " ";
                    Console.WriteLine($"Letras Almacenadas: {misChars}");
                }
            }

            Console.Clear();
            Console.WriteLine("Total");
            Console.WriteLine($"Textos ingresados: {misStrings}");
            Console.WriteLine($"Letras ingresadas: {misChars}");
        }
    }
}