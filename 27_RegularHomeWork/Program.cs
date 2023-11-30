using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace _27_RegularHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            string text = "Number pi = 3.14 or 3,15?";
            string pattern = @"^\d.\d+ | ^\d,\d+";

            MatchCollection matches = Regex.Matches(text, @"\d+\.\d+ | \d+\,\d+");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Value :: {item.Value}");
            }

            //N2

            //string text = "Number 1 2 3 4 67 8 9";
            //List<int> ints = new List<int>();
            //MatchCollection matches = Regex.Matches(text, @"\d+");
            //foreach (Match item in matches)
            //{
            //    if (int.TryParse(item.Value, out int number))
            //    {
            //        ints.Add(number);
            //    }
            //}

            //foreach (var item in ints)
            //{
            //    Console.Write($"{item}  ");
            //}
        }
    }
}