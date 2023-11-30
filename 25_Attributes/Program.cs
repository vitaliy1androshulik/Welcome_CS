using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace _25_Serializable
{

    //[Serializable]
    public class Passport
    {
        public int Number { get; set; }
        public Passport(){ }
        public Passport()
        {
            Number =34126657;
        }
        public override string ToString()
        {
            return $"Number :: {Number}";
        }
    }
    //[Serializable]
    class Person
    {
        public Passport Passport { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        int _identNumber;
        const string Planet = "Earth";
        public Person(int number)
        {
            _identNumber = number;
            Passport = new Passport();
        }
        public override string ToString() 
        {
            return $"Name :: {Name}\nAge :: {Age}\nPlanet :: {Planet}\nPassport :: {Passport}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(12312323){ Name="Jack", Age=25},
                new Person(5454633){ Name="Bob", Age=15},
                new Person(15435451){ Name="Jack", Age=22}
            };
            //foreach (var item in people)
            //{
            //    Console.WriteLine("------------------------------------");
            //    Console.WriteLine(item);
            //} 


            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

            //try
            //{
            //    string filename = "Persons.json";
            //    string jsonString = JsonSerializer.Serialize(people);
            //    File.WriteAllText(filename, jsonString);

            //    jsonString = File.ReadAllText(filename);
            //    List<Person> newpersons = JsonSerializer.Deserialize<List<Person>>(jsonString);
            //    foreach (var item in newpersons)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            // BinaryFormatter formater = new BinaryFormatter();
            try
            {
                
                using (Stream fstream = File.Create("TestXML.xml"))
                {
                    xml.Serialize(fstream, people);
                }
                Console.WriteLine("XML OK!!!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            List<Person> newList = null;

            using (Stream fstream = File.OpenRead("Test.bin"))
            {
                newList = (List<Person>)xml.Deserialize(fstream);
            }
            foreach (var item in newList) 
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(item);
            }
        }
    }
}