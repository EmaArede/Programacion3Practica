using System;

namespace ConstantesBooleanas
{
    class Program
    {
        // Constantes booleanas
        const bool EDAD_MINIMA_REQUERIDA = false;
        const bool VERIFICACION_DOS_FACTORES = true;
        const bool MANTENIMIENTO_SISTEMA = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Mantenimiento de Sistema\n");

            Console.WriteLine($" ¿Edad mínima requerida? {EDAD_MINIMA_REQUERIDA}");
            Console.WriteLine($" ¿Verificación dos factores? {VERIFICACION_DOS_FACTORES}");
            Console.WriteLine($" ¿Sistema en mantenimiento? {MANTENIMIENTO_SISTEMA}");

            if (EDAD_MINIMA_REQUERIDA)
            {
                Console.WriteLine("\n No cumple con la edad mínima requerida");
            }
            else
            {
                Console.WriteLine("\n Acceso concedido.");
            }
        }
    }
}
