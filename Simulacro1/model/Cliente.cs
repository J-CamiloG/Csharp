using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro1.model
{
    public class Cliente : Persona
    {
        public string Email {get; set;}
        public string Telefono {get; set;}

        public Cliente(Guid id, string nombre, string apellido, string? numeroDocumento, byte edad, string email, string telefono)
        : base(id, nombre, apellido, numeroDocumento, edad)
    {
        Email = email;
        Telefono = telefono;
    }

        //mostrar informacion cliente
        public virtual void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Email: {Email}, Telefono: {Telefono}");
        }

        //metodo para pedir informacion
        public static Cliente PedirInformacion()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su número de documento: ");
            string? numeroDocumento = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese su email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            string telefono = Console.ReadLine();

            var nuevoCliente = new Cliente(new Guid(),nombre, apellido, numeroDocumento, edad, email, telefono);
            return nuevoCliente;
        }
    }
}