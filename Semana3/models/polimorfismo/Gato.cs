using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.polimorfismo
{
    public class Gato : Animal
    {

        public double TamañoVigotes {get; set;}
        public bool Orejas {get; set;}
        
        public Gato(string nombre, string genero, int especie, double tamañoVigotes, bool orejas) : base(nombre, genero, especie)
        {
            TamañoVigotes = tamañoVigotes;
            Orejas = orejas;
        } 

        public void presentar()
        {
            Console.WriteLine("soy un gato y me presento");
        }
        public override void hablar()
        {
            //ACA NO UTILIZAMOS BASE PORQUE NO QUEREMOS QUE EL METODO DE ANIMAL SE EJECUTE
            Console.WriteLine("Miau");
        }

        public override void deplazarse()
        {
            Console.WriteLine("me muevo soy el gato");
        }
    }
}