//N1
//using System.Net.Security;
//using System.Text;
//string arr1 = "Hello my first row";
//string arr2 = "Good bye it`s my second row";
//StringBuilder b = new StringBuilder(arr1);
//Console.WriteLine(b);
//b.Insert(11, arr2);
//Console.WriteLine(b);
//N2
//string Word = "dir";
//bool words = false;
//int length = Word.Length;
//for (int i = 0; i < length / 2; i++)
//{
//    if (Word[i] != Word[length - i - 1])
//    {
//        Console.WriteLine("Is not palindrome");
//    }
//    else
//    {
//        Console.WriteLine("Is palindrome");
//    }
//}
//N3
//string text = "Hello, today very cool weather"; 

//int allSym = text.Length;
//int upCount = 0;
//int lowCount = 0;
//foreach (char character in text)
//{
//    if (char.IsUpper(character))
//    {
//        upCount++;
//    }
//    else if (char.IsLower(character))
//    {
//        lowCount++;
//    }
//}
//double upPer = (double)upCount / allSym * 100;
//double lowPer = (double)lowCount / allSym * 100;
//Console.WriteLine("Percentage ratio of capital letters: " + upPer+ "%");
//Console.WriteLine("Percentage ratio lowercase letters: " + lowPer + "%");

//N4

//string[] words = new string[5];
//Console.Write("Enter words for array :: ");
//for (int i = 0; i < words.Length; i++)
//{
//    words[i] = Console.ReadLine();
//}
//Console.WriteLine("Enter number of your word :: ");
//int number = int.Parse(Console.ReadLine());
//for (int i = 0; i < words.Length; i++)
//{
//    if (i == number)
//    {
//        if (words[i].Length >= 3)
//        {
//            words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
//            //Sybstring - функція яка в слові може дійти до любого символа, в моєму прикладі від 0-го символа слова до -3-го символа з кінця
//            //тобто, якщо слово наприклад Hello, функція починає йти з букви H і йде до букви яка буде на -3 позиції з кінця тобто e, символи llo заміняться на знак $ 
//        }
//        else
//        { 
//            words[i] = new string('$', words[i].Length);
//        }
//    }
//}
//Console.WriteLine("Your words :: ");
//for (int i = 0; i < words.Length; i++)
//{
//    Console.Write(words[i] + " ");
//}


//N5
//string[] words = new string[5];
//Console.Write("Enter words for array :: ");
//for (int i = 0; i < words.Length; i++)
//{
//    words[i] = Console.ReadLine();
//}

//Console.Write("Enter number of word :: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 0; i < words.Length; i++)
//{
//    if(i == number)
//    {
//        Console.WriteLine($"Your word :: {words[i]}, first symbol :: {words[i].Substring(0, 1)}");
//    }
//}

//N6
//string sentence = "          Hello where are you from? ";
//Console.WriteLine(sentence);
//string result = sentence.Trim().Replace(" ", "*" );
//Console.WriteLine(result);

//N7

using System.Text;

StringBuilder a = new StringBuilder();
Console.Write("Enter words (to finish press .) :: ");
string b = new string ("1");
do
{
    b = Console.ReadLine();
    a.Append(b);
} while (b!=".");
Console.WriteLine(a.ToString());
a.Replace(" ", ", ");
Console.WriteLine(a.ToString());
