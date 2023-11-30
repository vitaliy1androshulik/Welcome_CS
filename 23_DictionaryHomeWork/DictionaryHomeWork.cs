using System.Text;
using System.Text.RegularExpressions;

namespace _23_DictionaryHomeWork
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Ось будинок,який збудував Джек.А це пшениця,яка " +
                          "у темній коморі зберігається у будинку,який збудував " +
                          "Джек.А це веселий птах-синиця,який часто краде " +
                          "пшеницю,яка в темній коморі зберігається у будинку," +
                          "який збудував Джек.";
            string[] words = text.Split(',',' ', '.', '!', '?', '\t', '\n');
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                    else
                    {
                        wordCounts[word] = 1;
                    }
                }
            }
            Console.WriteLine("\t\t\t   Слово:\t\t\t\tКількість:");
            Console.WriteLine();
            int count = 0;
            foreach (var entry in wordCounts)
            {
                count++;
                Console.WriteLine($"{count}.\t\t  {entry.Key,15}\t\t\t\t   {entry.Value}");
            }
            int unik = 0;
            foreach (KeyValuePair<string,int> item in wordCounts)
            {
                if(item.Value == 1)
                {
                    unik++;
                }
            }
            Console.WriteLine($"Всього слів :: {words.Length}, унікальних :: {unik}");
        }
    }
}