namespace EjercicioArrays2
{
    internal class Program
    {
        static void Main (string [] args)
        {
            // Eercicio 1
            Console.WriteLine("Ejercicio 1");
            string [] frutas = {"manzana", "banana", "naranja", "pera", "uva"};
            Console.WriteLine("Lista de Frutas con Foreach:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine("Fruta: " +fruta);
            }

            //Ejercicio 2
            Console.WriteLine("Ejercicio 2");
            string [] colores = {"rojo", "verde", "azul", "amarillo"};
            Console.WriteLine("Lectura con Foreach:");
            foreach (string color in colores)
            {
                Console.WriteLine("Color:" + color);
            }

            //Ejercicio 3
            Console.WriteLine("Ejercicio 3");
            string [] animales = {"perro", "gato", "conejo", "pájaro"};
            Console.WriteLine("Recorrido foreach:");
            foreach (string animal in animales)
            {
                Console.WriteLine("Animal: " + animal);
            }

            //Ejercicio 4
            Console.WriteLine("Ejercicio 4");
            string [] paises = {"Argentina", "Brasil", "Italia", "Alemania"};
            Console.WriteLine("Impresión con foreach:");
            foreach (string pais in paises)
            {
                Console.WriteLine("País: " + pais);
            }
            //Ejercicio 5
            Console.WriteLine("Ejercicio 5");
            string [] hinchadas = {"River", "Boca", "San Martín", "Atletico"};
            Console.WriteLine("Recorrido con foreach:");
            foreach (string hinchada in hinchadas)
            {
                Console.WriteLine ("Hinchada:" + hinchada);
            }


        }

    }

}