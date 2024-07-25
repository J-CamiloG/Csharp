using Semana3.models.polimorfismo;
using Semana3.models.practicaPoo;
namespace App;
class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        // ejercicios del 1-4   
            // Carro carro = new Carro(new Guid(), "Mustang", "1997");
            // carro.acelerar();
        
        // ejercicios  5
            List<Estudiante> listaEstudiante = new List<Estudiante>();

            var x = new Estudiante( new Guid(), "camilo", new DateTime(1992, 7, 15), "gggg");

            Estudiante.añadirEstudiante(listaEstudiante, x);
            Estudiante.añadirEstudiante(listaEstudiante, x);
            
            foreach (var estudiante in listaEstudiante)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad},, Matricula: {estudiante.Matricula}");
            }
        
        // ejercicio 6
            // Habitacion habitacion = new Habitacion("29", "estandar");
            // Reserva reserva = new Reserva();
    }
}