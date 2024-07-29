using System;

namespace Semana4.model
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro miObjetoPerro = new Perro(26,"perro nuevo", "labrador full",true);
            miObjetoPerro.Saludar();
        }
    }
}