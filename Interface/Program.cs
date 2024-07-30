using System;
using Interface.model;

namespace MiApp
{
    class Program{
        static void Main(string[] args)
        {
            var productRepository = new CoderRepository();

            var newCoder = new Coder {Id = 1, Nombre = "Camilo", Apellido = "campillo", Email = "jc6381878@gamil.com", Telefono= "32442425"};
            var newCoder2 = new Coder {Id = 2, Nombre = "Santi", Apellido = "carmelo", Email = "jc@gamil.com", Telefono= "32fg425"};

            productRepository.Create(newCoder);
            productRepository.Create(newCoder2);

            productRepository.Read();
        }
    }
}