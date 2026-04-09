//registro de usuario con nombre y contraseña
using System;

namespace RegistroNombreSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de Usuario\n");

            string nombreRegistrado = "";
            string contraseñaRegistrada = "";

         
            Console.WriteLine("--- REGISTRO ---");
            Console.Write("Ingresa tu nombre de usuario: ");
            nombreRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("\n ¡Registro exitoso!\n");

           
            Console.WriteLine("--- INICIO DE SESIÓN ---");
            
            bool accesoCorrecto = false;
            int intentos = 3;

            while (intentos > 0 && !accesoCorrecto)
            {
                Console.Write("Usuario: ");
                string nombreIngresado = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                if (nombreIngresado == nombreRegistrado && contraseñaIngresada == contraseñaRegistrada)
                {
                    accesoCorrecto = true;
                    Console.WriteLine($"\n ¡Bienvenido {nombreRegistrado}! Acceso concedido.");
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                        Console.WriteLine($"\n Usuario o contraseña incorrectos. Te quedan {intentos} intentos.\n");
                    else
                        Console.WriteLine("\n Acceso bloqueado. Demasiados intentos fallidos.");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}