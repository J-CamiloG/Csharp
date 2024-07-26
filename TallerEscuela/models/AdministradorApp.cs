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
        
        //pedir dato asignaturas
        public static void PedirAsignaturas(Profesor profesor)
        {
            Console.WriteLine("Cuántas cursos tiene a cargo el profesor ?: ");
            var cursos = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cursos; i++)
            {
                Console.WriteLine($"Escribe el Curso {i}: ");
                var curso =Console.ReadLine();
                profesor.AgregarCursos(curso);
            }
        }
        //pedir datos del Profesor
        public static Profesor PedirDatosProfesor()
        {
            Console.WriteLine($"Nombre Profesor: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Apellido Profesor: ");
            string apellido = Console.ReadLine();

            Console.WriteLine($"Tipo Documento Profesor: ");
            string tipoDocumento = Console.ReadLine();

            // Solicitar y leer la fecha de ingreso
            Console.Write("Fecha de ingreso (dd/mm/yyyy): ");
            string? fechaIngresoStr = Console.ReadLine();
            DateTime fechaIngreso = DateTime.ParseExact(fechaIngresoStr, "dd/MM/yyyy", null);

            Console.WriteLine($"Telefono");
            string telefono = Console.ReadLine();

            Console.WriteLine($"Email");
            string email = Console.ReadLine();

            Console.WriteLine($"Asignatura");
            string asignatura = Console.ReadLine();

            Console.WriteLine($"Salario Profesor");
            double salario = Convert.ToDouble(Console.ReadLine());

            return new Profesor(
                nombre,
                apellido,
                tipoDocumento,
                fechaIngreso,
                telefono,
                email,
                asignatura,
                salario
            );
        }

        // agregar profesor 
        public static void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
        //mostrar estudiante
        public static void MostrarEstudiantes( List<Estudiante> listaEstudiantes )
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }
        }

        //mostrar estudiante
        public static void MostrarProfesores(List<Profesor> listaProfesores)
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
            Console.WriteLine("5. Editar estudiante");
            Console.WriteLine("6. Salir");
            Console.WriteLine("=======================================");
            Console.Write("Seleccione una opción: ");
        }

        public static void PausarMenu()
        {   
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        
        public static void EjecutarEditar()
        {
            Estudiante.FuncionEditarEstudiante(Estudiantes);
        }

        public static void EliminarEstudiante(Estudiante estudiante)
        {
            Console.WriteLine($"¿Está seguro que desea eliminar a {estudiante.ObtenerNombre()}? (si/no)");
            var confirmacion = Console.ReadLine();
            if (confirmacion.Equals("si", StringComparison.CurrentCultureIgnoreCase)) // Valida el si sin importar mayus o minus.
            {
                Estudiantes.Remove(estudiante);
                Console.WriteLine($"El estudiante {estudiante.ObtenerNombre()} fue eliminado");
            }
        }

        public static void AgregarEstudiantesEj() 
        {
            var estudiante1 = new Estudiante("Juan", "Pérez", "CC", "12345678", "juan.perez@example.com", "555-1234", "María Pérez", new DateTime(1997,08,16) ,"acudiente t", "novno" );
            var estudiante2 = new Estudiante("María", "Gómez", "TI", "87654321", "maria.gomez@example.com", "555-5678", "Luis Gómez", new DateTime(1997,08,16) ,"acudiente t", "novno" );
            var estudiante3 = new Estudiante("Carlos", "Rodríguez", "CC", "11223344", "carlos.rodriguez@example.com", "555-9876", "Ana Rodríguez", new DateTime(1997,08,16) ,"acudiente t", "novno"  );
            var estudiante4 = new Estudiante("Lucía", "Martínez", "TI", "44332211", "lucia.martinez@example.com", "555-6543", "Pedro Martínez", new DateTime(1997,08,16) ,"acudiente t", "novno" );
            var estudiante5 = new Estudiante("Pedro", "López", "CC", "99887766", "pedro.lopez@example.com", "555-3210", "Sofía López", new DateTime(1997,08,16) ,"acudiente t", "novno"  );

            Estudiantes.Add(estudiante1);
            Estudiantes.Add(estudiante2);
            Estudiantes.Add(estudiante3);
            Estudiantes.Add(estudiante4);
            Estudiantes.Add(estudiante5);

            estudiante1.AgregarCalificaciones(75);
            estudiante1.AgregarCalificaciones(85);
            
            estudiante2.AgregarCalificaciones(85);
            estudiante2.AgregarCalificaciones(55);

            estudiante3.AgregarCalificaciones(65);
            estudiante3.AgregarCalificaciones(100);

            estudiante4.AgregarCalificaciones(90);
            estudiante4.AgregarCalificaciones(50);

            estudiante5.AgregarCalificaciones(95);
            estudiante5.AgregarCalificaciones(50);

        }

        public static void AgregarProfesoresEj() 
        {

            var profesor1 = new Profesor("Laura", "González", "CC", new DateTime(1997,08,16), "123456789", "laura.gonzalez@example.com","Matemáticas", 8000000);
            var profesor2 = new Profesor("carla", "González", "CC", new DateTime(1997,08,16), "123456789", "laura.gonzalez@example.com","Matemáticas", 8000000);
            var profesor3 = new Profesor("carme", "González", "CC", new DateTime(1997,08,16), "123456789", "laura.gonzalez@example.com","Matemáticas", 8000000);

            Profesores.Add(profesor1);
            Profesores.Add(profesor2);
            Profesores.Add(profesor3);

            profesor1.AgregarCursos("sexto");
            profesor1.AgregarCursos("séptimo");
            profesor2.AgregarCursos("octavo");
            profesor2.AgregarCursos("décimo");
            profesor3.AgregarCursos("once");
            profesor3.AgregarCursos("noveno");
        }
        
        public static void MostrarMenuBusquedas()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                               Busquedas LINQ                                            ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                             1. Filtrar por promedio                                     ");
            Console.WriteLine("                             2. Filtrar profesores por cantidad de cursos                ");
            Console.WriteLine("                             3. Filtrar Estudiantes por edad                             ");
            Console.WriteLine("                             4. Filtrar por apellido                                     ");
            Console.WriteLine("                             5. Salario de todos los profesores                          ");
            Console.WriteLine("                             6. Filtrar por calificación                                 ");
            Console.WriteLine("                             7. Cantidad de estudiantes por curso                        ");
            Console.WriteLine("                             8. Filtrar por antiguedad                                   ");
            Console.WriteLine("                             9. Obtener asignaturas                                      ");
            Console.WriteLine("                            10. Filtrar por nombre                                       ");
            Console.WriteLine("                            11. Ordenar profesores por salario                           ");
            Console.WriteLine("                            12. Promedio de edad de estudiantes.                         ");
            Console.WriteLine("                            13. Filtrar profesores por curso                             ");
            Console.WriteLine("                            14. Filtrar por estudiantes con calificaciones registradas.  ");
            Console.WriteLine("                            15. Promedio de antigüedad de profesores.                   ");
            Console.WriteLine("                             0. Salir                                                    ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Selecciona una opción: ");
        }
    }
}