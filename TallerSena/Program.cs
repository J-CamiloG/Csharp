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
                        Console.WriteLine("Ingrese el ID del libro a buscar:");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            biblioteca.BuscarLibro(idBuscar);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el ID del libro a eliminar:");
                        if (int.TryParse(Console.ReadLine(), out int idEliminar))
                        {
                            biblioteca.EliminarLibro(idEliminar);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
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
