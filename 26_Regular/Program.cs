using System.Text.RegularExpressions;

namespace _26_Regular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            bool flag = true;
            //while (flag) 
            //{
            //    string str = Console.ReadKey().KeyChar.ToString();
            //    if(str == " ")
            //    {
            //        flag = false;
            //    }
            //    bool success =regex.IsMatch(str);
            //    //Console.WriteLine(success?"match found \"{0}\"" : $"match not found \"{pattern}\"", pattern);
            //    Console.WriteLine(success?$" match found \"{pattern}\"" : $" match not found \"{pattern}\"");
            //}
            string patternn = @"\D+";
            regex = new Regex(patternn);
            var array = new[] {"31231","12312412412","test1123412412","4123412" };
            foreach (string str in array)
            {
                Console.WriteLine(regex.IsMatch(str) ? $"String \"{pattern}\" matches" : $" String \"{pattern}\" not matches");
            }


            pattern = @"^[A-Z]+[a-z]*$";
            regex = new Regex(patternn);

            //while (flag) 
            //{
            //    Console.Write("Enter string :: ");
            //    string input = Console.ReadLine();
            //    if (input == "exit") break;
            //    Console.WriteLine(input!=null&&regex.IsMatch(input) ? $"String \"{pattern}\" matches" : $" String \"{pattern}\" not matches");
            //}
            //regex.Match(patternn);//цілий рядок

            string value = "4 - 5 AND 5 y 789";
            Match match =Regex.Match(value, @"\d");
            if(match.Success) 
            {
                Console.WriteLine(match.Value);
            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            while(match.Success)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }

            Match m = Regex.Match("123 Axx-1xxy \n Axyx-2xyxyx", @"A.*y");
            if(m.Success) 
            {
                Console.WriteLine(m.Value);
                Console.WriteLine(m.Length);
                Console.WriteLine(m.Index);
            }
            m = m.NextMatch();
            if(m.Success) 
            {
                Console.WriteLine(m.Value);
                Console.WriteLine(m.Length);
                Console.WriteLine(m.Index);
            }

            string value1 = "saidsaid said shed see spear speed super";
            MatchCollection matches = Regex.Matches(value1, @"s\w+d");
            Console.WriteLine("-------------------------");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Index :: {item.Index}, Value :: {item.Value}");
            }

            string inputString = "Don`t replace Dot net replaced net Net dots";
            string outString=Regex.Replace(inputString, "n.t", "NET");

            Console.WriteLine(inputString);
            Console.WriteLine(outString);
        }
    }
}