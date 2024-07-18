using System;
using MiApp.classPersonalTecnico;

namespace MiApp.ClassJugador
{
    public class Jugador : PersonalTecnico
    {
        public string Posicion { get; set; }

        public Jugador(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string documento,
            string tallaSuperior,
            string tallaInferior,
            string tallaCalzado,
            string posicion
        ) : base(id, nombre, apellido, fechaNacimiento, documento, tallaSuperior, tallaInferior, tallaCalzado)
        {
            Posicion = posicion;
        }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos(); 
            Console.WriteLine("Posición: " + Posicion); 
            Console.WriteLine("------------------------------------------");
        }
    }
}
