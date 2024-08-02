using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro2.interfaceCrud;

namespace Simulacro2.model
{
    public class Aplication : ICrudSystem
    {
        private readonly List<Driver> _drivers;
        private readonly List<Vehicle> _vehicles;

        public Aplication()
        {
            _drivers = new List<Driver>
            {
                new Driver("14656", "A2", "1", "Juan", "Camilo", "123456789", new DateTime(1990, 5, 23), "jcjifj@gamail.com", "32456838", "Calle # 34B -324"),
                new Driver("23456", "B1", "2", "Carlos", "Rodriguez", "987654321", new DateTime(1985, 11, 12), "carlos.rod@example.com", "56789012", "Avenida # 45A -123")
            };

            _vehicles = new List<Vehicle>
            {
                new Vehicle(1, "FGN 262", "Moto", "66" ,"5555", 2) 
            };
        }


        public void Read()
        {
            foreach (var driver in _drivers)
            {
                driver.DisplayDetails();
            }
        }
        


    }
}