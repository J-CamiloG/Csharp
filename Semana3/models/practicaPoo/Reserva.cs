using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.practicaPoo
{
    public class Reserva : Habitacion
    {
        string HabitacionReservada {get; set;}
        DateTime FechaReserva {get; set;}

        public Reserva(
            string habitacionReservada, 
            DateTime fechaReserva,
            string numeroHabitacion,
            string tipo
            ) : base (numeroHabitacion, tipo)
        {
            HabitacionReservada = habitacionReservada;
            FechaReserva = fechaReserva;
        }

        public void mostrarHabitacion()
        {
            Console.WriteLine($"habitacion Reservada : {HabitacionReservada}");
        }
    }
}