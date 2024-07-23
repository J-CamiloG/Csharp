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

            var nuevoLibro = new Libro( autorIngresado, generoIngresado, precioIngresado, tituloIngresado, añoIngresado);
            Books.Add(nuevoLibro);
        }

        public void MostrarLibros()
        {
            foreach (var libro in Books)
            {
                libro.MostrarInformacion();
            }
        }

        public void EliminarLibro(string nombre)
        {
            var libroAEliminar = Books.Where(libro => libro.Titulo.ToLower().Contains(nombre.ToLower())).ToList();
            if (libroAEliminar.Count == 0)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }
            Books.Remove(libroAEliminar[0]);
        }

        public void BuscarLibro(string nombre)
        {
            var librosEncontrados = Books.Where(libro => libro.Titulo.ToLower().Contains(nombre.ToLower())).ToList();
                foreach (var libro in librosEncontrados)
                {
                    libro.MostrarInformacion();
                }

        }
    }
}
