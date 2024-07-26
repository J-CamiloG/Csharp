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
                    // Agregar Profesor
                    AdministradorApp.PausarMenu();
                    break;
                case "3":
                    AdministradorApp.MostrarEstudiantes();
                    AdministradorApp.PausarMenu();
                    break;
                case "4":
                    // Mostrar Profesores
                    AdministradorApp.PausarMenu();
                    break;
                case "5":
                    // Editar estudiante
                    break;
                case "6":
                    // Editar profesor
                    break;
                case "7":
                    // Eliminar estudiante
                    break;
                case "8":
                // Eliminar profesor
                default:
                    break;
            }
        }
    }
}
