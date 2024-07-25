using System;

namespace Semana3.models.practicaPoo
{
    public class Empleado
    {
        public string Nombre;
        public string Cargo;
        public decimal Salario;

        public Empleado(
            string nombre,
            string cargo,
            decimal salario
        )
        {
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
        }
    }
}