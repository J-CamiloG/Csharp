using System;
using MiApp.ClassLibro;
using MiApp.ClassBiblioteca;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("*                                    *");
                Console.WriteLine("*          Biblioteca Virtual        *");
                Console.WriteLine("*                                    *");
                Console.WriteLine("**************************************");
                Console.WriteLine("* Seleccione una opción:             *");
                Console.WriteLine("*                                    *");
                Console.WriteLine("* 1. Agregar libro                   *");
                Console.WriteLine("* 2. Mostrar libros                  *");
                Console.WriteLine("* 3. Buscar libro                    *");
                Console.WriteLine("* 4. Eliminar libro                  *");
                Console.WriteLine("* 5. Salir                           *");
                Console.WriteLine("*                                    *");
                Console.WriteLine("**************************************");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        biblioteca.AgregarLibro();
                        break;
                    case "2":
                        biblioteca.MostrarLibros();
                        break;
                    case "3":
                        Console.WriteLine("Ingresa el nombre del libro");
                        biblioteca.BuscarLibro(Console.ReadLine());
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el nombre del libro a eliminar:");
                        biblioteca.EliminarLibro(Console.ReadLine());
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
