// 5. Registro de un solo usuario por medio de DNI y legajo, con validación de los mismos

 Console.WriteLine(" Sistema de Registro \n");

            string  dniRegistrado = "";
            string  legajoRegistrado = "";
           
            Console.WriteLine("--- REGISTRO ---");
            Console.Write("Ingresa tu dni: ");
            dniRegistrado = Console.ReadLine();

            Console.Write("Ingresa una legajo: ");
            legajoRegistrado = Console.ReadLine();

            Console.WriteLine("\n✅ ¡Registro exitoso!\n");

            Console.WriteLine("--- INICIO DE SESIÓN ---");
            
            bool accesoCorrecto = false;
            int intentos = 3;

            while (intentos > 0 && !accesoCorrecto)
            {
                Console.Write("DNI: ");
                string dniIngresado = Console.ReadLine();

                Console.Write("legajo: ");
                string legajoIngresado = Console.ReadLine();

                if (dniIngresado == dniRegistrado && legajoIngresado == legajoRegistrado)
                {
                    accesoCorrecto = true;
                    Console.WriteLine($"\n ¡Bienvenido! Acceso concedido.");
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                        Console.WriteLine($"\n DNI o legajo incorrectos. Te quedan {intentos} intentos.\n");
                    else
                        Console.WriteLine("\n Acceso bloqueado. Demasiados intentos fallidos.");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
