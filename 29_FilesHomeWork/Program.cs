namespace _FilesHomeWork29_
{
    using System;
    using System.IO;

    //static int[] ReadArrayFromFile(string fileName)
    //{
    //    if (File.Exists(fileName))
    //    {
    //        string[] lines = File.ReadAllLines(fileName);
    //        int[] array = new int[lines.Length];

    //        for (int i = 0; i < lines.Length; i++)
    //        {
    //            if (int.TryParse(lines[i], out int value))
    //            {
    //                array[i] = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Помилка при зчитуванні рядка {i + 1} із файлу.");
    //            }
    //        }

    //        return array;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Файл не знайдено.");
    //        return null;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            ///1
            //Console.WriteLine("Введіть шлях до файлу:");
            //string filePath = Console.ReadLine();

            //if (File.Exists(filePath))
            //{
            //    string fileContent = File.ReadAllText(filePath);
            //    Console.WriteLine("Вміст файлу:");
            //    Console.WriteLine(fileContent);
            //}
            //else
            //{
            //    Console.WriteLine("Помилка: Файл не існує.");
            //}





            ///2
            //Console.WriteLine("Введіть кількість елементів масиву:");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Введіть значення елементів масиву:");

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Введіть ім'я файлу для збереження масиву:");
            //string fileName = Console.ReadLine();

            //using (StreamWriter writer = new StreamWriter(fileName))
            //{
            //    foreach (int element in array)
            //    {
            //        writer.WriteLine(element);
            //    }
            //}

            //Console.WriteLine("Масив було збережено у файлі: " + fileName);








            ///3
            //Console.WriteLine("Виберіть дію:");
            //Console.WriteLine("1. Ввести новий масив");
            //Console.WriteLine("2. Завантажити масив із файлу");

            //int choice = int.Parse(Console.ReadLine());

            //int[] array;

            //if (choice == 1)
            //{
            //    Console.WriteLine("Введіть кількість елементів масиву:");
            //    int n = int.Parse(Console.ReadLine);

            //    array = new int[n];

            //    Console.WriteLine("Введіть значення елементів масиву:");

            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine("Введіть ім'я файлу для завантаження масиву:");
            //    string fileName = Console.ReadLine();

            //    array = ReadArrayFromFile(fileName);
            //}
            //else
            //{
            //    Console.WriteLine("Невірний вибір.");
            //    return;
            //}








            ///4
            //int[] numbers = new int[10000];
            //Random random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 10001); 
            //}

            //string evenFilePath = "even_numbers.txt";
            //string oddFilePath = "odd_numbers.txt";

            //using (StreamWriter evenFile = new StreamWriter(evenFilePath))
            //using (StreamWriter oddFile = new StreamWriter(oddFilePath))
            //{
            //    foreach (int number in numbers)
            //    {
            //        if (number % 2 == 0)
            //        {
            //            evenFile.WriteLine(number);
            //        }
            //        else
            //        {
            //            oddFile.WriteLine(number);
            //        }
            //    }
            //}

            //int evenCount = File.ReadLines(evenFilePath).Count();
            //int oddCount = File.ReadLines(oddFilePath).Count();

            //Console.WriteLine($"Всього згенеровано {numbers.Length} чисел.");
            //Console.WriteLine($"Парних чисел: {evenCount}");
            //Console.WriteLine($"Непарних чисел: {oddCount}");









            ///5
            //static void Main(string[] args)
            //{
            //    Console.Write("Введіть шлях до файлу: ");
            //    string filePath = Console.ReadLine();

            //    Console.Write("Введіть слово для пошуку: ");
            //    string searchWord = Console.ReadLine();

            //    int count = 0;
            //    string[] lines = File.ReadAllLines(filePath);
            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        if (lines[i].Contains(searchWord))
            //        {
            //            count++;
            //            Console.WriteLine($"Знайдено '{searchWord}' на позиції {i + 1}");
            //        }
            //    }

            //    Console.WriteLine($"Знайдено {count} входжень слова '{searchWord}'.");

            //    string reversedSearchWord = new string(searchWord.Reverse().ToArray());
            //    count = 0;
            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        if (lines[i].Contains(reversedSearchWord))
            //        {
            //            count++;
            //            Console.WriteLine($"Знайдено '{reversedSearchWord}' на позиції {i + 1} (у зворотному порядку)");
            //        }
            //    }

            //    Console.WriteLine($"Знайдено {count} входжень слова '{reversedSearchWord}' у зворотному порядку.");







            ///6
            //    Console.Write("Введіть шлях до файлу: ");
            //    string filePath = Console.ReadLine();

            //    if (File.Exists(filePath))
            //    {
            //        string text = File.ReadAllText(filePath);
            //        int sentenceCount = CountSentences(text);
            //        int uppercaseCount = CountUppercaseLetters(text);
            //        int lowercaseCount = CountLowercaseLetters(text);
            //        int vowelCount = CountVowels(text);
            //        int consonantCount = CountConsonants(text);
            //        int digitCount = CountDigits(text);

            //        Console.WriteLine($"Кількість речень: {sentenceCount}");
            //        Console.WriteLine($"Кількість великих літер: {uppercaseCount}");
            //        Console.WriteLine($"Кількість маленьких літер: {lowercaseCount}");
            //        Console.WriteLine($"Кількість голосних літер: {vowelCount}");
            //        Console.WriteLine($"Кількість приголосних літер: {consonantCount}");
            //        Console.WriteLine($"Кількість цифр: {digitCount}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Файл не знайдено.");
            //    }
            //}

            //static int CountSentences(string text)
            //{
            //    char[] sentenceSeparators = { '.', '!', '?' };
            //    return text.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries).Length;
            //}

            //static int CountUppercaseLetters(string text)
            //{
            //    return text.Count(char.IsUpper);
            //}

            //static int CountLowercaseLetters(string text)
            //{
            //    return text.Count(char.IsLower);
            //}

            //static int CountVowels(string text)
            //{
            //    char[] vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я', 'a', 'e', 'i', 'o', 'u' };
            //    return text.Count(c => vowels.Contains(char.ToLower(c)));
            //}

            //static int CountConsonants(string text)
            //{
            //    char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ґ',
            //    'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            //    return text.Count(c => consonants.Contains(char.ToLower(c)));
            //}

            //static int CountDigits(string text)
            //{
            //    return text.Count(char.IsDigit);
            //}
        }

    }
}