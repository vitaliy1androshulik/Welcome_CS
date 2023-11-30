namespace _12_Indexes
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Model} - Price {Price}";
        }
    }

    class Shop
    {
        Laptop[] laptops; // reference - null

        public Shop(int size)
        {
            laptops = new Laptop[size];
        }
        public int Length { get { return laptops.Length; } }

        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            throw new IndexOutOfRangeException();
        }

        public void SetLaptop(int index, Laptop laptop)
        {
            laptops[index] = laptop;
        }
        public Laptop this[int index] // індексатор
        {
            get {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if(index >= 0 && (index <= laptops.Length))
                {
                    laptops[index] = value;
                }
            }
        }
        public Laptop this[string name] // індексатор
        {
            get
            {
                foreach (var item in laptops)//read only
                {
                    if(item.Model ==name)
                        return item;
                }
                return null;
            }
            private set
            {
                for (int i = 0; i < laptops.Length; i++) //read and rewrite 
                {
                    if (laptops[i].Model ==name)
                    {
                        laptops[i] = value;
                        break;
                    }
                }
            }
        }
        public int FindByPrice(double Price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == Price)
                {
                    return i; //4
                }
            }
            return -1;
        }

        public Laptop this[double Price]
        {
            get 
            {
                int index  = FindByPrice(Price);
                if(index >= 0&&index<=laptops.Length)
                    return laptops[index];
                throw new Exception("Incorrect price");
            }
            set
            {
                int index = FindByPrice(Price);
                if (index !=-1)
                {
                    laptops[index] = value;
                }
                    
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);

            //shop.SetLaptop(0, new Laptop() {Model = "hp", Price = 45758});
            //var laptop = shop.GetLaptop(0);
            //Console.WriteLine(laptop);
            shop[0] = new Laptop() { Model = "HP", Price = 45758 }; //value //set
            var laptop =shop[0];//get
            Console.WriteLine(laptop);
            shop[1] = new Laptop() { Model = "Asus", Price = 32000.10 }; //value //set
            shop[2] = new Laptop() { Model = "MSI", Price = 60000.10 }; //value //set
            Console.WriteLine("-------------------------------");
            try
            {

            for (int i = 0; i < shop.Length+1; i++)
            {
                Console.WriteLine(shop[i]);//get
            }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continued...");

            //shop["HP"] = new Laptop() { Model = "Mac", Price = 100000 }; //set
            Console.WriteLine(shop["Mac"]);//get
            Console.WriteLine(  );
            Console.WriteLine(  );
            try
            {

                for (int i = 0; i < shop.Length + 1; i++)
                {
                    Console.WriteLine(shop[i]);//get
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            shop[32000.10] = new Laptop() { Model = "Del", Price = 22139.99 };
            Console.WriteLine(shop[22139.99]);
            Console.WriteLine( );
            Console.WriteLine( );
            Console.WriteLine( );
            try
            {

                for (int i = 0; i < shop.Length + 1; i++)
                {
                    Console.WriteLine(shop[i]);//get
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}