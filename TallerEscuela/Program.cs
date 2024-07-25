using System;
using TallerEscuela.models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de gestión escolar");
        AdministradorApp.ImprimirMenu();
        var opción = Console.ReadLine();

        while (opción!= "0")
        {
            switch (opción)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                    
                    break;
                case "6":
                    
                    break;
                case "7":
                    
                    break;
                case "8":
                    
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
                }
        }
    }
}
