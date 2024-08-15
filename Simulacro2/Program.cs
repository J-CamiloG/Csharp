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
                Console.WriteLine("2. Ver Los datos de Vehicles ");
                Console.WriteLine("3. Eliminar Vehiculo");
                Console.WriteLine("4. Añadir años de experiencia");
                Console.WriteLine("5. Editar menbrecia");
                Console.WriteLine("6. ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        system.Read();
                        break;
                    case "2":
                        system.ReadVehicles();
                        break;
                    case "3":
                        system.Delete();
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