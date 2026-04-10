// 2 en este programa se incluye una función booleana que veriifica la edad ingresada

using System;

namespace MayorEdadFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificación de Edad \n");

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            bool esMayor = VerificarMayorEdad(edad);

            Console.WriteLine($"\n Edad: {edad} años");
            Console.WriteLine($"¿Mayor de edad? {esMayor}");

            if (esMayor)
                Console.WriteLine(" Acceso permitido.");
            else
                Console.WriteLine(" Acceso denegado.");
        }

        static bool VerificarMayorEdad(int edad)
        {
            return edad >= 18;
        }
    }
}