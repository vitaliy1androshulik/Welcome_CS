////N1
//using System.Runtime.Intrinsics.Arm;

//Console.WriteLine("It's easy to win forgiveness for being wrong;" +
//    "\nbeing right is what gets you into real trouble." +
//    "\n\t\t\t\tBjarne Stroustrup");



////N2
//Console.WriteLine("Enter first number :: ");
//string numString1= Console.ReadLine();
//int num1 = int.Parse(numString1);

//Console.WriteLine("Enter second number :: ");
//string numString2 = Console.ReadLine();
//int num2 = int.Parse(numString2);

//Console.WriteLine("Enter third number :: ");
//string numString3 = Console.ReadLine();
//int num3 = int.Parse(numString3);

//Console.WriteLine("Enter fourth number :: ");
//string numString4 = Console.ReadLine();
//int num4 = int.Parse(numString4);

//Console.WriteLine("Enter fifth number :: ");
//string numString5 = Console.ReadLine();
//int num5 = int.Parse(numString5);

//Console.WriteLine($"\nSum of numbers = { num1+num2+num3+num4+num5}\n");

//if(num1>num2&&num1>num3&&num1>num4&&num1>num5)
//{
//    Console.WriteLine(num1 + " number 1 is the largest");
//}
//else if(num1 < num2 && num2 > num3 && num2 > num4 && num2 > num5)
//{
//    Console.WriteLine(num2 + " number 2 is the largest");
//}
//else if (num1 < num3 && num2 < num3 && num3 > num4 && num3 > num5)
//{
//    Console.WriteLine(num3 + " number 3 is the largest");
//}
//else if (num1 < num4 && num4 > num3 && num4 > num2 && num4 > num5)
//{
//    Console.WriteLine(num4 + " number 4 is the largest");
//}
//else if (num1 < num5 && num5 > num3 && num5 > num2 && num4 < num5)
//{
//    Console.WriteLine(num5 + " number 5 is the largest");
//}

//if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
//{
//    Console.WriteLine(num1 + " number 1 is the smallest");
//}
//else if (num1 > num2 && num2 < num3 && num2 < num4 && num2 < num5)
//{
//    Console.WriteLine(num2 + " number 2 is the smallest");
//}
//else if (num1 > num3 && num2 > num3 && num3 < num4 && num3 < num5)
//{
//    Console.WriteLine(num3 + " number 3 is the smallest");
//}
//else if (num1 > num4 && num4 < num3 && num4 < num2 && num4 < num5)
//{
//    Console.WriteLine(num4 + " number 4 is the smallest");
//}
//else if (num1 > num5 && num5 < num3 && num5 < num2 && num4 < num5)
//{
//    Console.WriteLine(num5 + " number 5 is the smallest");
//}

//Console.WriteLine($"\nProduct of all numbers = {num1*num2*num3*num4*num5} ");



////N3
//Console.WriteLine("Enter number :: ");
//string numbe = Console.ReadLine();
//int number = int.Parse(numbe);
//int rem = 0;
//int reverse = 0; ;
//while (number != 0)
//{
//    rem = number % 10;
//    reverse = reverse * 10 + rem;
//    number /= 10;
//}
//Console.WriteLine("Your reversed number is :: " + reverse);


////N4
//Console.WriteLine("Enter start number :: ");
//int start = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter last number :: ");
//int last = int.Parse(Console.ReadLine());

//int a = 0, b = 1;
//int numb = a + b;

//while (numb <= last)
//{
//    if (numb >= start)
//    {
//        Console.Write(numb + " ");
//    }
//    a = b;
//    b = numb;
//    numb = a + b;
//}
//Console.WriteLine();


//N5
//Console.WriteLine("Enter first number :: ");
//int first = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number :: ");
//int second = int.Parse(Console.ReadLine());

//if(first<second)
//{
//    for (int i = first; i <=second; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}


//N6
using System.Text;

Console.Write("Enter line length :: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Enter direction (H - horizontal, V - vertical) :: ");
string direction = Console.ReadLine();
if (direction == "H" || direction == "h")
{
    for (int i = 0; i <= length; i++)
    {
        Console.WriteLine("*");
    }
}
else if (direction == "V" || direction == "v")
{
    for (int i = 0; i <= length; i++)
    {
        Console.Write("*");
    }
}






