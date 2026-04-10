// En este programa los string y char se pueden ingresar manualmente 
using System;
namespace AgregarStringCharManualmente
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Ingrese un Texto");
            string cadena = Console.ReadLine();
            Console.WriteLine("Ingrese una Letra");
            char letra =Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Esto es un texto: " + cadena);
            Console.WriteLine("Esto es una Letra: " + letra);

        }
    }
}