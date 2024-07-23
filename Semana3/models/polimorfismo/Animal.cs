using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.polimorfismo
{
    public class Animal
    {
        public Guid Id {get; set;}
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Especie { get; set; }

        public Animal(Guid id, string nombre, string genero, int especie)
        {
            this.Id = id;
            Nombre = nombre;
            Genero = genero;
            Especie = especie;
        }


        public virtual void hablar ()
        {
            Console.WriteLine("El animal habla");
        }

        public virtual void deplazarse()
        {
            Console.WriteLine($"El animal se mueve");
        }
    }
}