using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro2.model
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName {get; set;}
        protected string TypeDocument { get; set; }
        protected DateTime Birthdate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }


        public User(string name, string lastName, string typeDocument, DateTime birthdate, string email, string phoneNumber, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

          // get para la lectura de las propiedades protectec
        public Guid GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetTypeDocument()
        {
            return TypeDocument;
        }
        public DateTime GetBirthdate()
        {
            return Birthdate;
        }
        public string GetAddress()
        {
            return Address;
        }
        public string GetEmail()
        {
            return Email;
        } 
        public string GetPhonoNumber()
        {
            return PhoneNumber;
        }

        // set para los edit de las propiedades
        public void GetName(string name)
        {
            Name = name;
        }
        public void GetLastName( string lastName)
        {
            LastName = lastName;
        }
        public void GetEmail( string email)
        {
            Email = email;
        } 
        public void GetTPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        protected virtual void ShowDetails()
        {   
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Name} {LastName}");
            Console.WriteLine($"Tipo de Documento: {TypeDocument}");
            Console.WriteLine($"Edad: {CalculateAge()} años");
            Console.WriteLine($"Correo Electrónico: {Email}");
            Console.WriteLine($"Número de Teléfono: {PhoneNumber}");
            Console.WriteLine($"Dirección: {Address}");
        }        

        protected virtual int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthdate.Year;
            if (today.Month < Birthdate.Month || (today.Month == Birthdate.Month && today.Day < Birthdate.Day)) age--;
            return age;
        }

        // public void ShowAge()
        // {
            
        // }

        
    }
}