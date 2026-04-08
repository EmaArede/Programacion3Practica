using System;

namespace CajeroLogin
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("=== CAJERO AUTOMÁTICO ===\n");

            string[] usuarios = { "admin", "cajero1", "cajero2" };
            string[] claves = { "1234", "cajero2024", "pass456" };

            bool accesoPermitido = false;

            for (int intentos = 3; intentos > 0; intentos--)
            {
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string clave = Console.ReadLine();

                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (usuarios[i] == usuario && claves[i] == clave)
                    {
                        accesoPermitido = true;
                        break;
                    }
                }

                if (accesoPermitido)
                {
                    Console.WriteLine("\n Acceso concedido. Bienvenido, " + usuario);
                    Console.WriteLine("Redirigiendo al menú del cajero...\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"\n Usuario o contraseña incorrectos. Te quedan {intentos - 1} intentos.\n");
                }
            }

            if (!accesoPermitido)
            {
                Console.WriteLine(" Demasiados intentos fallidos. Acceso bloqueado.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
              }
    }
}