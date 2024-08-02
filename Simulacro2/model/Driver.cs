using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro2.model
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }

        public Driver(
            string licenseNumber, 
            string licenseCategory, 
            string drivingExperience, 
            string name, 
            string lastName, 
            string typeDocument, 
            DateTime birthdate, 
            string email, 
            string phoneNumber, 
            string address) : base ( name, lastName, typeDocument, birthdate,email,phoneNumber,address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = Convert.ToInt32(drivingExperience);
        }

        
        
        protected override void ShowDetails()
        {   
            base.ShowDetails();
            Console.WriteLine($"License Number: {LicenseNumber}");
            Console.WriteLine($"License Category: {LicenseCategory}");
            Console.WriteLine($"Driving Experience: {DrivingExperience} years");
        }  

        public void DisplayDetails()
        {
            ShowDetails();
        }
        public void  AddExperience(int years)
        {
            DrivingExperience += years;
            Console.WriteLine($"Driver {Name} {LastName} has gained {years} years of driving experience.");
        }

        public void UpdateLicenseCategory(string newCategory)
        {
            Console.WriteLine($"Driver {Name} {LastName} has been updated with a new license category of {LicenseCategory}.");
        }
    }
}