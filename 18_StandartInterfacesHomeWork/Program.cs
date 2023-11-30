using System.Collections;
using System.Diagnostics.Metrics;
using System.IO;
using System.Xml.Linq;

namespace _18_StandartInterfacesHomeWork
{
    class Director:ICloneable
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public object Clone()
        {
            Director clone = (Director) this.MemberwiseClone();
            clone.Name = Name;
            clone.LastName = LastName;
            return clone;
        }

        public override string ToString()
        {
            return $"name :: {Name} {LastName}";
        }
    }
    enum Genre
    { 
        None = 0,
        Action,
        Adventure,
        Comedy,
        Crime,
        Fantasy,
        Historical,
        Horror,
        Romance, 
        Cyberpunk,
        Detective
    };

    class Movie : ICloneable, IComparable<Movie>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Director Director = new Director();
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }

        public object Clone()
        {
            Movie clone = (Movie) this.MemberwiseClone();
            clone.Name = Name;
            clone.Description = Description;
            clone.Director = Director;
            clone.Genre = Genre;
            clone.Year = Year;
            clone.Rating = Rating;
            clone.Country = Country;
            clone.Genre = Genre;
            return clone;

        }

        public int CompareTo(Movie? other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"------------Film \"{Name}\" ------------\nDescription :: {Description}\nCountry :: {Country}\nDirector {Director}\nGenre :: {Genre}\nYear :: {Year}\nRaating :: {Rating}\n";
        }
    }
    class Cinema : IEnumerable<Movie>
    {
        Movie[] movies =
        {
            new Movie
            {
                Name = "SAW X",
                Description = "Legendary horror",
                Director = new Director { Name = "Kevin", LastName = "Grotert"},
                Country = "USA",
                Genre = Genre.Horror,
                Year = 2023,
                Rating = 8
            },
            new Movie
            {
                Name = "Black Bird",
                Description = "Jimmy Keene is sentenced to 10 years in a minimum security prison \nbut he cuts a deal with the FBI to befriend a suspected serial killer",
                Director = new Director { Name = "Dennis", LastName = "Lehane"},
                Country = "USA",
                Genre = Genre.Detective,
                Year = 2022,
                Rating = 7
            },
            new Movie
            {
                Name = "Openheimer",
                Description = "The story of American scientist, J. Robert Oppenheimer, and \nhis role in the development of the atomic bomb.",
                Director = new Director { Name = "Nolan", LastName = "Christopher"},
                Country = "USA",
                Genre = Genre.Historical,
                Year = 2023,
                Rating = 8
            },
            new Movie
            {
                Name = "Barbie",
                Description = "Set in the colorful Barbie Land, stereotypical \nBarbie lives a perfect life every single day.",
                Director = new Director { Name = "Greta", LastName = "Gerwing"},
                Country = "USA",
                Genre = Genre.Romance,
                Year = 2023,
                Rating = 7
            },
            new Movie
            {
                Name = "Gran Turismo",
                Description = "Based on the true story of Jann Mardenborough, the\nfilm is the ultimate wish fulfillment tale of a teenage Gran Turismo player \nwhose gaming skills won a series of Nissan competitions to \nbecome an actual professional racecar driver.",
                Director = new Director { Name = "Neill", LastName = "Blomkamp"},
                Country = "USA",
                Genre = Genre.Romance,
                Year = 2023,
                Rating = 7
            },
        };
        public string Address { get; set; }

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(movies);
        }
        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }
        public override string ToString()
        {
            return $"Address :: {Address}";
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Movie> IEnumerable<Movie>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
    class CompareByRating: IComparer<Movie>
    {
        public int Compare(Movie? x , Movie? y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            cinema.Sort(new CompareByRating());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t SORTED BY RATING\n");
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            cinema.Sort(new CompareByYear());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t SORTED BY YEAR\n");
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            cinema.Sort();
            cinema.SetAddress("Kinopalac Ukraine. s.Rivne.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t SORTED\n");
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(cinema);
        }
    }
}