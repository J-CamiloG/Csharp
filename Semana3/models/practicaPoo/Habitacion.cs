using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.practicaPoo
{
    public class Habitacion
    {
        public string NumeroHabitacion {get; set;}
        public string Tipo { get; set; }

        public Habitacion(string numeroHabitacion, string tipo)
        {
            NumeroHabitacion = numeroHabitacion;
            Tipo = tipo;
        }
    }
}