namespace _22_EventsHomeWork
{
    public delegate void StockExchangeTrading(double DollarRate);
    class Trader
    {
        private double money;
        public double Money
        {
            get { return money; }
            set
            {
                if (value > 0)
                    money = value;
            }
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public void BuyCurrency(double DollarRate)
        {
            double purchaseAmount = 100;
            if (DollarRate > Buy)
            {
                Money = -purchaseAmount;
                double info = purchaseAmount / DollarRate;
                Console.WriteLine($"{Name} {LastName}, Buys a dollar on the exchange for the amount :: {info} $");
            }
            else if (DollarRate >= Sell)
            {
                Console.WriteLine($"{Name} {LastName}, Sells his shares and records the profit");
            }
            else if (DollarRate < Buy)
            {
                Console.WriteLine($"{Name} {LastName}, Does not buy currency on the exchange");
            }
        }
    }
    class StockExchange
    {
        public event StockExchangeTrading stockExchangeTrading;
        public static double CourseGenerator()
        {
            return Random.Shared.Next(-100, 100);
        }
        public void Create()
        {
            double DollarRate = CourseGenerator();
            Console.WriteLine();
            Console.WriteLine($"Exchange rate :: {DollarRate} $");
            stockExchangeTrading?.Invoke(DollarRate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trader> traders = new List<Trader>()
            {
                new Trader
                {
                    Money = 9597.6, 
                    Name = "Andriy", 
                    LastName = "Trader", 
                    Buy = 1, 
                    Sell = 97
                },
                new Trader
                {
                    Money = 123045.1,
                    Name = "Vitaliy",
                    LastName = "Minecraft",
                    Buy = 1,
                    Sell = 97
                },
                new Trader
                {
                    Money = 1234557.2,
                    Name = "Roma",
                    LastName = "EeoneGuy",
                    Buy = 1,
                    Sell = 97
                },
                new Trader
                {
                    Money = 6776788.4,
                    Name = "Kostya",
                    LastName = "Fallen",
                    Buy = 1,
                    Sell = 97
                },
                new Trader
                {
                    Money = 987997.87,
                    Name = "Oleg",
                    LastName = "Dota",
                    Buy = 1,
                    Sell = 97
                }
            };
            StockExchange stockExchange = new StockExchange();

            foreach (Trader trader in traders)
            {
                stockExchange.stockExchangeTrading += new StockExchangeTrading(trader.BuyCurrency);
            }
            for (int i = 0; i < 100; i++)
            {
                stockExchange.Create();
            }
        }
    }
}