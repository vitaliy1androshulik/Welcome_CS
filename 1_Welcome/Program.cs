using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            Console.WriteLine("Hello world"); // cout

            string str = Console.ReadLine();
            Console.WriteLine(str);   //cin

            int number =int.Parse(str);
            Console.WriteLine(number+55+"!");
            Console.WriteLine((number+55));
            Console.WriteLine($"Your suma = {number+55}");


            //int* ptr = nullptr;
            //int a = 0;//not nul

            Nullable<int> b= null;  
            string name = null;//int* ptr = nullptr;
            string Ivanenko = "Ivanenko";


            //Console.OutputEncoding = Encoding.UTF8;
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine($"ShortTimeString :: {now.ToShortTimeString()}");
            Console.WriteLine($"ShortDateString :: {now.ToShortDateString()}");
            Console.WriteLine($"LongTimeString :: {now.ToLongTimeString()}");
            Console.WriteLine($"LongDateString :: {now.ToLongDateString()}");
            Console.WriteLine($"ShortTimeString :: {now.ToShortTimeString()}");

            int c = 5;
            //explicit
            int v = (int)3.14;
            bool myBool = true;
            short myShort = 6;
            //implicit
            int myInt = myShort;


            double Number = 42;
            number = Convert.ToInt32(v);
            Console.Write(number);

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());//0...max
                Console.WriteLine(random.Next(100));//0-100
                Console.WriteLine(random.Next(100,500));//100-500
                Console.WriteLine(random.NextDouble());//0.1
            }
            if(3>8)
            {
                Console.WriteLine(">");
            }
            else { Console.WriteLine("<");}
           // Console.BackgroundColor = ConsoleColor.Green;
           Console.BackgroundColor = ConsoleColor.Yellow;
        }
    }
}
