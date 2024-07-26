using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class Persona
    {
        protected Guid Id;
        protected string Nombre;
        protected string Apellido;
        protected string TipoDocumento;
        protected string Direccion;
        protected string Correo;
        protected string NumeroDocumento;
        protected string Email;
        protected string Telefono;

        //metodo mostrar detalles
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo de documento: {TipoDocumento}");
            Console.WriteLine($"Numero de documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }

        public string ObtenerNumDocumento()
        {
            return NumeroDocumento;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public string ObtenerApellido()
        {
            return Apellido;
        }
    }
}