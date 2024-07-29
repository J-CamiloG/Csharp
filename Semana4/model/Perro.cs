using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.model
{
    public class Perro : Animal
    {   
        //propiedades de mi padre obstractas
        public override string Nombre {get; set;}
        public bool EsCriollo { get; set; } 

        public Perro(int id, string nombre, string especie,bool esCriollo) : base (id,nombre, especie)
        {
            EsCriollo = esCriollo;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public override void Saludar()
        {
            Console.WriteLine($"Guau guau! Soy {Especie} y mi nombre es {Nombre}");
        }
    }
}