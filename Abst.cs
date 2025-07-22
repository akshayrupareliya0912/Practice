/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akshay
{
    internal class Abst
    {
        abstract class Shape
        {
            public abstract double Getarea();

            public void Display()
            {
                Console.WriteLine("Shape Details.");
            }
        }

        class Circle : Shape
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override double Getarea()
            {
                return Math.PI * radius * radius;
            }
        }
        class Rectangle : Shape
        {
            private double width;
            private double height;
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            // Implementing the abstract method
            public override double Getarea()
            {
                return width * height;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Shape circle = new Circle(5);
                Shape rectangle = new Rectangle(4, 6);
                // Using the abstract class methods
                circle.Display();
                Console.WriteLine("Circle Area: " + circle.Getarea());
                rectangle.Display();
                Console.WriteLine("Rectangle Area: " + rectangle.Getarea());

            }
        }
    }
}*/