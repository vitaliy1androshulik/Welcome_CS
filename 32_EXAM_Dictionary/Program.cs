using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _32_EXAM_Dictionary
{
    [Serializable]
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("uk-UA");
            static void PrintExit()
            {
                Console.Clear();
                Console.Write("G");
                Thread.Sleep(50);
                Console.Write("o");
                Thread.Sleep(50);
                Console.Write("o");
                Thread.Sleep(50);
                Console.Write("d");
                Thread.Sleep(50);
                Console.Write("b");
                Thread.Sleep(50);
                Console.Write("y");
                Thread.Sleep(50);
                Console.Write("e");
                Thread.Sleep(50);
                Console.Write("!");
                Thread.Sleep(50);
            }
            static void PrintMenu()
            {
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("D");
                Thread.Sleep(50);
                Console.Write("i");
                Thread.Sleep(50);
                Console.Write("c");
                Thread.Sleep(50);
                Console.Write("t");
                Thread.Sleep(50);
                Console.Write("i");
                Thread.Sleep(50);
                Console.Write("o");
                Thread.Sleep(50);
                Console.Write("n");
                Thread.Sleep(50);
                Console.Write("a");
                Thread.Sleep(50);
                Console.Write("r");
                Thread.Sleep(50);
                Console.Write("y");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.WriteLine();
                Console.WriteLine("1.)Add UKR. word and ENG. translate");
                Console.WriteLine("2.)Add a ENG. translation to the UKR. word");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("3.)Add ENG. word and UKR. translate");
                Console.WriteLine("4.)Add a UKR. translation to the ENG. word");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("5.)Show all words");
                Console.WriteLine("6.)Show all UKR. words");
                Console.WriteLine("7.)Show all ENG. words");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("8.)Search UKR. word by translate");
                Console.WriteLine("9.)Search ENG. word by translate");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("10.)Sort UKR. word");
                Console.WriteLine("11.)Sort ENG. word");
                Console.WriteLine("12.)Sort all words");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("13.)Edit UKR. word");
                Console.WriteLine("14.)Edit ENG. word");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("15.)Delete UKR. word");
                Console.WriteLine("16.)Delete ENG. word");
                Console.WriteLine("17.)Delete all words");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("18.)Save to file UKR. words");
                Console.WriteLine("19.)Save to file ENG. words");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("20.)Load from file UKR. words");
                Console.WriteLine("21.)Load from file ENG. words");
                Console.WriteLine();
                Console.WriteLine("0.)Exit");



            }
            static void PrintUKR()
            {
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("U");
                Thread.Sleep(50);
                Console.Write("k");
                Thread.Sleep(50);
                Console.Write("r");
                Thread.Sleep(50);
                Console.Write("a");
                Thread.Sleep(50);
                Console.Write("i");
                Thread.Sleep(50);
                Console.Write("n");
                Thread.Sleep(50);
                Console.Write("e");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.WriteLine();

            }
            static void PrintENG()
            {
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("E");
                Thread.Sleep(50);
                Console.Write("n");
                Thread.Sleep(50);
                Console.Write("g");
                Thread.Sleep(50);
                Console.Write("l");
                Thread.Sleep(50);
                Console.Write("i");
                Thread.Sleep(50);
                Console.Write("s");
                Thread.Sleep(50);
                Console.Write("h");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.WriteLine();

            }
            static void PrintAllWords()
            {
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("W");
                Thread.Sleep(50);
                Console.Write("o");
                Thread.Sleep(50);
                Console.Write("r");
                Thread.Sleep(50);
                Console.Write("d");
                Thread.Sleep(50);
                Console.Write("s");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.Write("--");
                Thread.Sleep(50);
                Console.WriteLine();

            }

            Dictionary<string, List<string>> wordsUKR = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> wordsENG = new Dictionary<string, List<string>>();
            static void AddWordAndTranslate_UKR_ENG(Dictionary<string, List<string>> wordsUKR)
            {
                List<string> translateUKR_ENG = new List<string>();
                Console.Write("Enter new UKR. word :: ");
                string word = Console.ReadLine();

                Console.Write("Enter his ENG. translate :: ");
                string transateToWord = Console.ReadLine();

                translateUKR_ENG.Add(transateToWord);

                wordsUKR.Add(word, translateUKR_ENG);

                Console.WriteLine("Word and translate added successful!");
            }
            static void AddTranslateToWord_UKR_ENG(Dictionary<string, List<string>> wordsUKR)
            {
                List<string> newTranslateUKR_ENG = new List<string>();
                Console.Write("Enter UKR. word :: ");
                string word = Console.ReadLine();

                Console.Write("Enter another ENG. translation :: ");
                string translateWord = Console.ReadLine();
                string result = ", " + translateWord;

                if(wordsUKR.TryGetValue(word, out List<string> ex))
                {
                    newTranslateUKR_ENG = ex;
                    newTranslateUKR_ENG.Add(result);

                    wordsUKR[word] = newTranslateUKR_ENG;

                    Console.WriteLine("Another translation added successfully!!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this UKR. word!");
                }
            }
            static void ShowUKRWords(Dictionary<string, List<string>> wordsUKR)
            {
                PrintUKR();
                foreach (var word in wordsUKR) 
                {
                    Console.Write($"{word.Key} - ");
                    foreach (var item in word.Value)
                    {
                        Console.WriteLine($"{item}");
                    }
                } 
                Console.WriteLine();
            }

            static void AddWordAndTranslate_ENG_UKR(Dictionary<string, List<string>> wordsENG)
            {
                List<string> translateENG_UKR = new List<string>();
                Console.Write("Enter new ENG. word :: ");
                string word = Console.ReadLine();

                Console.Write("Enter his UKR. translate :: ");
                string transateToWord = Console.ReadLine();

                translateENG_UKR.Add(transateToWord);

                wordsENG.Add(word, translateENG_UKR);

                Console.WriteLine("Word and translate added successful!");
            }
            static void AddTranslateToWord_ENG_UKR(Dictionary<string, List<string>> wordsENG)
            {
                List<string> newTranslateENG_UKR = new List<string>();
                Console.Write("Enter ENG. word :: ");
                string word = Console.ReadLine();

                Console.Write("Enter another UKR. translation :: ");
                string translateWord = Console.ReadLine();
                string result = ", " + translateWord;

                if (wordsENG.TryGetValue(word, out List<string> ex))
                {
                    newTranslateENG_UKR = ex;
                    newTranslateENG_UKR.Add(result);

                    wordsENG[word] = newTranslateENG_UKR;

                    Console.WriteLine("Another translation added successfully!!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this ENG. word!");
                }
            }
            static void ShowENGWords(Dictionary<string, List<string>> wordsENG)
            {
                PrintENG();
                foreach (var word in wordsENG)
                {
                    Console.Write($"{word.Key} - ");
                    foreach (var item in word.Value)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                Console.WriteLine();
            }

            static void ShowAllWords(Dictionary<string, List<string>> wordsUKR, Dictionary<string, List<string>> wordsENG)
            {
                ShowUKRWords(wordsUKR);
                ShowENGWords(wordsENG);
                Console.WriteLine();
            }

            static void SearchUKRWordByTranslate(Dictionary<string, List<string>> wordsUKR)
            {
                Console.Write("Enter your ENG. translate :: ");
                string translate = Console.ReadLine();
                
                foreach (var item in wordsUKR)
                {
                    foreach (var value in item.Value)
                    {
                        if(value.Contains(translate))
                        {
                            Console.Write($"Your word is :: {item.Key} ");
                        }
                    }
                }
            }
            static void SearchENGWordByTranslate(Dictionary<string, List<string>> wordsENG)
            {
                Console.Write("Enter your UKR. translate :: ");
                string translate = Console.ReadLine();

                foreach (var item in wordsENG)
                {
                    foreach (var value in item.Value)
                    {
                        if (value.Contains(translate))
                        {
                            Console.Write($"Your word is :: {item.Key} ");
                        }
                    }
                }
            }

            static void SortUKRWord(Dictionary<string, List<string>> wordsUKR, IComparer<string> comparer)
            {
                var sortedDictionary = wordsUKR.ToList();
                sortedDictionary.Sort((x, y) => comparer.Compare(x.Key, y.Key));

                wordsUKR.Clear();
                foreach (var item in sortedDictionary)
                {
                    wordsUKR.Add(item.Key, item.Value);
                }

                Console.WriteLine("Your UKR. dictionary sorted!!");
            }
            static void SortENGWord(Dictionary<string, List<string>> wordsENG, IComparer<string> comparer)
            {
                var sortedDictionary = wordsENG.ToList();
                sortedDictionary.Sort((x, y) => comparer.Compare(x.Key, y.Key));

                wordsENG.Clear();
                foreach (var item in sortedDictionary)
                {
                    wordsENG.Add(item.Key, item.Value);
                }

                Console.WriteLine("Your ENG. dictionary sorted!!");
            }

            static void EditUKRWord(Dictionary<string, List<string>> wordsUKR)
            {
                Console.Write("Enter UKR. word for edit :: ");
                string editWord = Console.ReadLine();
                Console.Write("Enter new UKR. word :: ");
                string editedWord = Console.ReadLine();

                if (wordsUKR.ContainsKey(editWord))
                {
                    if (wordsUKR.TryGetValue(editWord, out List<string> existingValue))
                    {
                        wordsUKR.Remove(editWord);
                        wordsUKR.Add(editedWord, existingValue);
                    }
                    Console.WriteLine("Word edited!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this word!");
                }
            }
            static void EditENGWord(Dictionary<string, List<string>> wordsENG)
            {
                Console.Write("Enter ENG. word for edit :: ");
                string editWord = Console.ReadLine();
                Console.Write("Enter new ENG. word :: ");
                string editedWord = Console.ReadLine();

                if (wordsENG.ContainsKey(editWord))
                {
                    if (wordsENG.TryGetValue(editWord, out List<string> existingValue))
                    {
                        wordsENG.Remove(editWord);
                        wordsENG.Add(editedWord, existingValue);
                    }
                    Console.WriteLine("Word edited!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this word!");
                }
            }

            static void DeleteUKRWord(Dictionary<string, List<string>> wordsUKR)
            {
                Console.Write("Enter UKR. word for delete :: ");
                string deleteWord = Console.ReadLine();
                if(wordsUKR.ContainsKey(deleteWord))
                {
                    wordsUKR.Remove(deleteWord);
                    Console.WriteLine("Word deleted!!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this word!");
                }
            }
            static void DeleteENGWord(Dictionary<string, List<string>> wordsENG)
            {
                Console.Write("Enter ENG. word for delete :: ");
                string deleteWord = Console.ReadLine();
                if (wordsENG.ContainsKey(deleteWord))
                {
                    wordsENG.Remove(deleteWord);
                    Console.WriteLine("Word deleted!!");
                }
                else
                {
                    Console.WriteLine("Dictionary don`t have this word!");
                }
            }
            static void DeleteAllWords(Dictionary<string, List<string>> wordsUKR, Dictionary<string, List<string>> wordsENG)
            {
                wordsUKR.Clear();
                wordsENG.Clear();
                Console.WriteLine("All words deleted!!");
            }

            static void SaveToFileUKRWords(Dictionary<string, List<string>> wordsUKR)
            {
                if (wordsUKR.Count > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (Stream fs = File.Create("UKRWords.bin"))
                    {
                        formatter.Serialize(fs, wordsUKR);
                    }
                    Console.WriteLine("UKR. words has been saved!.");
                }
                else
                {
                    Console.WriteLine("You don`t have words to save!.");
                }
            }
            static void SaveToFileENGWords(Dictionary<string, List<string>> wordsENG)
            {
                if (wordsENG.Count > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (Stream fs = File.Create("ENGWords.bin"))
                    {
                        formatter.Serialize(fs, wordsENG);
                    }
                    Console.WriteLine("ENG. words has been saved!.");
                }
                else
                {
                    Console.WriteLine("You don`t have words to save!.");
                }
            }
            static void SaveToFileAllWords(Dictionary<string, List<string>> wordsUKR,Dictionary< string, List<string>> wordsENG)
            {
                if (wordsENG.Count > 0||wordsUKR.Count>0)
                {
                    string text = "-------------------------";
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (Stream fs = File.Create("ALLWords.bin"))
                    {
                        
                        formatter.Serialize(fs, wordsUKR);
                        formatter.Serialize(fs, "-------------------------");
                        formatter.Serialize(fs, wordsENG);
                    }
                    Console.WriteLine("ENG. and UKR. words has been saved!.");
                }
                else
                {
                    Console.WriteLine("You don`t have words to save!.");
                }
            }

            static void LoadFromFileUKRWords(Dictionary<string, List<string>> wordsUKR)
            {
                if (File.Exists("UKRWords.bin"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Dictionary<string, List<string>> loadUKRWords = null;
                    using (Stream fs = File.OpenRead("UKRWords.bin"))
                    {
                        loadUKRWords = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                    }
                    foreach (var item in loadUKRWords)
                    {
                        Console.Write($"{item.Key} - ");
                        foreach (var value in item.Value)
                        {
                            Console.WriteLine($"{value}");
                        }
                    }

                    wordsUKR.Clear();
                    foreach (var item in loadUKRWords)
                    {
                        wordsUKR.Add(item.Key, item.Value);
                    }
                    Console.WriteLine("UKR. words has been loaded!.");
                }
                else
                {
                    Console.WriteLine("UKR. words don`t found!!.");
                }
            }
            static void LoadFromFileENGWords(Dictionary<string, List<string>> wordsENG)
            {
                if (File.Exists("ENGWords.bin"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Dictionary<string, List<string>> loadENGWords = null;
                    using (Stream fs = File.OpenRead("ENGWords.bin"))
                    {
                        loadENGWords = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                    }
                    foreach (var item in loadENGWords)
                    {
                        Console.Write($"{item.Key} - ");
                        foreach (var value in item.Value)
                        {
                            Console.WriteLine($"{value}");
                        }
                    }

                    wordsENG.Clear();
                    foreach (var item in loadENGWords)
                    {
                        wordsENG.Add(item.Key, item.Value);
                    }
                    Console.WriteLine("ENG. words has been loaded!.");
                }
                else
                {
                    Console.WriteLine("ENG. words don`t found!!.");
                }
            }

            int a = new int();
            do
            {
                PrintMenu();
                Console.WriteLine();
                Console.Write("Enter your variant :: ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Console.Clear();   
                            AddWordAndTranslate_UKR_ENG(wordsUKR);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            AddWordAndTranslate_ENG_UKR(wordsENG);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            AddTranslateToWord_UKR_ENG(wordsUKR);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            AddTranslateToWord_ENG_UKR(wordsENG);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            ShowAllWords(wordsUKR, wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            ShowUKRWords(wordsUKR);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            ShowENGWords(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            SearchUKRWordByTranslate(wordsUKR);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            SearchENGWordByTranslate(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();
                            SortUKRWord(wordsUKR, StringComparer.Create(new System.Globalization.CultureInfo("uk-UA"),false));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 11:
                        {
                            Console.Clear();
                            SortENGWord(wordsENG, StringComparer.Create(new System.Globalization.CultureInfo("en-EN"), false));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 12:
                        {
                            Console.Clear();
                            SortENGWord(wordsENG, StringComparer.Create(new System.Globalization.CultureInfo("en-EN"), false));
                            SortUKRWord(wordsUKR, StringComparer.Create(new System.Globalization.CultureInfo("uk-UA"), false));
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 13:
                        {
                            Console.Clear();
                            EditUKRWord(wordsUKR);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 14:
                        {
                            Console.Clear();
                            EditENGWord(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 15:
                        {
                            Console.Clear();
                            DeleteUKRWord(wordsUKR); 
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 16:
                        {
                            Console.Clear();
                            DeleteENGWord(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 17:
                        {
                            Console.Clear();
                            DeleteAllWords(wordsUKR, wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 18:
                        {
                            Console.Clear();
                            SaveToFileUKRWords(wordsUKR);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 19:
                        {
                            Console.Clear();
                            SaveToFileENGWords(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 20:
                        {
                            Console.Clear();
                            LoadFromFileUKRWords(wordsUKR);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 21:
                        {
                            Console.Clear();
                            LoadFromFileUKRWords(wordsENG);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            SaveToFileUKRWords(wordsUKR);
                            SaveToFileENGWords(wordsENG);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (a!=0);
            PrintExit();
        }
    }
}