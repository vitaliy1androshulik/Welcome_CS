using Microsoft.VisualBasic;
using System.Drawing;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace _14_InheritanceHomeWork
{
    abstract class GeomFigyre
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Triangle : GeomFigyre
    {
        public Triangle() : this(0, 0, 0) { }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public override double GetArea()
        {
            double area = new int();
            double center = new int();
            center = ((GetPerimeter() - a) *(GetPerimeter() - b) * (GetPerimeter() - c));
            area = Math.Sqrt(center);
            return area;
        }
        public override double GetPerimeter()
        {
            return a+b+c;
        }
        public override string ToString()
        {
            return $"Triangle perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Square : GeomFigyre
    {
        public Square() : this(0) { }
        public Square(int a)
        {
            this.a = a;
        }
        public int a { get; set; }
        public override double GetArea()
        {
            return a*a;
        }
        public override double GetPerimeter()
        {
            return a+a+a+a;
        }
        public override string ToString()
        {
            return $"Square perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Diamond : GeomFigyre
    {
        public int a { get; set; }
        public int d1 { get; set; }
        public int d2 { get; set; }
        public Diamond() : this(0,0,0) { }
        public Diamond(int a, int d1, int d2)
        {
            this.a = a;
            this.d1 = d1;
            this.d2 = d2;
        }
        public override double GetArea()
        {
            return (d1*d2*0.5);
        }
        public override double GetPerimeter()
        {
            return a+a+a+a;
        }
        public override string ToString()
        {
            return $"Diamond perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Rectangle : GeomFigyre
    {
        public Rectangle() : this(0,0) { }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int a { get; set; }
        public int b { get; set; }
        public override double GetArea()
        {
            return a * b;
        }
        public override double GetPerimeter()
        {
            return a + b+a+b;
        }
        public override string ToString()
        {
            return $"Rectangle perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Parallelogram : GeomFigyre
    {
        public Parallelogram() : this(0, 0, 0) { }
        public Parallelogram(int a, int b, int ha)
        {
            this.a = a;
            this.b = b;
            this.ha = ha;
        }
        public int a { get; set; }
        public int b { get; set; }
        public int ha { get; set; }
        public override double GetArea()
        {
            return a * ha;
        }
        public override double GetPerimeter()
        {
            return 2*(a+b);
        }
        public override string ToString()
        {
            return $"Parallelogram perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class  Trapeze: GeomFigyre
    {
        public Trapeze() : this(0, 0, 0, 0,0) { }
        public Trapeze(int a, int b, int c, int d, int h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public int h { get; set; }
        public override double GetArea()
        {
            return 0.5*(a+b)*h;
        }
        public override double GetPerimeter()
        {
            return a+b+c+d;
        }
        public override string ToString()
        {
            return $"Trapeze perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Circle : GeomFigyre
    {
        public Circle() : this(0) { }
        public Circle(int r)
        {
            this.r = r;
        }
        public const double P = 3.14;
        public int r { get; set; }
        public override double GetArea()
        {
            return P*r*r;
        }
        public override double GetPerimeter()
        {
            return 2*P*r;
        }
        public override string ToString()
        {
            return $"Circle perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }
    class Ellipse : GeomFigyre
    {
        public Ellipse() : this(0,0) { }
        public Ellipse(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public const double P = 3.14;
        public int a { get; set; }
        public int b { get; set; }
        public override double GetArea()
        {
            return P * a * b;
        }
        public override double GetPerimeter()
        {
            return 4*(((P*a*b)+(a-b)*(a-b))/a+b);
        }
        public override string ToString()
        {
            return $"Ellipse perimeter :: {GetPerimeter()}, area :: {GetArea()}";
        }
    }


    class CompositeFigure
    {
        private GeomFigyre[] geom;
        public CompositeFigure(params GeomFigyre[] geom)
        {
            this.geom = geom;
        }

        public void PrintArea()
        {
            foreach (var ge in geom) 
            {
                Console.WriteLine("Area :: "+ge.GetArea());
            }
        }
        public void PrintPerimeter()
        {
            foreach (var ge in geom)
            {
                Console.WriteLine("Perimeter :: "+ge.GetPerimeter());
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2,2,2) ;
            Square square = new Square(2) ;
            Diamond diamond = new Diamond(3,3,3) ;
            Rectangle rectangle = new Rectangle(3,2) ;
            Parallelogram param = new Parallelogram(3,2,2) ;
            Trapeze trapeze = new Trapeze(3, 2, 2, 3, 3); 
            Circle circle = new Circle(3); 
            Ellipse ellipse = new Ellipse(3, 4); 
            Console.WriteLine(triangle);
            Console.WriteLine(square);
            Console.WriteLine(diamond);
            Console.WriteLine(rectangle);
            Console.WriteLine(param);
            Console.WriteLine(trapeze);
            Console.WriteLine(circle);
            Console.WriteLine(ellipse);

            Console.WriteLine();
            Console.WriteLine();

            CompositeFigure fig = new CompositeFigure(triangle, square, rectangle, diamond, param);
            fig.PrintPerimeter();
            fig.PrintArea();
        }
    }
}