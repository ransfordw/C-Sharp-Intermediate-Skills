using System;

namespace _29_Abstract_Classes_And_Members
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); throws error as abstract classes cannot be instantiated

            Shape circle2 = new Circle();
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();

            Console.ReadKey();
        }

    }
}
