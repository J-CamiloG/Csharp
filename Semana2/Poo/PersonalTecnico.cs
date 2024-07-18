using System;

namespace MiApp.classPersonalTecnico
{
    public class PersonalTecnico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
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
        public string Documento { get; set; }
        public string TallaSuperior { get; set; }
        public string TallaInferior { get; set; }
        public string TallaCalzado { get; set; }

        // Constructor
        public PersonalTecnico(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string documento,
            string tallaSuperior,
            string tallaInferior,
            string tallaCalzado
        )
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Documento = documento;
            TallaSuperior = tallaSuperior;
            TallaInferior = tallaInferior;
            TallaCalzado = tallaCalzado;
        }

        /// Método para imprimir los datos del personal técnico, 
        // para poder que las clases nos permitam mas adelante sobrescibir este 
        // metodo para poder agregare lo que deberia imprimir segun cada clase, 
        // la calse debe ser VIRTUAL y cuando la modifiquemos debe ser OVERRIDE
        public virtual void ImprimirDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Fecha de Nacimiento: " + FechaNacimiento.ToShortDateString());
            Console.WriteLine("Documento: " + Documento);
            Console.WriteLine("Talla Superior: " + TallaSuperior);
            Console.WriteLine("Talla Inferior: " + TallaInferior);
            Console.WriteLine("Talla de Calzado: " + TallaCalzado);
        }
    }
}
