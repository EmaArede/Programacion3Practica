using System;

namespace ConstantesBooleanas
{
    class Program
    {
        // Constantes booleanas
        const bool EDAD_MINIMA_REQUERIDA = true;
        const bool VERIFICACION_DOS_FACTORES = true;
        const bool MANTENIMIENTO_SISTEMA = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Mantenimiento de Sistema\n");

            Console.WriteLine($" ¿Edad mínima requerida? {EDAD_MINIMA_REQUERIDA}");
            Console.WriteLine($" ¿Verificación dos factores? {VERIFICACION_DOS_FACTORES}");
            Console.WriteLine($" ¿Sistema en mantenimiento? {MANTENIMIENTO_SISTEMA}");

            if (MANTENIMIENTO_SISTEMA)
            {
                Console.WriteLine("\n El sistema está en mantenimiento. Intenta más tarde.");
            }
            else
            {
                Console.WriteLine("\n Sistema operativo normal.");
            }
        }
    }
}
