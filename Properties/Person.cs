using System;

namespace Properties
{
    public class Person
    {
        //This private acessor makes it so that the Birthdate cannot be set outside of this class. So we need to set it in the constructor here.
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var _age = timeSpan.Days / 365;
                return _age;
            }
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }
}
