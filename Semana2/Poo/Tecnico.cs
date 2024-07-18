using System;
using MiApp.classPersonalTecnico; // Asegúrate de que el espacio de nombres sea correcto y sin punto y coma

namespace MiApp.ClassTecnico
{
    public class Tecnico : PersonalTecnico
    {
        public string Nacionalidad { get; set; }

        public Tecnico(
            int id,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            string documento,
            string tallaSuperior,
            string tallaInferior,
            string tallaCalzado,
            string nacionalidad
        ) : base(id, nombre, apellido, fechaNacimiento, documento, tallaSuperior, tallaInferior, tallaCalzado)
        {
            Nacionalidad = nacionalidad;
        }

        //metodo para imprimir datos
        public override void ImprimirDatos()
        {
            base.ImprimirDatos(); //imprimimos los datos que traiga el metodo desde la clase base
            Console.WriteLine("Nacionalidad: " + Nacionalidad); // Agrega información específica del técnico
            Console.WriteLine("------------------------------------------");
        }
    }
}
