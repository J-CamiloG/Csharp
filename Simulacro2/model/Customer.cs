using System;

namespace Simulacro2.model
{
    public class Customer : User
    {
        public string MembreshipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        public Customer(
            string membreshipLevel,
            string preferredPaymentMethod,
            string name,
            string lastName,
            string typeDocument,
            DateTime birthdate,
            string email,
            string phoneNumber,
            string address) : base(name, lastName, typeDocument, birthdate, email, phoneNumber, address)
        {
            MembreshipLevel = membreshipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }
    }
}
