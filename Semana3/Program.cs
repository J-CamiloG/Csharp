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
            // List<Estudiante> listaEstudiante = new List<Estudiante>();

            // var x = new Estudiante( new Guid(), "camilo", new DateTime(1992, 7, 15), "gggg");

            // Estudiante.añadirEstudiante(listaEstudiante, x);
            // Estudiante.añadirEstudiante(listaEstudiante, x);
            
            // foreach (var estudiante in listaEstudiante)
            // {
            //     Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad},, Matricula: {estudiante.Matricula}");
            // }
        
        // ejercicio 7
            // Crear una nueva instancia de Tienda
            Tienda miTienda = new Tienda();

            // Crear algunas instancias de Prenda
            Prenda prenda1 = new Prenda ("camiseta", "L", 4500);
            Prenda prenda2 = new Prenda ("pantalon", "L", 4500);
            Prenda prenda3 = new Prenda ("chaqueta", "L", 4570);
            Prenda prenda4 = new Prenda ("pantalon", "L", 4500);
            Prenda prenda5 = new Prenda ("chaqueta", "L", 4500);
            Prenda prenda6 = new Prenda ("pantalon", "L", 4590);
            Prenda prenda7 = new Prenda ("chaqueta", "L", 4500);

            // Agregar las prendas a la tienda
            miTienda.AgregarProducto(prenda1);
            miTienda.AgregarProducto(prenda2);
            miTienda.AgregarProducto(prenda3);
            miTienda.AgregarProducto(prenda4);
            miTienda.AgregarProducto(prenda5);
            miTienda.AgregarProducto(prenda6);
            miTienda.AgregarProducto(prenda7);

            Console.WriteLine("Nombre del Producto");
            string nombre = Console.ReadLine();

            miTienda.BuscarProducto(nombre);
        
    }
}