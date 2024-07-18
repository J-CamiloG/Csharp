using System;
// using MiApp.classPersonalTecnico;
using MiApp.ClassJugador;
using MiApp.ClassTecnico;


namespace MiApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            
            //miramos que la herencia de PersonalTecnico este funcionando
            Jugador jugador = new Jugador(
                id: 1,
                nombre: "camilo",
                apellido: "Perez",
                fechaNacimiento: new DateTime(1992, 7, 15),
                documento: "12345678",
                tallaSuperior: "M",
                tallaInferior: "L",
                tallaCalzado: "42",
                posicion: "Delantero"
            );

            //miramos que la herencia de PersonalTecnico este funcionando
            Tecnico tecnico = new Tecnico(
                id: 55,
                nombre: "camil4545o",
                apellido: "Pergfsgez",
                fechaNacimiento: new DateTime(1997, 8, 16),
                documento: "1234567sdf8",
                tallaSuperior: "M",
                tallaInferior: "L",
                tallaCalzado: "42",
                nacionalidad: "Delantero"
            );

            //miramos que la herencia de PersonalTecnico este funcionando
            jugador.ImprimirDatos();
            tecnico.ImprimirDatos();
        }
    }
}
