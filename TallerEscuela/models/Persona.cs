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
        protected string NumeroDocumento;
        protected string Email;
        protected string Telefono;


        //metodo mostrar detalles
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo Documento: {TipoDocumento}");
            Console.WriteLine($"Número Documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }
    }
}