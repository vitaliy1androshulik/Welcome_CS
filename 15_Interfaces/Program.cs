namespace _15_Interfaces
{
    interface IWorker//public //починати з букви I - interface
    {
        //private string name;//error - not allowed
        bool IsWorking { get; set; }
        string Work();
        event EventHandler WorkEnded;
    }
    
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"Lastname :: {LastName}\nFirstName :: {FirstName}\nBirthday :: {Birthday.ToShortDateString()}";
        }
    }
    abstract class Employer : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString()+$"\nPosition :: {Position}\nSalary :: {Salary}$\n\n";
        }
    }
    interface IWorkable
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListOfWorkers { get; set; }//null
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employer, IManager//implement / realize
    {
        public List<IWorkable> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("Controling work.....");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I count money!!!");
        }
        public void Organize()
        {
            Console.WriteLine("Organaize work.....");
        }
    }

    class Seller : Employer, IWorkable
    {
        private bool isWorking = true;
        public bool IsWorking { get { return IsWorking; } }

        public string Work()
        {
            return "I sell product!!";
        }
    }
    class Cashier : Employer, IWorkable
    {
        private bool isWorking = true;
        public bool IsWorking { get { return IsWorking; } }

        public string Work()
        {
            return "Getting pay for product!!!";
        }
    }
    class Administrator : Employer, IWorkable, IManager
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get ; set; }

        public void Control()
        {
            Console.WriteLine("Ahahahhaha .... I`m Big Boss!!!!"); 
        }

        public void MakeBudget()
        {
            Console.WriteLine("I have a million)))");
        }

        public void Organize()
        {
            Console.WriteLine("You must listen to me");
        }

        public string Work()
        {
            return "I do my work((((";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           // Director director = new Director()
           IManager director = new Director()
            {
                FirstName = "Bob",
                LastName = "Thomson",
                Birthday = new DateTime(1995, 7, 10),
                Position = "Big Boss",
                Salary = 12000
            };
            Console.WriteLine(director);
            IWorkable seller = new Seller
            {
                FirstName = "Ivanka",
                LastName = "Petruk",
                Birthday = new DateTime(2002, 7, 10),
                Position = "Seller",
                Salary = 500
            };
            Console.WriteLine(seller);
            Console.WriteLine(seller.Work());
            //Console.WriteLine(seller.Salary);

            if(seller is Seller)
            {
                Console.WriteLine($"Seller salary{(seller as Seller).Salary}");
            }
            director.ListOfWorkers = new List<IWorkable>
            { 
                seller,
                new Cashier
                {
                    FirstName = "Olya",
                    LastName = "Petruk",
                    Birthday = new DateTime(1998, 10, 27),
                    Position = "Cashier",
                    Salary = 500
                },
                new Administrator
                {
                    FirstName = "Olya",
                    LastName = "Oliniuk",
                    Birthday = new DateTime(1998, 10, 27),
                    Position = "Administrator",
                    Salary = 1000
                },
            };
            Console.WriteLine("----------------------------");
            foreach(IWorkable item in director.ListOfWorkers)
            {
                if(item is Seller)
                {
                    Console.WriteLine("Seller");
                }
                if (item is Cashier)
                {
                    Console.WriteLine("Cashier");
                }
                Console.WriteLine(item);
                if (item.IsWorking)
                {
                    Console.WriteLine(item.Work());
                }
            }

            Administrator admin = new Administrator();//references - address

            IManager manager = admin;//address
            manager.Control();

            IWorkable worker = admin;
            worker.Work();
        }
    }
}