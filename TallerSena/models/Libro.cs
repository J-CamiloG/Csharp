using System;
using MiApp.ClassPublicacion;

namespace MiApp.ClassLibro
{
    public class Libro : Publicacion
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }

        public Libro(
            int id, 
            string autor, 
            string genero, 
            decimal precio,
            string titulo,
            string añoPublicacion
        ) : base(titulo, añoPublicacion)
        {
            Id = id;
            Autor = autor;
            Genero = genero;
            Precio = precio;
        }

        // Método para mostrar información del libro
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Autor: {Autor}, Genero: {Genero}, Precio: ${Precio}, Título: {Titulo}, Año: {AñoPublicacion}");
        }

        // Método para calcular el descuento del libro
        public decimal CalcularDescuento(decimal descuento)
        {
            return Precio - (Precio * descuento);
        }

        // Método para verificar que el libro no tiene más de 5 años de publicado
        public bool EsLibroAntiguo()
        {
            DateTime hoy = DateTime.Now;
            int aniosPublicados = hoy.Year - int.Parse(AñoPublicacion);
            return aniosPublicados > 5;
        }
    }
}
