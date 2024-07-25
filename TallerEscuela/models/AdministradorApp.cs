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
        public Estudiante PedirDatosEstudiante()
        {
            Console.WriteLine("Ingrese los datos del estudiante:");
            Console.Write("Nombre: ");
            string? nombre = Console.ReadLine();
            Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Curso: ");
            string? curso = Console.ReadLine();

            Estudiante nuevoEstudiante = new Estudiante(nombre, curso, fechaNacimiento);
            return nuevoEstudiante;
        }
        // agrrgar estudiantes 
        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        // agregar profesor 
        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
        //mostrar estudiante
        public void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        //mostrar estudiante
        public void MostrarProfesor()
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

        public void PausarMenu()
        {   
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }
}