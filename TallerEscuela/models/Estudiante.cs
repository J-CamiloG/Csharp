using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente;
        public string CursoActual;
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
        public DateTime FechaNacimiento;
        public List<double> Calificaciones;
        

        public Estudiante(
            string nombreAcudiente,
            string cursoActual,
            DateTime fechaNacimiento
        )
        {
            NombreAcudiente = nombreAcudiente;
            CursoActual = cursoActual;
            FechaNacimiento = fechaNacimiento;
            Calificaciones = new List<double>();
        }


        // metodo paraagregar calificacion 

        public void AgregarCalificaciones(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        private void CalcularPromedio()
        {
            Console.WriteLine($"Promedio: {Calificaciones.Average():F2}");
        }

        public void MostrarCalificaciones()
        {
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine($"{calificacion},");
            }
        }

        public override void MostrarDetalles() //override -> indica que se sobreescribir
        {
            base.MostrarDetalles();
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine("Calificaciones: ");
            MostrarCalificaciones();
            CalcularPromedio();
        }
    }
}
