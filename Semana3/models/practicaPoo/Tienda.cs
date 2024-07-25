using System;

namespace Semana3.models.polimorfismo
{
    public class Tienda
    {
        public List<Prenda> Productos;

        public Tienda()
        {
            Productos = new List<Prenda>();
        }

        public void AgregarProducto(Prenda producto)
        {
            Productos.Add(producto);
        }

        public void BuscarProducto(string nombre)
        {
            var producto = Productos.Where(x => x.Nombre == nombre).ToList();

            foreach (var i in producto)
            {
                Console.WriteLine(@$"
                -------------------
                Nombre : {i.Nombre} 
                Precio : {i.Precio}
                -------------------
                ");
            }
        }
    }
}