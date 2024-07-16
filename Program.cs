using System;
using MiApp.TiposDeDatos;
using MiApp.NumerosYMetodos;
using MiApp.StringYMetodos;
using MiApp.PracticeLinQ;
using MiApp.EjerciciosPractice;
using MiApp.Entregable;
using MiApp.semana3;
using MiApp.Poo;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Instanciamos la clase ClaseDeTipos y llamamos a su método MostrarTiposDeDatos
            // ClaseDeTipos miObjetoDatos = new ClaseDeTipos();
            // miObjetoDatos.MostrarTiposDeDatos();

            // // // // Instanciamos la clase ClaseDeNumerosYMetodos y llamamos a su método MostrarMetodosNumeros
            // ClaseDeNumerosYMetodos miObjetoNumerosYMetodos = new ClaseDeNumerosYMetodos();
            // miObjetoNumerosYMetodos.MostrarMetodosNumeros();

            // // // // Instanciamos la clase ClaseDeStringYMetodos y llamamos a su método MostrarStringYMetodos
            // ClaseDeStringYMetodos miObjetoStringYMetodos = new ClaseDeStringYMetodos();
            // miObjetoStringYMetodos.MostrarStrindYMetodos();
            
            // ClassPracticeLinQ miObjectPracticeLinQ = new ClassPracticeLinQ();
            // miObjectPracticeLinQ.primtPracticeLinQ();

            // ClassEjercicicosPractice miObjetoEjerciciosPractice = new ClassEjercicicosPractice();
            // miObjetoEjerciciosPractice.printEjerciciosPractice();\

            // ClassEntregable miObjetoEntregable =  new ClassEntregable();
            // miObjetoEntregable.printEntregable();

            //intancia persona 
            // Persona persona = new Persona("Juan Camilo", new DateTime(1997, 08, 16));
            // persona.MostrarDetalles();

            // //intancia coche
            // Coche coche = new Coche("Mazda", "1997", 1997);
            // coche.ActualizarAño(1998);
            // coche.printInfo();
            
            // // intancia de libros
            // List<Libro> listaLibros = new List<Libro>
            // {
            //     new Libro("Cien años de soledad", "Gabriel García Márquez"),
            //     new Libro("El Quijote", "Miguel de Cervantes"),
            //     new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling")
            // };

            // string texto = "hola comoe estas?";

            // Libro.printLibros(listaLibros);
            // Libro.contarTexto(texto);


            // //intancia de la calculadora
            // Calculadora calculadora = new Calculadora(55, 60);
            // Calculadora.Sumar(55, 60);
            // Calculadora.restar(55, 60);
            // Calculadora.multiplicar(55, 60);

            // //intancia de productos
            // List<Productos> listaProductos = new List<Productos>
            // {
            //     new Productos("Huevos", 3000),
            //     new Productos("Leche", 1800),
            //     new Productos("Pan", 1600)
            // };

            // Productos.printProductos(listaProductos);

            // Console.Clear();
            // Estudiante estudiantes = new Estudiante(23, "camilo", "campillo", new DateTime(1997, 08, 16));
            // estudiantes.Apellido = "";
            // estudiantes.printPersonas();

            int id = 1;
            string nombre = "Juan";
            string apellido = "Pérez";
            string correo = "juan.perez@example.com";
            double sueldoBase = 1000000;
            double porcentajePension = 0.04; 
            double porcentajeSalud = 0.04; 
            double porcentajeAhorroCoperativa = 0.2; 

            Empleado empleado = new Empleado(id, nombre, apellido, correo, sueldoBase, porcentajePension, porcentajeSalud, porcentajeAhorroCoperativa);

            double sueldoNeto = empleado.CalcularSueldoNeto();

            Console.WriteLine($"El sueldo neto de {empleado.Nombre} {empleado.Apellido} es: {sueldoNeto:C}");
            }
    }
}
