using System.Xml.Linq;

namespace _10_ExceptionNamespaceHomeWork
{

    class CreditCard
    {
        private string cardnumber;
        public string CardNumber
        {
            get { return cardnumber; }
            set
            {
                if (value.Length != 16)
                {
                    throw new ArgumentException("Error. Your card have bad count of number");
                }
                else
                {
                    cardnumber = value;
                }
            }
        }
        public string PIB { get; set; }

        private string cvc;
        public string CVC
        {
            get { return cvc; }
            set
            {
                if (value.Length != 3)
                {
                    throw new ArgumentException("Error. Your CVC code is wrong");
                }
                else
                {
                    cvc = value;
                }
            }
        }

        private DateTime time;

        public DateTime Time
        {
            get { return time; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Error. Wrong date");
                }
                else
                {
                    time = value;
                }

            }
        }


        public void EnterInformation()
        {
            Console.Write("Enter your card number (16 numbers) :: ");
            CardNumber = Console.ReadLine();
            Console.Write("Enter your PIB (name, surname, lastname) :: ");
            PIB = Console.ReadLine();
            Console.Write("Enter your CVC (3 numbers) :: ");
            CVC = Console.ReadLine();
            Console.Write("Enter your expiration date of the card(dd.mm.yy) :: ");
            Time = DateTime.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("--------------------Card--------------------");
            Console.WriteLine($"Card number :: {CardNumber}");
            Console.WriteLine($"PIB :: {PIB}");
            Console.WriteLine($"CVC :: {CVC}");
            Console.WriteLine($"Finish time :: {Time}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            //int numbers;
            //Console.Write("Enter numbers :: ");
            //try
            //{
            //    string a = Console.ReadLine();
            //    numbers = Convert.ToInt32(a);
            //    Console.WriteLine(numbers);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.Write(ex.Message);
            //}


            //N2
            //try
            //{
            //    CreditCard card = new CreditCard();
            //    card.EnterInformation();
            //    card.Print();
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //N3
            //try
            //{
            //    Console.Write("Enter mathematical expression :: ");
            //    string a = Console.ReadLine();
            //    int numbers;
            //    int result = 1;
            //    string[] b = a.Split('*');
            //    foreach (var element in b)
            //    {
            //        int number = int.Parse(element);
            //        result *= number;
            //    }
            //    Console.WriteLine($"Your result :: {result}");
            //}

            //catch (ArgumentException ex) 
            //{
            //    Console.WriteLine("Error.You enter not number");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Error.You enter very big number");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error.");
            //////}
        }   
    }
}
