using System;

namespace Semana3.models.practicaPoo
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        

        public Carro(Guid id, string marca, string modelo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
        }

        public void arrancar()
        {
            Console.WriteLine($"El carro de marca {Marca} modelo {Modelo} se ha arrancado");
        }
        public void acelerar()
        {
            Console.WriteLine($"El carro de marca {Marca} modelo {Modelo} se ha acelerado");
        }
    }
}