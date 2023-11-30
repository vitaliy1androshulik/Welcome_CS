using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace C__Exam
{
    [Serializable]
    class Dictionary
    {
        public string Name { get; set; }
        public DicType Type { get; set; }
        public List<Word> Words { get; set; }

        public Dictionary(string name, DicType type)
        {
            Name = name;
            Type = type;
            Words = new List<Word>();
        }

        public void AddWord(Word word)
        {
            Words.Add(word);
        }

        public void RemoveWord(Word word)
        {
            if (Words.Count > 1)
            {
                Words.Remove(word);
            }
            else
            {
                throw new InvalidOperationException("Не можна видалити останній варіант перекладу.");
            }
        }
        public void ExportToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var word in Words)
                {
                    writer.WriteLine($"Слово: {word.OriginalWord}");
                    writer.WriteLine("Переклади:");
                    foreach (var translation in word.Translations)
                    {
                        writer.WriteLine(translation);
                    }
                    writer.WriteLine();
                }
            }
        }
    }

    class Word
    {
        public string OriginalWord { get; set; }
        public List<string> Translations { get; set; }

        public Word(string originalWord)
        {
            OriginalWord = originalWord;
            Translations = new List<string>();
        }

        public void AddTranslation(string translation)
        {
            Translations.Add(translation);
        }

        public void Remove(string translation)
        {
            Translations.Remove(translation);
        }
    }

    enum DicType
    {
        EnglishToUkrainian,
        UkrainianToEnglish
    }

    class DictionaryApp
    {
        public List<Dictionary> dictionaries { get; set; }

        public DictionaryApp()
        {
            dictionaries = new List<Dictionary>();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. додати словник");
                Console.WriteLine("2. Додати слово");
                Console.WriteLine("3. Замінити слово або переклад");
                Console.WriteLine("4. Видалити слово або переклад");
                Console.WriteLine("5. Шукати переклад");
                Console.WriteLine("6. Експортувати");
                Console.WriteLine("7. Вийти");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Спробуйте ще раз.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        AddWord();
                        break;
                    case 3:
                        Replace();
                        break;
                    case 4:
                        Remove();
                        break;
                    case 5:
                        SearchTranslation();
                        break;
                    case 6:
                        Export();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        private void Create()
        {
            Console.WriteLine("Введіть назву словника:");
            string name = Console.ReadLine();
            Console.WriteLine("Виберіть тип словника (1 - Англо-український, 2 - Українсько-англійський):");
            int typeChoice;
            if (!int.TryParse(Console.ReadLine(), out typeChoice) || typeChoice < 1 || typeChoice > 2)
            {
                Console.WriteLine("Некоректний вибір типу словника.");
                return;
            }

            DicType type = (DicType)(typeChoice - 1);
            Dictionary dictionary = new Dictionary(name, type);
            dictionaries.Add(dictionary);
            Console.WriteLine($"Словник '{name}' створено.");
        }

        private void AddWord()
        {
            Console.WriteLine("Введіть назву словника, в який ви хочете додати слово:");
            string dictionaryName = Console.ReadLine();

            var dictionary = dictionaries.FirstOrDefault(d => d.Name.Equals(dictionaryName, StringComparison.OrdinalIgnoreCase));

            if (dictionary == null)
            {
                Console.WriteLine("Словник не знайдено.");
                return;
            }

            Console.WriteLine("Введіть слово:");
            string wordText = Console.ReadLine();
            Word word = new Word(wordText);

            while (true)
            {
                Console.WriteLine("Введіть переклад (або введіть 'хватить', для завершення додавання):");
                string translation = Console.ReadLine();

                if (translation.ToLower() == "хватить")
                    break;

                word.AddTranslation(translation);
            }

            dictionary.AddWord(word);
            Console.WriteLine($"Слово '{wordText}' додано до словника '{dictionaryName}'.");
        }

        private void Replace()
        {
            Console.WriteLine("Введіть назву словника:");
            string dictionaryName = Console.ReadLine();
            //шукає словник зі списку dictionaries, який має ім'я, ідентичне введеному користувачем dictionaryName, і зберігає його в змінну dictionary
            var dictionary = dictionaries.FirstOrDefault(d => d.Name.Equals(dictionaryName, StringComparison.OrdinalIgnoreCase));

            if (dictionary == null)
            {
                Console.WriteLine("Словник не знайдено.");
                return;
            }

            Console.WriteLine("Введіть слово або переклад для заміни:");
            string wordOrTranslation = Console.ReadLine();

            var word = dictionary.Words.FirstOrDefault(w => w.OriginalWord.Equals(wordOrTranslation, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                Console.WriteLine("Введіть новий текст для слова:");
                string newWordText = Console.ReadLine();
                word.OriginalWord = newWordText;
                Console.WriteLine($"Слово '{wordOrTranslation}' було замінено на '{newWordText}'.");
            }
            else
            {
                foreach (var w in dictionary.Words)
                {
                    if (w.Translations.Contains(wordOrTranslation, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Введіть новий текст для перекладу:");
                        string newTranslation = Console.ReadLine();
                        w.Translations[w.Translations.IndexOf(wordOrTranslation)] = newTranslation;
                        Console.WriteLine($"Переклад '{wordOrTranslation}' було замінено на '{newTranslation}'.");
                        return;
                    }
                }
                Console.WriteLine($"Слово або переклад '{wordOrTranslation}' не знайдено в словнику.");
            }
        }

        private void Remove()
        {
            Console.WriteLine("Введіть назву словника:");
            string dictionaryName = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Name.Equals(dictionaryName, StringComparison.OrdinalIgnoreCase));

            if (dictionary == null)
            {
                Console.WriteLine("Словник не знайдено.");
                return;
            }

            Console.WriteLine("Введіть слово або переклад для видалення:");
            string wordOrTranslation = Console.ReadLine();

            var word = dictionary.Words.FirstOrDefault(w => w.OriginalWord.Equals(wordOrTranslation, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                try
                {
                    dictionary.RemoveWord(word);
                    Console.WriteLine($"Слово '{wordOrTranslation}' видалено зі словника '{dictionaryName}'.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                foreach (var w in dictionary.Words)
                {
                    if (w.Translations.Contains(wordOrTranslation, StringComparer.OrdinalIgnoreCase))
                    {
                        w.Remove(wordOrTranslation);
                        Console.WriteLine($"Переклад '{wordOrTranslation}' видалено з словника '{dictionaryName}'.");
                        return;
                    }
                }
                Console.WriteLine($"Слово або переклад '{wordOrTranslation}' не знайдено в словнику.");
            }
        }

        private void SearchTranslation()
        {
            Console.WriteLine("Введіть назву словника, в якому шукати переклад:");
            string dictionaryName = Console.ReadLine();
            var dictionary = dictionaries.FirstOrDefault(d => d.Name.Equals(dictionaryName, StringComparison.OrdinalIgnoreCase));

            if (dictionary == null)
            {
                Console.WriteLine("Словник не знайдено.");
                return;
            }

            Console.WriteLine("Введіть слово для пошуку перекладу:");
            string wordText = Console.ReadLine();

            var word = dictionary.Words.FirstOrDefault(w => w.OriginalWord.Equals(wordText, StringComparison.OrdinalIgnoreCase));
            if (word != null)
            {
                Console.WriteLine($"Переклади слова '{wordText}' в словнику '{dictionaryName}':");
                foreach (var translation in word.Translations)
                {
                    Console.WriteLine(translation);
                }
            }
            else
            {
                Console.WriteLine($"Слово '{wordText}' не знайдено в словнику '{dictionaryName}'.");
            }
        }

        private void Export()
        {
            if (dictionaries.Count > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fs = File.Create("Dictionary.bin"))
                {
                    formatter.Serialize(fs, dictionaries);
                }
                Console.WriteLine("User data has been serialized and saved.");
            }
            else
            {
                Console.WriteLine("No user data to save.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DictionaryApp Slovnuck = new DictionaryApp();
            Slovnuck.Run();
        }
    }
}
