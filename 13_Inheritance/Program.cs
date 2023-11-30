using System.Text;

namespace _13_Inheritance
{
    //private
    //public
    //protected
    //protected internal
    class Person // inherit from Object
    {
        protected string name;
        private readonly DateTime birthday;

        public Person()
        {
            name = "no name";
            birthday = new DateTime();
        }
        public Person(string name, DateTime birthday)
        {
            this.name = name;
            if(birthday > DateTime.Now) { this.birthday = new DateTime(); }
            else { this.birthday = birthday; }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name :: {name}\nBirthday :: {birthday.ToLongDateString()}");
        }
        public override string ToString() 
        {
            return $"Name :: {name}\nBirthday :: {birthday.ToLongDateString()}";
        }

        public virtual void Work()
        {
            Console.WriteLine("I don`t now");
        }
    }

    //class Name : baseclass, interface1, interface2, interface3
    class Worker : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set 
            { 
                this.salary = value>=0?value:0;
            }
        }
        public Worker() : base() { salary = 0; }
        public Worker(string n, DateTime b, decimal s):base(n,b) { Salary = s; }

        public override void Work()
        {
            Console.WriteLine("Doing some work......");
        }
        public override void Print()
        {
            base.Print(); // Person.Print()
            Console.WriteLine($"Salary :: {salary}");

        }
    }
    //final - sealed
    class Programmer : Worker
    {
        public int CodeLines { get; set; }
        public Programmer():base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, decimal s):base(n,b,s){ CodeLines = 0; }
        public sealed override void Work()
        {
            Console.WriteLine("Write lines in c#");
        }
        public override void Print()
        {
            base.Print(); // Person.Print()
            Console.WriteLine($"CodeLines :: {CodeLines}");

        }

        public void WriteLines()
        {
            CodeLines++;
        }
    }

    class TeamLead : Programmer
    {
        public int ProjectCount { get; set; }

        //public override void Work()
        //{
        //    Console.WriteLine("Manage team projects");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Worker worker = new Worker("Vitya", new DateTime(2007, 7, 12),7350);

            worker.Print();

            Person[] people = new Person[]//null
            {
                new Person(),
                worker,
                new Programmer("Bill", DateTime.Now, 7800)
            };

            foreach(var item in people)
            {
                Console.WriteLine("---------------------");
                item.Print();
                item.Work();
            }
            Programmer pr = null;
            //1 - use case (explicit)
            try
            {
            pr = (Programmer)people[0];
            pr.Print();

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            //2 - use as
            pr = people[2] as Programmer;
            if(pr==null)
            {
                Console.WriteLine("Incorrect type");
            }
            else
            {
                pr.Print();
            }
            //3 - use is with as
            if (people[2] is Programmer)
            {
                pr = people[2] as Programmer;
                pr.Print();
            }
            else
            {
                Console.WriteLine("Incorrect type!");
            }
        }
    }
}