  Console.WriteLine("=== PROMEDIO DE TEMPERATURA - 5 DÍAS ===\n");

            double[] temperaturas = { 22.5, 23.8, 21.3, 24.0, 22.7 };
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            double suma = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
                Console.WriteLine($"{dias[i]}: {temperaturas[i]}°C");
            }

            double promedio = suma / temperaturas.Length;

            Console.WriteLine($"\n Suma de temperaturas: {suma}°C");
            Console.WriteLine($" Promedio de temperatura: {promedio:F2}°C");