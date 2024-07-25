using System;

namespace Semana3.models.practicaPoo
{
    public class Empresa
    {
        public List<Empleado> Empleados;

        public Empresa()
        {
            Empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado nuevaPersona)
        {
            Empleados.Add(nuevaPersona);
        }

        public void BuscarEmpleado(string nombre)
        {
            var busqueda = Empleados.Where(x => x.Nombre == nombre).ToList();

            foreach (var i in busqueda)
            {
                Console.WriteLine(i.Nombre);
            }
        }
    }
}