namespace MiApp.Poo;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set 
        { 
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }
            apellido = value; 
        }
    }
    public DateTime FechaNacimiento { get; set; }

    //constructor 
    public Estudiante(int id, string Nombre, string Apellido, DateTime fechaNacimiento)
    {
        Id = id;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        FechaNacimiento = fechaNacimiento;
    }
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

    public void printPersonas ()
    {
        Console.WriteLine($"Hola, {Nombre}");
        Console.WriteLine($"Hola, {Apellido}");
        Console.WriteLine($"Tienes {FechaNacimiento}  Años.");
        Console.WriteLine($"Tienes {Edad}  Años.");
    }
}
