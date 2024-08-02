using System;
using Simulacro2.model;


namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            var system = new Aplication();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ver Los datos de Driver ");
                Console.WriteLine("2. Editar licensia de conduccion");
                Console.WriteLine("3. Eliminar vehiculo");
                Console.WriteLine("4. Editar menbrecia");
                Console.WriteLine("5. ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        system.Read();
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }
    }
}