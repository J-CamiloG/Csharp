using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEscuela.models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Profesor> Profesores = new List<Profesor>();


        //pedir los datos del estudiante 
        public static Estudiante PedirDatosEstudiante()
        {
            Console.WriteLine("Ingrese los datos del estudiante:");

            Console.Write("Nombre: ");
            string? nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string? apellido = Console.ReadLine();

            Console.Write("Tipo de documento: ");
            string? tipoDocumento = Console.ReadLine();

            Console.Write("Número de documento: ");
            string? numeroDocumento = Console.ReadLine();

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            Console.Write("Teléfono: ");
            string? telefono = Console.ReadLine();

            Console.Write("Dirección: ");
            string? direccion = Console.ReadLine();

            Console.Write("Nombre Acudiente: ");
            string? nombreAcudiente = Console.ReadLine();

            Console.Write("Curso: ");
            string? curso = Console.ReadLine();

            // Solicitar y leer la fecha de nacimiento
            Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
            string? fechaNacimientoStr = Console.ReadLine();
            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "d/M/yyyy", null);

            return new Estudiante(
                nombre, 
                apellido, 
                tipoDocumento, 
                numeroDocumento, 
                email, 
                telefono, 
                direccion, 
                fechaNacimiento, 
                nombreAcudiente, 
                curso);
        }

        //pedir calificaciones
        public static void PedirCalificaciones(Estudiante estudiante)
        {
            Console.WriteLine("Cuántas notas vas a agregar?: ");
            var notas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= notas; i++)
            {
                Console.WriteLine($"Escribe tu {i} nota: ");
                var nota = Convert.ToDouble(Console.ReadLine());
                estudiante.AgregarCalificaciones(nota);
            }
        } 

        // agrrgar estudiantes 
        public static void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        // agregar profesor 
        public static void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
        //mostrar estudiante
        public static void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        //mostrar estudiante
        public static void MostrarProfesor()
        {
            foreach (var profesor in Profesores)
            {
                profesor.MostrarDetalles();
            }
        }
    
        //Menu de la aplicacion 
        public static void ImprimirMenu()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("             MENÚ PRINCIPAL            ");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Agregar Profesor");
            Console.WriteLine("3. Mostrar Estudiantes");
            Console.WriteLine("4. Mostrar Profesores");
            Console.WriteLine("5. Salir");
            Console.WriteLine("=======================================");
            Console.Write("Seleccione una opción: ");
        }

        public static void PausarMenu()
        {   
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }
}