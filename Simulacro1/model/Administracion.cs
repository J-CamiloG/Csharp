using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro1.model
{
    public static class Administracion
    {
        public static Empleado CrearEmpleado()
        {
            var nuevoEmpleado = Empleado.PedirInformacion();
            return nuevoEmpleado;
        }
        
        public static Cliente CrearCliente()
        {
            var nuevoCliente = Cliente.PedirInformacion();
            return nuevoCliente;
        }

        //  Métodos para mostrar interfaces visuales en la consola:
        // o MostrarTitulo(string titulo)
        

        // o MostrarPie(string pie)
        // o MostrarSeparador()

    }
}