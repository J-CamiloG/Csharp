using System;

namespace MiApp.semana3 
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre.ToLower();
            FechaNacimiento = fechaNacimiento;
        }

        // Propiedad calculada para obtener la edad
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

        public void Saludar()
        {
            Console.WriteLine($"Hola, {Nombre}");
            Console.WriteLine($"Tienes {Edad}  Años.");
        }

        public void MostrarDetalles()
        {
            Saludar();
        }
    }

    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }


        public Coche( string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public void printInfo()
        {
            Console.WriteLine($"Marca : {Marca}");
            Console.WriteLine($"Modelo : {Modelo}");
            Console.WriteLine($"Año : {Año}");
        }
    }
}