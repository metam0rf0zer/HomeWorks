namespace Фигуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(5, 3)
        };

            foreach (var shape in shapes)
            {
                shape.Print();
                shape.PrintTypeInfo();
                Console.WriteLine("---------------------");
            }
        }

        public abstract class Shape
        {
            public abstract double Area { get; }
            public virtual string Type { get; }

            public abstract void Print();
            public void PrintTypeInfo()
            {
                Console.WriteLine($"Тип:{Type}");
            }
        }

        public class Circle : Shape
        {
            public Circle(double radius)
            {
                Radius = radius;
                Area = radius * radius * Math.PI;
                Type = "Круг";
            }

            public double Radius { get; }
            public override double Area { get; }


            public override void Print()
            {
                Console.WriteLine($"Радиус:{Radius}\nПлощадь:{Area}");
            }
        }
        public class Rectangle : Shape
        {
            public Rectangle(double width, double height)
            {
                Area = width * height;
                Type = "Прямоугольник";
                Width = width;
                Height = height;

            }

            public double Width { get; }
            public double Height { get; }
            public override double Area { get; }


            public override void Print()
            {
                Console.WriteLine($"Ширина:{Width},Высота{Height}\nПлощадь:{Area}");
            }


        }
        public class Triangle : Shape
        {
            public Triangle(double baze, double height)
            {
                Type = "Треугольник";
                Area = baze * height * 0.5;
                Base = baze;
                Height = height;


            }

            public double Base { get; }
            public double Height { get; }
            public override double Area { get; }


            public override void Print()
            {
                Console.WriteLine($"Ширина:{Base},Высота{Height}\nПлощадь:{Area}");
            }


        }

    }
}