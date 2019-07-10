using System;

namespace _23_Constructors_And_Inheritance
{
    partial class Program
    {
        public class Vehicle
        {
            public Vehicle()
            {
                Console.WriteLine("Vehicle is being inititalized.");
            }

            public Vehicle(string registrationNumber)
            {
                RegistrationNumber = registrationNumber;
                Console.WriteLine("Vehicle is being inititalized. {0}",registrationNumber);
            }

            public string RegistrationNumber { get; }
        }
    }
}
