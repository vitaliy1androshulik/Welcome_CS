namespace OverloadOperHomeWork
{
    class Square
    {
        public int Length { get; set; }
        public Square() : this(0) { }
        public Square(int a)
        {
            Length = a;
        }
        public override string ToString()
        {
            return $"Length : {Length}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   Length == square.Length;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Length);
        }

        public static Square operator ++(Square s)
        {
            s.Length++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.Length--;
            return s;
        }
        public static Square operator +(Square s, Square r)
        {
            Square sw = new Square()
            {
                Length = s.Length + r.Length
            };
            return sw;
        }
        public static Square operator -(Square s, Square r)
        {
            Square sw= new Square()
            {
                Length = s.Length - r.Length
            };
            return sw;
        }
        public static Square operator *(Square s, Square r)
        {
            Square sw = new Square()
            {
                Length = (s.Length * r.Length)
            };
            return sw;
        }
        public static Square operator /(Square s, Square r)
        {
            Square sw = new Square()
            {
                Length = (s.Length / r.Length)
            };
            return sw;
        }
        public static bool operator ==(Square s, Square r)
        {
            return s.Length == r.Length;
        }
        public static bool operator !=(Square s, Square r)
        {
            return s.Length != r.Length;
        }
        public static bool operator <(Square s, Square p2)
        {
            return s.Length < p2.Length;
        }
        public static bool operator > (Square s, Square r)
        {
            return !(s < r);
        }
        public static bool operator <=(Square s, Square r)
        {
            return s.Length <= r.Length;
        }
        public static bool operator >=(Square s, Square r)
        {
            return !(s <= r);
        }
        public static bool operator false(Square s)
        {
            return (s.Length == 0);
        }
        public static bool operator true(Square s)
        {
            return (s.Length != 0);
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Length, s.Length+10);
        }
        public static implicit operator int(Square s)
        {

            return s.Length;
        }

    }





    class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle() : this(0, 0) { }
        public Rectangle(int a, int b)
        {
            Height = a;
            Width = b;
        }

        public override string ToString()
        {
            return $"Height : {Height}, Width {Width}";
        }

        public static Rectangle operator ++(Rectangle p)
        {
            p.Height++;
            p.Width++;
            return p;
        }
        public static Rectangle operator --(Rectangle p)
        {
            p.Height--;
            p.Width--;
            return p;
        }

        public static Rectangle operator +(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle()
            {
                Height = p1.Height + p2.Height,
                Width = p1.Width + p2.Width
            };
            return p3;
        }
        public static Rectangle operator -(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle()
            {
                Height = p1.Height - p2.Height,
                Width = p1.Width - p2.Width
            };
            return p3;
        }
        public static Rectangle operator *(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle()
            {
                Height = (p1.Height * p2.Height),
                Width = (p1.Width * p2.Width)
            };
            return p3;
        }
        public static Rectangle operator /(Rectangle p1, Rectangle p2)
        {
            Rectangle p3 = new Rectangle()
            {
                Height = (p1.Height / p2.Height),
                Width = (p1.Width / p2.Width)
            };
            return p3;
        }

        public static bool operator ==(Rectangle p1, Rectangle p2)
        {
            return p1.Height == p2.Height && p1.Width == p2.Width;
        }
        public static bool operator !=(Rectangle p1, Rectangle p2)
        {
            return p1.Height != p2.Height && p1.Width != p2.Width;
        }
        public static bool operator <(Rectangle p1, Rectangle p2)
        {
            return p1.Height + p1.Width < p2.Height + p2.Width;
        }
        public static bool operator >(Rectangle p1, Rectangle p2)
        {
            return !(p1 < p2);
        }
        public static bool operator <=(Rectangle p1, Rectangle p2)
        {
            return p1.Height + p1.Width <= p2.Height + p2.Width;
        }
        public static bool operator >=(Rectangle p1, Rectangle p2)
        {
            return !(p1 <= p2);
        }

        public static explicit operator Square(Rectangle p1)
        {
            return new Square(p1.Height);
        }
        public static explicit operator int(Rectangle p1)
        {

            return p1.Width+p1.Height;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Square sqr1 = new Square(12);
            Square sqr2 = new Square(5);

            Rectangle rect1 = new Rectangle(4,2);
            Rectangle rect2 = new Rectangle(6,5);

            Console.WriteLine($"Square operator + {sqr1 + sqr2}");
            Console.WriteLine($"Square operator - {sqr1 - sqr2}");
            Console.WriteLine($"Square operator * {sqr1 * sqr2}");
            Console.WriteLine($"Square operator / {sqr1 / sqr2}");

            Console.WriteLine($"Square operator ++ {sqr1++}");
            Console.WriteLine($"Square operator -- {sqr1--}");

            Console.WriteLine($"Square operator -- {sqr1--}");

            if(sqr1 != sqr2) 
            {
                Console.WriteLine("Sqr1 != sqr2");
            }
            else
            {
                Console.WriteLine("Sqr1 == sqr2");
            }

            if (sqr1 > sqr2)
            {
                Console.WriteLine("Sqr1 > sqr2");
            }
            else
            {
                Console.WriteLine("Sqr1 < sqr2");
            }

            if (sqr1 <= sqr2)
            {
                Console.WriteLine("Sqr1 <= sqr2");
            }
            else
            {
                Console.WriteLine("Sqr1 >= sqr2");
            }

            rect1 = sqr1;
            Console.WriteLine(rect1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Rectangle operator + {rect1 + rect2}");
            Console.WriteLine($"Rectangle operator - {rect1 - rect2}");
            Console.WriteLine($"Rectangle operator * {rect1 * rect2}");
            Console.WriteLine($"Rectangle operator / {rect1 / rect2}");

            Console.WriteLine($"Rectangle operator ++ {rect1++}");
            Console.WriteLine($"Rectangle operator -- {rect1--}");

            Console.WriteLine($"Rectangle operator -- {rect1--}");

            if (rect1 != rect2)
            {
                Console.WriteLine("Rect1 != rect2");
            }
            else
            {
                Console.WriteLine("Rect1 == rect2");
            }

            if (rect1 > rect2)
            {
                Console.WriteLine("Rect > rect2");
            }
            else
            {
                Console.WriteLine("Rect1 < rect2");
            }

            if (rect1 <= rect2)
            {
                Console.WriteLine("Rect1 <= rect2");
            }
            else
            {
                Console.WriteLine("Rect1 >= rect2");
            }


            sqr1 = (Square)rect1;
            Console.WriteLine(""+sqr1);
        }
    }
}