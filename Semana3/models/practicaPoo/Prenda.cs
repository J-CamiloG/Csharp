using System;

namespace Semana3.models.polimorfismo
{
    public class Prenda{
        public string Nombre;
        public string Talla;
        public decimal Precio;

        public Prenda(
            string nombre,
            string talla,
            decimal precio
        )
        {   
            Nombre = nombre;
            Talla = talla;
            Precio = precio;
        }
    }
}