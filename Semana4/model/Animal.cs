using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.model
{
    public abstract class Animal
    {
        public int Id { get; set; } 
        public abstract string Nombre {get; set;} //propiedades abstract, debe igual darse valor en quien la consume
        public string Especie { get; set; } 

        public Animal(int id, string nombre, string especie)
        {
            Id = id;
            Nombre = nombre;
            Especie = especie;
        }

        public abstract void Saludar();
    }
}