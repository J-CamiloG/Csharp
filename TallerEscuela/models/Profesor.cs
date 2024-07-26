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
        public DateTime FechaIngreso;
        public List<string> Cursos;


        public Profesor(
            string nombre,
            string apellido,
            string tipoDocumento,
            DateTime fechaIngreso,
            string telefono,
            string email,
            string asignatura,
            double salario
        ) 
        {
            Id = new Guid();
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
            Email = email;
            Asignatura = asignatura;
            Salario = salario;
            Cursos = new List<string>();
        }

        //metodo para agregar cursos
        public void AgregarCursos(string curso)
        {
            Cursos.Add(curso);
        }
        public int CalcularAntiguedad()
        {
            int anios = DateTime.Now.Year - FechaIngreso.Year;
            int meses = DateTime.Now.Month - FechaIngreso.Month;
            if (meses < 0 || (meses == 0 && DateTime.Now.Day < FechaIngreso.Day))
            {
                anios--;
            }
            return anios;
        }

        public void MostrarCursos()
        {
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso);
            }
        }
        public double ObtenerSalario()
        {
            return Salario;
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            
            Console.WriteLine($"Rol: Profesor");
            Console.WriteLine($"Asignatura: {Asignatura}");
            ObtenerSalario();
            Console.WriteLine($"Antiguedad: {CalcularAntiguedad()} años");
            Console.WriteLine($"Cursos: ");
            MostrarCursos();
        }
    }
}