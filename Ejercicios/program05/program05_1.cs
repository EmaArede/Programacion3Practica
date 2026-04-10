using System;

namespace VerificaciónDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuario Mayor de Edad?\n");

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            bool esMayorDeEdad = edad >= 18;

            Console.WriteLine($"\n Resultado:");
            Console.WriteLine($"Edad ingresada: {edad} años");
            Console.WriteLine($"¿Es mayor de edad? {esMayorDeEdad}");

            if (esMayorDeEdad)
            {
                Console.WriteLine(" Eres mayor de edad. Puedes acceder.");
            }
            else
            {
                Console.WriteLine(" Eres menor de edad. Acceso denegado.");
            }
        }
    }
}
