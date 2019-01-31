using System;

namespace Composition
{ 
    // Inheritance is more of a tightly coupled relationship.
    // Composition is loose coupling with more flexibility.


    // This Logger class is functioning simmilarly to a repository, except that is is a required parameter of the 'derived' classes constructors
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
