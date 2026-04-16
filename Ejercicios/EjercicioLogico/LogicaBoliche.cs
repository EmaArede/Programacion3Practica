using System;
namespace EjercicioLogicoBoliche
{
    class program
    
    {
        static void Main (string [] args)
        {
            
        string [] nombres  = new string [20]; 
        int [] edades = new int [20];

        Console.WriteLine("Ingresa el nombre y la edad");
        for (int i=0; i<20;i++)
            {
                Console.WriteLine($"Persona {i+1}:");
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Edad: ");
                edades[i] = int.Parse(Console.ReadLine());

            }
             for (int i=0; i<20; i++)
            {
                if (edades[i] >30)
                {
                    Console.WriteLine("Puede ingresar al boliche: " + nombres [i] + "edad: " + edades[i]);
                
                }
                else
                {
                    Console.WriteLine("No puede ingresar al boliche: " + nombres [i] + "edad: " + edades[i]);
                }

            }

        }

    }


}