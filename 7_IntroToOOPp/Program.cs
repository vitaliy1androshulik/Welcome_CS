namespace _7_IntroToOOPp
{
    /*
     * Access Spetificators
     -private
     -public
     -protected
     -internal
     -protectal internal
     */
    public class MyClass //: Object
    {
        //class body
        protected internal int number;
        private string name;
        private const float PI = 3.14f;
        private readonly int id = 10;

        public void Print() // private
        {
            Console.WriteLine($"Id :: {id}. Name :: {name}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    struct Point
    {
        public int x, y;
        public void Print()
        {
            Console.WriteLine($"x {x}, y {y}");
        }
    }
    partial class Point
    {
        private int x;
        private int y;
        //private string Name;
        //public string name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property - prop + Tab
        //public Point(int value):this(value,value)
        //{
        //    //x = value;
        //    //y = value;
        //}
        public Point(int X, int Y)
        {
            X = x;
            //SetX(x)
            SetY(y);
        }
        public string Name { get; set; }
        public string Type { get;  }//readonly property

        public string Color { get; private set; } = "green";

        //full property
        private string address;
        public string Address2 { get { return address; } set { address = value; } }
        //Properties
        public int X
        {
            get
            {
                return x;
            }
            set //value
            {
                if(value>=0)
                {
                    x = value;
                }
                else
                {
                    x = 0;
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set //value
            {
                if (value >= 0)
                {
                    y = value;
                }
                else
                {
                    y = 0;
                }
            }
        }
        public Point(int x, int y)
        {
            SetX(x);
            SetY(y);

        }
        
        public void SetX(int NewX)
        {
            if (NewX >= 0)
            {
                this.x = NewX;
            }
            else { this.x = 0; }
        }
        public void SetY(int NewY)
        {
            if (NewY >= 0)
            {
                this.y = NewY;
            }
            else { this.y = 0; }
        }
        public int GetX()
        {
            return x;

        }
        public int GetY()
        {
            return y;
        }
        public void Print() 
        {
            Console.WriteLine($"Name :: {Name}, X :: {x}, Y :: {y}");
        }
        public override string ToString()
        {
            return $"Name :: {Name}, X :: {x}, Y :: {y}";
        }
    }
    class MyClass1
    {
        //class body
        private int number;
    }
    class DerivedClass : MyClass//public
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Point point = new Point(4,-7);
            point.Print();
            Console.WriteLine(point);  
            
            point.SetX(4);
            point.Print();

            Console.WriteLine(point.GetX());
            Console.WriteLine(point.GetY());

            point.X = 4;//setter

            Console.WriteLine(point.X);//getter
            point.Print();

            point.Name = "Test";//value - setter
            Console.WriteLine(point.Name);
            point.Print();








            //DerivedClass derived = new DerivedClass();

            //object obj = null;
            // myclass = new MyClass ();

            //MyClass @class = new MyClass();

            //myclass.Print();
            //Console.WriteLine(myclass.ToString());

            //myclass.GetType();
        }
    }
}