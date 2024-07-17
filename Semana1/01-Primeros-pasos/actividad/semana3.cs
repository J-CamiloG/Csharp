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

        public void ActualizarAño(int nuevoAño)
        {
            Año = nuevoAño;
        }
    }

    public class Libro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo.ToUpper();
            Autor = autor;
        }

        public static void printLibros(List<Libro> lista)
        {   
            foreach (var libro in lista)
            {
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}");
            }
        }

        public static void contarTexto(string text)
        {
            Console.WriteLine(text.Length);
        }
    }

    public class Calculadora
    {
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }

        public Calculadora(decimal num1, decimal num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public static void Sumar(int Num1, int Num2)
        {
            Console.WriteLine(Num1 + Num2);
        }

        public static void restar(int Num1, int Num2)
        {
            Console.WriteLine(Num1 - Num2) ;
        }

        public static void multiplicar(int Num1, int Num2)
        {
            Console.WriteLine(Num1 * Num2) ;
        }
    }

    public class Productos
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }


        public Productos(string nombre, decimal precio)
        {
            Nombre = nombre.ToLower();
            Precio = precio;
        }

        public static void printProductos(List<Productos> listaProductos)
        {
            foreach (var item in listaProductos)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Precio: {item.Precio}");
            }
        }
    }

    public class Empleado
{
    private int Id { get; set;}
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    private double SueldoBase { get; set; }
    public double PorcentajePension { get; set; }
    public double PorcentajeSalud { get; set; }
    private double PorcentajeAhorroCoperativa {get; set;}

    public Empleado(int id, string nombre, string apellido, string correo, double sueldoBase, double porcentajePension, double porcentajeSalud, double porcentajeAhorroCoperativa)
    {
        Id = id;
        Nombre = nombre.ToLower();
        Apellido = apellido.ToLower();
        Correo = correo.ToLower();
        SueldoBase = sueldoBase;
        PorcentajePension = porcentajePension;
        PorcentajeSalud = porcentajeSalud;
        PorcentajeAhorroCoperativa = porcentajeAhorroCoperativa;
    }

    public double CalcularSueldoNeto()
    {
        double deducciones = CalcularDeducciones();
        double ahorro = CalcularAhorro();
        double sueldoNeto = SueldoBase - deducciones - ahorro;
        return sueldoNeto;
    }


    private double CalcularDeducciones()
    {
        double deduccionesPension = SueldoBase * PorcentajePension;
        double deduccionesSalud = SueldoBase * PorcentajeSalud;
        return deduccionesPension + deduccionesSalud;
    }

    private double CalcularAhorro()
    {
        return SueldoBase * PorcentajeAhorroCoperativa;
    }
}

}