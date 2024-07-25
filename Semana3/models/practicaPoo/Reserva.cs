using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.practicaPoo
{
    public class Reserva {
        string HabitacionReservada {get; set;}
        string FechaInicio {get; set;}
        string FechaFin {get; set;}

        public Reserva(
            string habitacionReservada,
            string fechaInicio,
            string fechaFin
        )
        {
            HabitacionReservada = habitacionReservada;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
    }
}