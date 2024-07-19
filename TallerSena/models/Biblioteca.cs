using System;
using System.Collections.Generic;
using MiApp.ClassLibro;

namespace MiApp.ClassBiblioteca
{
    public class Biblioteca
    {
        public List<Libro> Books { get; set; }

        public Biblioteca()
        {
            Books = new List<Libro>();
        }

        public void AgregarLibro()
        {
            Console.WriteLine("Ingresa el id");
            if (!int.TryParse(Console.ReadLine(), out int idIngresado))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            Console.WriteLine("Ingrese autor");
            string? autorIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese género");
            string? generoIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese título");
            string? tituloIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese año de publicación");
            string? añoIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese precio");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precioIngresado))
            {
                Console.WriteLine("Precio inválido.");
                return;
            }

            var nuevoLibro = new Libro(idIngresado, autorIngresado, generoIngresado, precioIngresado, tituloIngresado, añoIngresado);
            Books.Add(nuevoLibro);
        }

        public void MostrarLibros()
        {
            foreach (var libro in Books)
            {
                libro.MostrarInformacion();
            }
        }

        public void EliminarLibro(int id)
        {
            var libroAEliminar = Books.Find(libro => libro.Id == id);
            if (libroAEliminar != null)
            {
                Books.Remove(libroAEliminar);
                Console.WriteLine("Libro eliminado.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        public void BuscarLibro(int id)
        {
            var libroEncontrado = Books.Find(libro => libro.Id == id);
            if (libroEncontrado != null)
            {
                libroEncontrado.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    }
}
