using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana3.models.polimorfismo
{
    public class Perro : Animal
    {
        public override void hablar()
        {
            base.hablar(); // SE EJECUTA PRIMERO LO QUE TINENE EL METODO POR DEFECTO 
            Console.WriteLine("Woof!");
        }
    }
}