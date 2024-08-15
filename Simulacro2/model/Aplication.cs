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
                new Vehicle(1, "FGN 262", "Moto", "66" ,"5555", 2),
                new Vehicle(2, "FGN 260", "Carro", "55" ,"5555", 2), 
                new Vehicle(3, "FGN 261", "Moto", "32" ,"5555", 2),
                new Vehicle(4, "FGN 263", "Camioneta", "00" ,"5555", 2) 
            };
        }


        public void Read()
        {
            foreach (var driver in _drivers)
            {
                driver.DisplayDetails();
            }
        }
        public void ReadVehicles()
        {
            foreach (var vehicle in _vehicles)
            {
                vehicle.DisplayDetails();
            }
        }


        //eliminar vehiculos 
        public void Delete()
        {
            Console.WriteLine("Ingrese el id del vehiculo a eliminar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            _vehicles.RemoveAll(v => v.Id == id);
        }

        //Actualizar Driving Experience
        public void  UpdateLicenseCategory()
        {
            Console.WriteLine("Ingrese el id del conductor a actualizar: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var driver = _vehicles.FirstOrDefault(d => d.Id == id);
            if (driver!= null)
            {
                Console.WriteLine("Ingrese la nueva categoria de licencia: ");
                var newLicenseCategory = Console.ReadLine();
                driver.LicenseCategory = newLicenseCategory;
            }
        }

    }
}