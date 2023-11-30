namespace _30__LINQHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1 Order By
            //int[] arr = { 3, 22, 3, 14, 65, 56 }; 
            //var numbers = arr.OrderBy(x => x);

            //foreach (var i in numbers) 
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //numbers = arr.OrderByDescending(x => x);
            //foreach(var i in numbers)
            //{
            //    Console.Write(i+" ");
            //}


            //N2
            int[] arr = { 1, -2, 3, -4, 5, 6 ,10,11234,124,5};

            var positiveNumber = arr.Where(x=> x>=0).Average();
            var countSoloPositive = arr.Where((x)=>x>=0&&x<10).Count();
            var countDoublePositive = arr.Where((x)=>x>=0&&x>9).Count();


            var negativeNumber = arr.Where(x => x < 0).Average();
            var countSoloNegative = arr.Where((x) => x < 0 && x > -10).Count();
            var countDoubleNegative = arr.Where((x) => x < 0 && x < -9).Count();

            Console.WriteLine("------------Positive------------");
            Console.WriteLine($"Average :: {positiveNumber}");
            Console.WriteLine($"The number of non-double-digit numbers :: {countSoloPositive}");
            Console.WriteLine($"The number of two-digit numbers :: {countDoublePositive}");
            Console.WriteLine("------------Negative------------");
            Console.WriteLine($"Average :: {negativeNumber}");
            Console.WriteLine($"The number of non-double-digit numbers :: {countSoloNegative}");
            Console.WriteLine($"The number of two-digit numbers :: {countDoubleNegative}");
        }
    }
}