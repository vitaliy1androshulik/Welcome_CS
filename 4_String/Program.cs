using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

string name = "Ivan";//operator =
string name1 = new string("Ivan");
string lastname;
lastname = "Ivanenko";

string fullname = name + " " + lastname;

Console.WriteLine($"Fullname :: { fullname}");

char[] letters = { 'h', 'e', 'l', 'l', 'o' };
Console.WriteLine($"Length letters :: {letters.Length}" );

string greeting = new string(letters, 1,3);
Console.WriteLine($"Greeting :: {greeting}");//інтерполяція

Console.WriteLine("Greeting {0}{1}", greeting," World");

string[] sarr = { "Hello", "Car", "Shop", "Forum"};

string message = string.Join(" - ", sarr);
Console.WriteLine($"Message :: {message}");

//string[] splitedArr=message.Split(new string[] {" - ", " . "}, StringSplitOptions.None);
string[] splitedArr=message.Split(new char[] { ' ', '.', ',', '-', '(', ')', '!', '?', '$' },StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Length letters :: {letters.Length}" );
foreach (var item in splitedArr)
{
    Console.WriteLine(item);
}
Console.OutputEncoding = Encoding.UTF8;
DateTime dateNow= DateTime.Now;
Console.WriteLine(dateNow);
Console.WriteLine(dateNow.ToString());
Console.WriteLine(dateNow.ToLongDateString());
Console.WriteLine(dateNow.ToShortDateString());
Console.WriteLine(dateNow.ToLongTimeString());
Console.WriteLine(dateNow.ToShortTimeString());
Console.WriteLine(dateNow.ToString("yy.mm.dd"));

DateTime dateEvent = dateNow;
dateEvent= dateEvent.AddDays(7);
dateEvent= dateEvent.AddHours(1.5);

TimeSpan timeSpan = dateEvent-dateNow;

Console.WriteLine($"Time span {timeSpan.ToString()}");
Console.WriteLine($"Milliseconds {timeSpan.Milliseconds}");
Console.WriteLine($"Time Seconds {timeSpan.Seconds}");
Console.WriteLine($"Time Minutes {timeSpan.Minutes}"); 
Console.WriteLine($"Time hours {timeSpan.Hours}"); 
Console.WriteLine($"Time days {timeSpan.Days}");

Console.WriteLine($"Time span {timeSpan.ToString()}");
Console.WriteLine($"Milliseconds {timeSpan.TotalMilliseconds}");
Console.WriteLine($"Time Seconds {timeSpan.TotalSeconds}");
Console.WriteLine($"Time Minutes {timeSpan.TotalMinutes}");
Console.WriteLine($"Time hours {timeSpan.TotalHours}");
Console.WriteLine($"Time days {timeSpan.TotalDays}");

decimal money = 38.6m;

CultureInfo us = new CultureInfo ( "en-US" );

string course = $"Today course of dollar is : {money.ToString("C2",us)}";

Console.WriteLine(course );

string nullStr = null;
if(nullStr!=null)
{
    nullStr.ToString();
}

nullStr?.ToString();

string strEmpty = "";

if (string.IsNullOrEmpty(nullStr) && string.IsNullOrEmpty(strEmpty))
{
    Console.WriteLine("Is null or empty");
}
string str = "    ";
Console.WriteLine(str.Length);

