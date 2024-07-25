using System;

namespace Semana3.models.polimorfismo
{
    public class Estudiante
    {
        public Guid Id {get; set;}
        public string Nombre { get; set; }
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
        public string Matricula { get; set;}

        public Estudiante(
            Guid id,
            string nombre,
            DateTime fechaNacimiento,
            string matricula
        )
        {
            Id = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Matricula = matricula;
        }

        public static void añadirEstudiante( List<Estudiante> lista, Estudiante nuevoEstudiante)
        {
            lista.Add(nuevoEstudiante);
        }
    }
}