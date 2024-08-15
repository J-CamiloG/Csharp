using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro2.model;

namespace Simulacro2.model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public string? LicenseCategory { get; internal set; }

        // public Driver Owner {get; set;}

        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;    
        }

        public void DisplayDetails()
        {   
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Número de motor: {EngineNumber}");
            Console.WriteLine($"Número de serie: {SerialNumber}");
            Console.WriteLine($"Capacidad de personas: {PeopleCapacity}");
            // Console.WriteLine($"Dueño: {Owner.Name}"); 
        }

    }
}