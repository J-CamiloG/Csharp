using System;
using TallerEscuela.models;

class Program
{
    static void Main(string[] args)
    {
        var bandera = true;

        while (bandera)
        {
            AdministradorApp.ImprimirMenu();
            AdministradorApp.AgregarProfesoresEj();
            AdministradorApp.AgregarEstudiantesEj();
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "0":
                    bandera = false;
                    break;
                case "1":
                    var estudianteNuevo = AdministradorApp.PedirDatosEstudiante();
                    AdministradorApp.PedirCalificaciones(estudianteNuevo);
                    AdministradorApp.AgregarEstudiante(estudianteNuevo);
                    AdministradorApp.PausarMenu();
                    break;
                case "2":
                    var profesorNuevo = AdministradorApp.PedirDatosProfesor();
                    AdministradorApp.PedirAsignaturas(profesorNuevo);
                    AdministradorApp.AgregarProfesor(profesorNuevo);
                    AdministradorApp.PausarMenu();
                    break;
                case "3":
                    AdministradorApp.MostrarEstudiantes(AdministradorApp.Estudiantes);
                    AdministradorApp.PausarMenu();
                    break;
                case "4":
                    // Mostrar Profesores
                    AdministradorApp.MostrarProfesores(AdministradorApp.Profesores);
                    AdministradorApp.PausarMenu();
                    break;
                case "5":
                    // Editar estudiante
                    AdministradorApp.EjecutarEditar();
                    AdministradorApp.PausarMenu();
                    break;
                case "6":
                    // Editar profesor
                    break;
                case "7":
                    // Buscar por LINQ
                    AdministradorApp.MostrarMenuBusquedas();
                    break;
                case "8":
                // Eliminar profesor
                default:
                    break;
            }
        }
    }
}
