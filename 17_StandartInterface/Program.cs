using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace _17_StandartInterface
{
    class StudentCard : ICloneable
    {
        public string Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Student Card ::{Number}, series :: {Series}";
        }
    }
    class Student:IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public StudentCard StudentCard { get; set; }

        public int CompareTo(Student? other)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        public object Clone()
        {
            Student clone =(Student) this.MemberwiseClone();
            //clone.StudentCard = new StudentCard { Number = this.StudentCard.Number, Series = this.StudentCard.Series };
            clone.StudentCard =(StudentCard) this.StudentCard.Clone();
               
            return clone;
        }


        //public int CompareTo(object? obj)
        //{
        //    if(obj is Student)
        //    {
        //        return LastName.CompareTo((obj as Student).LastName);
        //    }
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Birthday :: {Birthday.ToShortDateString()}\n"+$"{StudentCard}\n";
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName = "Olya",
                LastName = "Oliunik",
                Birthday = new DateTime(2000, 10, 4),
                StudentCard = new StudentCard
                {
                    Number = 1234124,
                    Series = "AA"
                }
            },
            new Student
            {
                FirstName = "Bob",
                LastName = "Thomson",
                Birthday = new DateTime(2002, 11, 14),
                StudentCard = new StudentCard
                {
                    Number = 1233234,
                    Series = "AB"
                }
            },
            new Student
            {
                FirstName = "Katya",
                LastName = "Lukas",
                Birthday = new DateTime(2007, 9, 25),
                StudentCard = new StudentCard
                {
                    Number = 12334564,
                    Series = "AC"
                }
            },
            new Student
            {
                FirstName = "Candice",
                LastName = "Leman",
                Birthday = new DateTime(2003, 3, 9),
                StudentCard = new StudentCard
                {
                    Number = 123,
                    Series = "AD"
                }
            },
            new Student
            {
                FirstName = "Vova",
                LastName = "Olinuk",
                Birthday = new DateTime(1995, 2, 19),
                StudentCard = new StudentCard
                {
                    Number = 12223,
                    Series = "AE"
                }
            }
             
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class FirstNameComparer : IComparer<Student>
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return (x as Student).FirstName.CompareTo((y as Student).FirstName);
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
    class BirthdayComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Birthday.CompareTo(y.Birthday);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Vova",
                LastName = "Olinuk",
                Birthday = new DateTime(1995, 2, 19),
                StudentCard = new StudentCard
                {
                    Number = 12223,
                    Series = "AE"
                }
            };
            Console.WriteLine(student);
            Student copy = (Student) student.Clone();
            Console.WriteLine(copy);


            copy.StudentCard.Number = 111111;
            copy.FirstName = "Olibia";
            Console.WriteLine(student);
            Console.WriteLine(copy);
            //Auditory auditory = new Auditory();
            //foreach (var student in auditory) 
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("Sort by first name :: ");
            //auditory.Sort(new FirstNameComparer());
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("Sort by Birthday :: ");
            //auditory.Sort(new BirthdayComparer());
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }
}