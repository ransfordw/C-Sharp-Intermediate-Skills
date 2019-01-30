using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
//Encapsulation: Objects should hide their implementation detail and reveal what they can do instead of revealing how they do what tey are supposed to do.
//Fields should be private, leading with an underscore, and should be camelCased.