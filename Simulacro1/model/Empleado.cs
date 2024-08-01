using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro1.model
{
    public class Empleado : Persona
    {
        public string? Posicion {get; set;}
        public double Salario {get; set;}

        public Empleado(Guid id, string nombre, string apellido, string? numeroDocumento, byte edad, string posicion, double salario)
        : base(id, nombre, apellido, numeroDocumento, edad)
        {
        Posicion = posicion;
        Salario = salario;
        }

        //metodo calcular Bonificacion 
        public double CalcularBonificacion()
        {
            return Salario * 0.1;
        }

        // metodo pedir infomracion y retornar el empleado
        public static Empleado PedirInformacion()
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su número de documento: ");
            string? numeroDocumento = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese su posición: ");
            string cargo = Console.ReadLine();
            Console.WriteLine("Ingrese su salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            var nuevoEmpleado = new Empleado(new Guid(), nombre, apellido, numeroDocumento, edad, cargo, salario);
            return nuevoEmpleado; 
        }

        //metodo mostrar informacion
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Posicion: {Posicion}, Salario: {Salario}");
        }
    }
}