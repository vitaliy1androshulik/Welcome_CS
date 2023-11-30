using System.Data;

namespace _9_HomwWorkNamepsaceException
{

    class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0)
                    throw new ArgumentException("Error age. Age must be > 0");
                age = value;
            }
        }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (salary < 0)
                    throw new ArgumentException("Error salary. Salary must be > 0");
                salary = value;
            }
        }

        private DateTime datetime;

        public DateTime Datetime
        {
            get { return datetime; }
            set
            {
                if (datetime > DateTime.Now)
                    throw new ArgumentException("Error date. DateTime must be > date now");
                datetime = value;
            }
        }

        private int experience;

        public int Experience
        {
            get { return experience; }
            set 
            {
                if(value > (DateTime.Now.Year - datetime.Year)||value>age)
                {
                    throw new ArgumentException("Error. Wrong experience");
                }
                else
                {
                    experience = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name :: {name}\nSurname :: {surname}\nLast name :: {lastname}\n" +
                $"Age :: {age}\nSalary :: {salary}\nExperience :: {Experience}";
        }

        public void Print()
        {
            Console.WriteLine("------------Worker------------");
            Console.WriteLine($"Name :: {name}");
            Console.WriteLine($"Surname :: {surname}");
            Console.WriteLine($"Lastname :: {lastname}");
            Console.WriteLine($"Age :: {Age}");
            Console.WriteLine($"Salary :: {Salary}");
            Console.WriteLine($"Date of employment  :: {Datetime}");
            Console.WriteLine($"Experience  :: {Experience}");
        }
    }

    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public void Div(int a, int b)
        {
            if(b==0)
            {
                throw new ArgumentException ("Error. Division by zero");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            //try
            //{
            //    Worker[] worker = new Worker[2];
            //    for (int i = 0; i < worker.Length; i++)
            //    {
            //        Console.WriteLine($"----------------Worker{i + 1}--------------");
            //        worker[i] = new Worker();
            //        Console.Write("Enter worker name :: ");
            //        worker[i].name = Console.ReadLine();
            //        Console.Write("Enter worker surname :: ");
            //        worker[i].surname = Console.ReadLine();
            //        Console.Write("Enter worker lastname :: ");
            //        worker[i].lastname = Console.ReadLine();
            //        Console.Write("Enter worker age :: ");
            //        worker[i].Age = int.Parse(Console.ReadLine());
            //        Console.Write("Enter worker date of employment :: ");
            //        worker[i].Datetime = DateTime.Parse(Console.ReadLine());
            //        Console.Write("Enter worker experience :: ");
            //        worker[i].Experience = int.Parse(Console.ReadLine());
            //        Console.Write("Enter worker salary :: ");
            //        worker[i].Salary = int.Parse(Console.ReadLine());

            //    }
            //    worker[1].Print();
            //    Console.WriteLine();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //N2
            try
            {
                Calculator calculator = new Calculator();
                calculator.Add(10, 20);
                calculator.Sub(10, 20);
                calculator.Mul(10, 20);
                calculator.Div(10, 1);
                calculator.Div(10, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }


        }
    }
}