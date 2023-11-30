using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace _31_User
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter your login!!")]
        [RegularExpression(@"^([a-zA-Z])\w+$", ErrorMessage = "Login should only contain letters and numbers")]
        public string Login { get; set; }
        [Required(ErrorMessage = "You must enter your e-mail!!")]
        [EmailAddress(ErrorMessage = "Your e-mail should be on account of this : example123@gmail.com")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must enter your password!!")]
        [RegularExpression(@"^(\w{8,})", ErrorMessage = "Password must be 8 characters long (letters (A-Z, a-z) or numbers (0-9))")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [RegularExpression(@"^\d{16}", ErrorMessage = "Credit card number must consist of 16 characters")]
        public int CreditCard { get; set; }
        [Required]
        [RegularExpression(@"^\+38+(-+0+\d{2})+(-+\d{3})+(-+\d{2})+(-+\d{2})", ErrorMessage = "Incorrect mobile number, example (+38-012-333-45-68)")]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"ID :: {Id}\nLogin :: {Login}\nEmail :: {Email}\nCredit Card :: {CreditCard}\nPhone :: {Phone}";
        }
    }
    [Serializable]
    internal class Program
    {
        static void PrintUsers()
        {
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"U");
            Thread.Sleep(50);
            Console.Write($"s");
            Thread.Sleep(50);
            Console.Write($"e");
            Thread.Sleep(50);
            Console.Write($"r");
            Thread.Sleep(50);
            Console.Write($"s");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.WriteLine();
        }
        static void PrintMenu()
        {
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"R");
            Thread.Sleep(50);
            Console.Write($"e");
            Thread.Sleep(50);
            Console.Write($"g");
            Thread.Sleep(50);
            Console.Write($"i");
            Thread.Sleep(50);
            Console.Write($"s");
            Thread.Sleep(50);
            Console.Write($"t");
            Thread.Sleep(50);
            Console.Write($"r");
            Thread.Sleep(50);
            Console.Write($"a");
            Thread.Sleep(50);
            Console.Write($"t");
            Thread.Sleep(50);
            Console.Write($"i");
            Thread.Sleep(50);
            Console.Write($"o");
            Thread.Sleep(50);
            Console.Write($"n");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.Write($"--");
            Thread.Sleep(50);
            Console.WriteLine();

            Console.WriteLine("1.)Add new user");
            Thread.Sleep(75);
            Console.WriteLine("2.)Read all users");
            Thread.Sleep(75);
            Console.WriteLine("3.)Edit one user");
            Thread.Sleep(75);
            Console.WriteLine("4.)Delete one user");
            Thread.Sleep(75);
            Console.WriteLine("5.)Save to file");
            Thread.Sleep(75);
            Console.WriteLine("6.)Load from file");
            Thread.Sleep(75);
            Console.WriteLine("0.)Exit");
            Thread.Sleep(75);
        }
        static void PrintExit()
        {
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
        static void AddNewUser(Dictionary<int, User> users)
        {
            bool isValid = true;
            User user = new User();
            do
            {
                Console.WriteLine("Enter your login :: ");
                user.Login = Console.ReadLine();

                Console.WriteLine("Enter your email :: ");
                user.Email = Console.ReadLine();

                Console.WriteLine("Enter your password :: ");
                user.Password = Console.ReadLine();

                Console.WriteLine("Enter your confirm password :: ");
                user.ConfirmPassword = Console.ReadLine();

                Console.WriteLine("Enter your credit card :: ");
                user.CreditCard = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your phone :: ");
                user.Phone = Console.ReadLine();
                var result = new List<ValidationResult>();
                var context = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, context, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }

            } while (!isValid);
            user.Id = CreateNewId(users);

            users.Add(user.Id, user);

            Console.WriteLine("User is registered");
        }
        static int CreateNewId(Dictionary<int, User> users)
        {
            Random rnd = new Random();
            int id;
            do
            {
                id = rnd.Next(1000, 9999);
            } while (users.ContainsKey(id));
            return id;
        }

        static void EditUser(Dictionary<int, User> users)
        {
            Console.Write("Enter user id for edit :: ");
            int id = int.Parse(Console.ReadLine());
            User newUser = new User();
            Console.WriteLine("Enter new your login :: ");
            newUser.Login = Console.ReadLine();

            Console.WriteLine("Enter your new email :: ");
            newUser.Email = Console.ReadLine();

            Console.WriteLine("Enter your new password :: ");
            newUser.Password = Console.ReadLine();

            Console.WriteLine("Enter your new confirm password :: ");
            newUser.ConfirmPassword = Console.ReadLine();

            Console.WriteLine("Enter your new credit card :: ");
            newUser.CreditCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your new phone :: ");
            newUser.Phone = Console.ReadLine();

            users[id] = newUser;
            Console.WriteLine("User edited successfully");
        }
        static void DeleteUser(Dictionary<int, User> users)
        {
            Console.Write("Enter user id for delete");
            int id = int.Parse(Console.ReadLine());

            users.Remove(id);
            Console.WriteLine("User deleted successfully");
        }
        static void SaveToFile(Dictionary<int, User> users)
        {
            if (users.Count > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream fs = File.Create("Users.bin"))
                {
                    formatter.Serialize(fs, users);
                }
                Console.WriteLine("Users saved!.");
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
        static void LoadFromFile()
        {
            if (File.Exists("Users.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Dictionary<int, User> loadUsers = null;
                using (Stream fs = File.OpenRead("Users.bin"))
                {
                    loadUsers = (Dictionary<int, User>)formatter.Deserialize(fs);
                }
                foreach (var item in loadUsers)
                {
                    Console.WriteLine($"ID :: {item.Key}");
                    Console.WriteLine($"Login :: {item.Value.Login}");
                    Console.WriteLine($"Password :: {item.Value.Password}");
                    Console.WriteLine($"Confirmed Password :: {item.Value.ConfirmPassword}");
                    Console.WriteLine($"Email :: {item.Value.Email}");
                    Console.WriteLine($"Phone :: {item.Value.Phone}");
                    Console.WriteLine($"Credit Card :: {item.Value.CreditCard}");
                    Console.WriteLine();
                }


                Console.WriteLine("Users loaded!.");
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }

        //Dictionary<int, User> users = new Dictionary<int, User>();
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            int a = new int();


            do
            {
                PrintMenu();
                Console.Write("Choose one action :: ");
                a = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (a)
                {
                    case 1:
                        {
                            AddNewUser(users);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            PrintUsers();
                            foreach (KeyValuePair<int, User> item in users)
                            {
                                Console.WriteLine($"ID :: {item.Key}, Login :: {item.Value.Login}");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            EditUser(users);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            DeleteUser(users);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            SaveToFile(users);
                            Thread.Sleep(500);
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            LoadFromFile();
                            PrintUsers();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (a != 0); PrintExit();

        }
    }
}