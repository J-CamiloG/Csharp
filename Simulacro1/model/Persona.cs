using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro1.model
{
    public abstract class Persona
    {
        public Guid Id {get; set;}
        protected string Nombre { get; set;}
        protected string Apellido { get; set;}
        protected string? NumeroDocumento {get; set;}
        protected byte Edad { get; set;}

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public string? GetNumeroDocumento()
        {
            return NumeroDocumento;
        }

        public byte GetEdad()
        {
            return Edad;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        
        public void SetApellido(string apellido)
        {
            Apellido = apellido;
        }
        
        public void SetNumeroDocumento(string? numeroDocumento)
        {
            NumeroDocumento = numeroDocumento;
        }
        
        public void SetEdad(byte edad)
        {
            Edad = edad;
        }
        
        public Persona(Guid id, string nombre, string apellido, string? numeroDocumento, byte edad)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        NumeroDocumento = numeroDocumento;
        Edad = edad;
    }

        //mostrar informacion persona
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Id: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Numero Documento: {NumeroDocumento}, Edad: {Edad}");
        }
    }
}