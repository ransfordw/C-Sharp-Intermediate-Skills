using System;

namespace Properties
{
    public class Person
    {
        //This private acessor makes it so that the Birthdate cannot be set outside of this class. So we need to set it in the constructor here.

        //Store auto generated properties on the top
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }

        //Have constructors in the middle as a vertical separator.
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //Store calculated properties on the bottom
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var _age = timeSpan.Days / 365;
                return _age;
            }
        }
    }
}
