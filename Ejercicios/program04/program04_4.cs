//Programa para agregar strings y chars concatenados 

using System;

namespace AgregarStringCharsConcatenados
{
    class Program
    {
        static void Main(string[] args)
        {
            string todosLosStrings = "";
            string todosLosChars = "";
            string respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("Agregar texto y Letras\n");

                Console.Write("Ingresa un texto: ");
                string nuevoString = Console.ReadLine();
                todosLosStrings += nuevoString + " | ";

                Console.Write("Ingresa un char: ");
                char nuevoChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                todosLosChars += nuevoChar + " | ";

                Console.WriteLine("\n Datos Almacenados: ");
                Console.WriteLine($"Strings acumulados: {todosLosStrings}");
                Console.WriteLine($"Chars acumulados: {todosLosChars}");

                Console.Write("\n¿Deseas agregar más? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            Console.WriteLine($"\n Texto Almacenado: {todosLosStrings}");
            Console.WriteLine($" Letras Almacenadas: {todosLosChars}");
        }
    }
}