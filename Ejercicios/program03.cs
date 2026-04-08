int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== CONVERSOR DE UNIDADES ===\n");
                Console.WriteLine("1. Convertir °F a °C");
                Console.WriteLine("2. Convertir pies a metros");
                Console.WriteLine("3. Salir");
                Console.Write("\nSelecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConvertirFahrenheitACelsius();
                        break;
                    case 2:
                        ConvertirPiesAMetros();
                        break;
                    case 3:
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("\n Opción no válida.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                }

            } while (opcion != 3);
             static void ConvertirFahrenheitACelsius()
        {
            Console.Clear();
            Console.WriteLine("=== CONVERTIR °F A °C ===\n");

            Console.Write("Ingresa la temperatura en °F: ");
            double fahrenheit = double.Parse(Console.ReadLine());

        
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"\n {fahrenheit}°F = {celsius:F2}°C");
        }

        static void ConvertirPiesAMetros()
        {
            Console.Clear();
            Console.WriteLine("=== CONVERTIR PIES A METROS ===\n");

            Console.Write("Ingresa la longitud en pies: ");
            double pies = double.Parse(Console.ReadLine());

            
            double metros = pies * 0.3048;

            Console.WriteLine($"\n {pies} pies = {metros:F2} metros");
        }