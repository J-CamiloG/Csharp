using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class Profesor : Persona
    {
        public string Asignatura;
        private double Salario;
        public DateTime FechaNacimiento;
        public List<string> Cursos;


        public Profesor(
            string nombre,
            string apellido,
            string tipoDocumento,
            DateTime fechaNacimiento,
            string telefono,
            string email,
            string asignatura,
            double salario
        ) 
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Email = email;
            Asignatura = asignatura;
            Salario = salario;
            Cursos = new List<string>();
        }
        public int CalcularAntiguedad()
        {
            int anios = DateTime.Now.Year - FechaNacimiento.Year;
            int meses = DateTime.Now.Month - FechaNacimiento.Month;
            if (meses < 0 || (meses == 0 && DateTime.Now.Day < FechaNacimiento.Day))
            {
                anios--;
            }
            return anios;
        }

        public void ObtenerSalario()
        {
            Console.WriteLine($"Salario: {this.Salario}");
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            Console.WriteLine($"Rol: Profesor");
            base.MostrarDetalles();
            Console.WriteLine($"Asignatura: {Asignatura}");
            ObtenerSalario();
            Console.WriteLine($"Antiguedad: {CalcularAntiguedad()} años");
            Console.WriteLine($"Cursos: ");
            // MostrarCursos();
        }
    }
}