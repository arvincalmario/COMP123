using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_homework06_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //although Shape is an abstract is can be used as a reference type
            //any child class of Shape is also a Shape
            double length = 2;
            double width = 3;
            List<Shape> shapes = new List<Shape>
            {
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Triangle($"triangle – bas:{length}, hei:{width}", length, width),
                //doubling width and length
                new Triangle($"triangle – bas:{length *= 2}, hei:{width *= 2}", length, width),
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Ellipse($"ellipse – min:{length}, maj:{width}", length, width),
                new Diamond($"diamond – min:{length}, maj:{width}", length, width)
            };
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);

        }
        abstract class Shape
        {
            private string Name { get; }
            protected abstract double Area { get; }
            public Shape (string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return $"{Name} Area: {Area:F2}";
            }
        }
        class Square : Shape
        {
            protected double Length { get; }
            protected override double Area { get { return Math.Pow(Length,2); }   }
            public Square (string name, double length) : base(name)
            {
                Length = length;
            }
        }
        class Circle : Square
        {
            protected override double Area { get { return Math.PI * Length * Length; } }
            public Circle (string name, double length) : base(name, length)
            {
               
            }
        }
        class Rectangle : Shape
        {
            protected double Width { get; }
            protected double Length { get; }
            protected override double Area { get { return Width * Length; } }
            public Rectangle (string name, double length, double width) : base(name)
            {
                Width = width;
                Length = length;

            }
        }
        class Ellipse : Rectangle
        {
            protected override double Area { get { return Math.PI * Width * Length; } }
            public Ellipse (string name, double length, double width) : base(name, length, width)
            {

            }
        }
        class Triangle : Rectangle
        {
            protected override double Area { get { return 0.5 * Width * Length; } }
            public Triangle (string name, double length, double width) : base(name, length, width)
            {

            }
        }
        class Diamond : Rectangle
        {
            protected override double Area { get { return Width * Length; } }
            public Diamond (string name, double length, double width) : base(name, length, width)
            {

            }
        }
    }
}
