//4 registro de multilpes usuarios utilizando un diccionario para el almacenamiento de los mismos
using System;

namespace RegistroUsuarioMenu
{
    class Program
    {
        static Dictionary<string, string> usuarios = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido\n");
                Console.WriteLine("1. Registrar nuevo usuario");
                Console.WriteLine("2. Iniciar sesión");
                Console.WriteLine("3. Salir");
                Console.Write("\nSelecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarUsuario();
                        break;
                    case 2:
                        IniciarSesion();
                        break;
                    case 3:
                        Console.WriteLine("\n Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }

        static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine(" Registro \n");

            Console.Write("Ingresa nombre de usuario: ");
            string nombre = Console.ReadLine();

            if (usuarios.ContainsKey(nombre))
            {
                Console.WriteLine(" El nombre de usuario ya existe. Intenta con otro.");
                return;
            }

            Console.Write("Ingresa contraseña: ");
            string contraseña = Console.ReadLine();

            usuarios.Add(nombre, contraseña);
            Console.WriteLine("\n ¡Usuario registrado exitosamente!");
        }

        static void IniciarSesion()
        {
            Console.Clear();
            Console.WriteLine(" Inicio de Sesión\n");

            int intentos = 3;

            while (intentos > 0)
            {
                Console.Write("Usuario: ");
                string nombre = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuarios.ContainsKey(nombre) && usuarios[nombre] == contraseña)
                {
                    Console.WriteLine($"\n ¡Bienvenido {nombre}! Acceso concedido.");
                    return;
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
        }
    }
}