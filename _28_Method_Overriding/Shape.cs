using System;

namespace _28_Method_Overriding
{
    public class Shape
    {
        public Shape()
        {
            ShapeName = "Shape";
        }

        public string ShapeName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Base Draw method that cannot be overidden but implements child's properties
        /// </summary>
        public void DrawFromProperty()
        {
            Console.WriteLine($"Draw a {ShapeName}.");
        }

        /// <summary>
        /// Base virtual method that can be overidden in children
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine("Draw a Shape.");
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
            //Uncomment to implement the base Draw class using this property, otherwise the program prints shape
            //ShapeName = "Circle";
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }

        public void SetOrbit() { }
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeName = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public Triangle()
        {
            ShapeName = "Triangle";
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle.");
        }
    }

}
