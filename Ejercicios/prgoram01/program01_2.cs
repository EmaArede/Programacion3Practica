// 2. Registro de un solo usuario por medio de mail y contraseña, con validación de los mismos
 Console.WriteLine(" Sistema de Registro \n");

            string  emailRegistrado = "";
            string  contraseñaRegistrada = "";
           
            Console.WriteLine("--- REGISTRO ---");
            Console.Write("Ingresa tu email: ");
            emailRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("\n✅ ¡Registro exitoso!\n");

            Console.WriteLine("--- INICIO DE SESIÓN ---");
            
            bool accesoCorrecto = false;
            int intentos = 3;

            while (intentos > 0 && !accesoCorrecto)
            {
                Console.Write("Email: ");
                string emailIngresado = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                if (emailIngresado == emailRegistrado && contraseñaIngresada == contraseñaRegistrada)
                {
                    accesoCorrecto = true;
                    Console.WriteLine($"\n ¡Bienvenido! Acceso concedido.");
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                        Console.WriteLine($"\n Email o contraseña incorrectos. Te quedan {intentos} intentos.\n");
                    else
                        Console.WriteLine("\n Acceso bloqueado. Demasiados intentos fallidos.");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
