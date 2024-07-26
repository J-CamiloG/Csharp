using System;
using System.Collections.Generic;
using System.Linq;

namespace TallerEscuela.models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public int Edad
        { 
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - FechaNacimiento.Year;

                if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
                return edad;
            }
        }
        public DateTime FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; }

        public Estudiante(
            string nombre,
            string apellido,
            string tipoDocumento,
            string numeroDocumento,
            string correo,
            string telefono,
            string direccion,
            DateTime fechaNacimiento,
            string nombreAcudiente,
            string cursoActual)
        {
            Id = new Guid();
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            NombreAcudiente = nombreAcudiente;
            CursoActual = cursoActual;
            Calificaciones = new List<double>();
        }

        // método para agregar calificación 
        public void AgregarCalificaciones(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        // método calcular promedio
        private void CalcularPromedio()
        {
            Console.WriteLine($"Promedio: {Calificaciones.Average():F2}");
        }

        // método mostrar calificación
        public void MostrarCalificaciones()
        {
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine($"{calificacion},");
            }
        }

        public static void FuncionEditarEstudiante(List<Estudiante> lista)
        {
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            var numDocumento = Console.ReadLine();
            var encontrado = lista.Find(estudiante => estudiante.ObtenerNumDocumento() == numDocumento);

            if ( encontrado != null )
            { 
                Console.Write("Email: ");
                encontrado.Correo = Console.ReadLine();

            }
        }

        // método mostrar detalles
        public override void MostrarDetalles() // override -> indica que se sobreescribe
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}"); 
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Calificaciones:");
            MostrarCalificaciones();
            Console.WriteLine($"Promedio:");
            CalcularPromedio();
        }
    }
}
