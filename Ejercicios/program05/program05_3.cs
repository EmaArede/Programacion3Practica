// 3 este programa verifica la identida predefinida del usuario con un sistema booleano

using System;

namespace VerificarIdentidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" VAlidar Identidad\n");

            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "1234";

            Console.Write("Ingresa tu usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingresa tu contraseña: ");
            string contraseña = Console.ReadLine();

            bool identidadValida = (usuario == usuarioCorrecto) && (contraseña == contraseñaCorrecta);

            Console.WriteLine($"\n Resultado:");
            Console.WriteLine($"¿Identidad verificada? {identidadValida}");

            if (identidadValida)
            {
                Console.WriteLine(" Acceso concedido.");
            }
            else
            {
                Console.WriteLine(" Acceso denegado.");
            }
        }
    }
}