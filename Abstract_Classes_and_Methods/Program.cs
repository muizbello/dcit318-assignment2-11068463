using System;


namespace Abstract_Classes_and_Methods
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double GetArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Length { get; set; }

            public override double GetArea()
            {
                return Width * Length;
            }
        }

        static void Main(string[] args)
        {
            Circle Circle1 = new Circle();
            Circle1.Radius = 12;
            double circleArea = Circle1.GetArea();
            Console.WriteLine($"Area of circle with radius {Circle1.Radius} is {circleArea} ");

            Rectangle Rectangle1 = new Rectangle();
            Rectangle1.Width = 10;
            Rectangle1.Length = 12;
            double rectangleArea = Rectangle1.GetArea();
            Console.WriteLine($"Area of Rectangle with length {Rectangle1.Length} and width {Rectangle1.Width} is {rectangleArea}");
        }
    }
}
