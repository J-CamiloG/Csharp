using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Simulacro1.model
{
    public class Empresa
    {
        public string NombreEmpresa {get; set;}
        public string Direccion {get; set;}
        // lista de empleados 
        private readonly List<Empleado> _empleados;
        private readonly List<Cliente> _clientes;
        

        public Empresa()
    {
        _empleados = new List<Empleado>
        {
            new Empleado (Guid.NewGuid(),"Juan","Pérez","54",27,"operario",456677),
            new Empleado (Guid.NewGuid(),"Camilo","Campillo","26",27,"operario",456677),
            new Empleado (Guid.NewGuid(),"carlor","Pérez","54",27,"operario",456677)
        };
        _clientes = new List<Cliente>
        {
            new Cliente (Guid.NewGuid(),"Juan","Pérez","54",27,"1234567890", "45647"),
            new Cliente (Guid.NewGuid(),"Camilo","Campillo","26",27,"9876543210", "45647"),
            new Cliente (Guid.NewGuid(),"Carlor","Pérez","54",27,"1234567890", "45647")
        };
    }
        //lista de clientes
        //-------------------------metodos el CRUD-----------------
        public void Create(object nuevo)
        {
            if (nuevo == null)
            {
                Console.WriteLine("El objeto no puede ser null.");
                return;
            }

            if (nuevo is Empleado nuevoEmpleado)
            {
                _empleados.Add(nuevoEmpleado);
                Console.WriteLine("Empleado agregado exitosamente.");
            }
            else if (nuevo is Cliente nuevoCliente)
            {
                _clientes.Add(nuevoCliente);
                Console.WriteLine("Cliente agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Tipo no soportado.");
            }
        }

        public void Read()
        {
            foreach (var i in _empleados )
            {
                i. MostrarInformacion();
            }
        }

        public void ReadClientes()
        {
            foreach (var i in _clientes )
            {
                i. MostrarInformacion();
            }
        }

        public void Update()
        {
            Console.WriteLine("Ingrese el Nombre del Empleado a actualizar:");
            string? nombreBuscado = Console.ReadLine();
            var empleadosToUpdate = _empleados.Where(c => c.GetNombre() == nombreBuscado).ToList();

            if (empleadosToUpdate.Any())
            {
                foreach (var empleado in empleadosToUpdate)
                {
                    Console.WriteLine($"Actualizando Empleado con ID: {empleado.Id}");

                    Console.WriteLine("¿Qué dato desea actualizar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellido");
                    Console.WriteLine("3. Numero documento");
                    Console.WriteLine("4. Edad");
                    Console.WriteLine("5. Posicion");
                    Console.WriteLine("6. Salario");
                    Console.WriteLine("7. Todos los datos");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            string nombre = Console.ReadLine();
                            empleado.SetNombre(nombre);
                            break;
                        case "2":
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            string apellido = Console.ReadLine();
                            empleado.SetApellido(apellido);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el nuevo Documento:");
                            string documento = Console.ReadLine();
                            empleado.SetNumeroDocumento(documento);
                            break;
                        case "4":
                            Console.WriteLine("Ingrese el nuevo edad:");
                            byte edad = Convert.ToByte(Console.ReadLine());
                            empleado.SetEdad(edad);
                            break;
                        case "5":
                            Console.WriteLine("Ingrese el nuevo posicion:");
                            empleado.Posicion = Console.ReadLine();
                            break;
                        case "6":
                            Console.WriteLine("Ingrese el nuevo salario:");
                            empleado.Salario = Convert.ToDouble(Console.ReadLine());
                            break;
                        case "7":
                            Console.WriteLine("Ingrese el nuevo nombre:");
                            string nombreTodos = Console.ReadLine();
                            empleado.SetNombre(nombreTodos);
                            Console.WriteLine("Ingrese el nuevo apellido:");
                            string apellidoTodos = Console.ReadLine();
                            empleado.SetApellido(apellidoTodos);
                            Console.WriteLine("Ingrese el nuevo numero documento:");
                            string documentoTodos = Console.ReadLine();
                            empleado.SetNumeroDocumento(documentoTodos);
                            Console.WriteLine("Ingrese el nuevo edad:");
                            byte edadTodos = Convert.ToByte(Console.ReadLine());
                            empleado.SetEdad(edadTodos);
                            Console.WriteLine("Ingrese el nuevo posicion:");
                            empleado.Posicion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo salario:");
                            empleado.Salario = Convert.ToDouble(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                Console.WriteLine($"{empleadosToUpdate.Count} Empleado(s) actualizado(s) exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }
    
        public void Delete()
        {
            Console.WriteLine("Ingrese el Numero de documento:");
            string? nombreBuscado = Console.ReadLine();
            var empleadoToUpdate = _empleados.Where(c => c.GetNombre() == nombreBuscado).ToList();

            if (empleadoToUpdate.Any())
            {
                Console.WriteLine("¿Desea eliminar el Coder? (S/N)");
                string? respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "S")
                {
                    _empleados.Remove(empleadoToUpdate.First());
                }
            }
        }

        public void DeleteCliente()
        {
            Console.WriteLine("Ingrese el Numero de documento:");
            string? nombreBuscado = Console.ReadLine();
            var clienteToUpdate = _clientes.Where(c => c.GetNombre() == nombreBuscado).ToList();

            if (clienteToUpdate.Any())
            {
                Console.WriteLine("¿Desea eliminar el Coder? (S/N)");
                string? respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "S")
                {
                    _clientes.Remove(clienteToUpdate.First());
                }
            }
        }
    
        //----------------------metodos adicionales--------------------
        //metodo buscar empleado por documento
        public void BuscarEmpleadoPorDocumento()
        {
            Console.WriteLine("Ingrese el numero de documento:");
            string numeroDocumento = Console.ReadLine();
            var respuesta = _empleados.FirstOrDefault(c => c.GetNumeroDocumento() == numeroDocumento);
            if (respuesta!= null)
            {
                respuesta.MostrarInformacion();
            }
        }

        //metodo mostrar empleado por posicicon 
        public void MostrarEmpleadosPorPosicion()
        {
            Console.WriteLine("Ingrese la posicion:");
            string posicion = Console.ReadLine();
            var respuesta = _empleados.Where(c => c.Posicion == posicion).ToList();
            if (respuesta.Any())
            {
                foreach (var empleado in respuesta)
                {
                    empleado.MostrarInformacion();
                }
            }
        }
    }
}