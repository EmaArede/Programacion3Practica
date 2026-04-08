using System;

namespace RegistroUsuarioSimple
{
    class Program
    {
        static void Main(string[] args)
        {
  Console.WriteLine("=== SISTEMA DE REGISTRO DE USUARIO ===\n");

            string usuarioRegistrado = "";
            string contraseñaRegistrada = "";

            // REGISTRO
            Console.WriteLine("--- REGISTRO ---");
            Console.Write("Ingresa un nombre de usuario: ");
            usuarioRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("\n✅ ¡Registro exitoso!\n");

            // INICIO DE SESIÓN
            Console.WriteLine("--- INICIO DE SESIÓN ---");
            
            bool accesoCorrecto = false;
            int intentos = 3;

            while (intentos > 0 && !accesoCorrecto)
            {
                Console.Write("Usuario: ");
                string usuarioIngresado = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                if (usuarioIngresado == usuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
                {
                    accesoCorrecto = true;
                    Console.WriteLine("\n ¡Bienvenido! Acceso concedido.");
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