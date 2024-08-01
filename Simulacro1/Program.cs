using System;

namespace Simulacro1.model
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresaSystem = new Empresa();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear un nuevo Empleado");
                Console.WriteLine("2. Leer todos los Empleados");
                Console.WriteLine("3. Mostrar Empleado por documento");
                Console.WriteLine("4. Mostrar Empleado por cargo");
                Console.WriteLine("5. Actualizar un Empleado");
                Console.WriteLine("6. Eliminar un Empleado");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("-----------Clientes-------------");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("7.Crear Nuevo Cliente");
                Console.WriteLine("8.Eliminar cliente");
                Console.WriteLine("9.Imprimir todos Clientes");
                Console.WriteLine("10. Salir");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var empleado = Empleado.PedirInformacion();
                        empresaSystem.Create(empleado);
                        break;
                    case "2":
                        empresaSystem.Read();
                        break;
                    case "3":
                        empresaSystem.BuscarEmpleadoPorDocumento();
                        break;
                    case "4":
                        empresaSystem.MostrarEmpleadosPorPosicion();
                        break;
                    case "5":
                        empresaSystem.Update();
                        break;
                    case "6":
                        empresaSystem.Delete();
                        break;
                    case "7":
                        var nuevoCliente = Cliente.PedirInformacion();
                        empresaSystem.Create(nuevoCliente);
                        break;
                    case "8":
                        empresaSystem.DeleteCliente();
                        break;
                    case "9":
                        empresaSystem.ReadClientes();
                        break;
                    case "10":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }
    }
    
}
