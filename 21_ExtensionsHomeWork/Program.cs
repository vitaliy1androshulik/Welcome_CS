using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace _21_ExtensionsHomeWork
{
    static class Extensions
    {
        public static int Palindrome(this string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return 0;
                }
            }
            return 1;
        }
        public static string GoToPassword(this string s, int key)
        {
            char[] a = new char[s.Length];
            for (int i = 0; i < a.Length; i++)
            {
                char symbol = s[i];
                a[i] = (char)(symbol + key);
            }
            //string res = a.ToString();
            return new string(a);
        }

        public static int SameElements(this int[] arr, int num)
        {
            int count = 0;

            foreach (var item in arr)
            {
                if (item.Equals(num))
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            //Console.Write("Enter word :: ");
            //string s = Console.ReadLine();
            //int res = s.Palindrome();
            //if (res == 1)
            //{
            //    Console.WriteLine("Word is palindrome");
            //}
            //else { Console.WriteLine("Word is not palindrome"); }

            //N2
            //Console.Write("Enter the encryption word :: ");
            //string s = Console.ReadLine();
            //string res = s.GoToPassword(2);
            //Console.WriteLine("Your new word :: " + res);

            //N3
            int[]arr = new int[10];
            Console.Write("Enter elements for array :: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Identical elements in the array :: "+arr.SameElements(2));
        }
    }
}