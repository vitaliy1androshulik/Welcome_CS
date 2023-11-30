//N1
//Console.WriteLine("Enter 10 numbers :: ");
//int[] arr = new int[10];
//for (int i = 0;i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0;i < arr.Length; i++)
//{
//    if (arr[i]%2==0)
//    {
//        Console.WriteLine("The number is even :: "+ arr[i]);
//    }
//    else
//    {
//        Console.WriteLine("The number is not even :: "+arr[i]);
//    }
//}

//N2
//Console.Write("Enter number :: ");
//int n=int.Parse(Console.ReadLine());
//int[]arr = new int[5] { 2, 6, 1, 7, 8 };
//for(int i=0; i<arr.Length;i++)
//{
//    if (arr[i]<n)
//    {
//        Console.WriteLine("Your number > " + arr[i]);
//    }
//    else if (arr[i]>n)
//    {
//        Console.WriteLine("Your number < " + arr[i]);
//    }
//}

//N3
//int[] A = new int[5];
//int row = 3;
//int col= 4;
//float[,] B = new float[row, col];
//Random random = new Random();
//int num1 = random.Next(0,1234);
//Console.Write("Enter number for array A :: ");
//for (int i = 0; i < A.Length; i++)
//{
//    A[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        float num = (float)(random.NextDouble()*num1);
//        B[i, j] = num;
//    }
//}
//Console.Write("It`s A array :: ");
//for (int i = 0; i < A.Length; i++)
//{
//    Console.Write(A[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine("It`s B array :: ");
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        Console.Write(B[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Your max number in A array :: " + A.Max());
//Console.WriteLine("Your min number in A array :: "+ A.Min());
//float max = B[0, 0];
//float min = B[0, 0];
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        if (B[i,j] >= max)
//        {
//            max = B[i, j];
//        }
//    }
//}
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        if (B[i, j] <= min)
//        {
//            min = B[i, j];
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine("Your max number in B array :: "+max) ;
//Console.WriteLine("Your min number in B array :: " + min) ;

//int sumA = 0;
//float sumB = 0;
//for (int i = 0; i < A.Length; i++)
//{
//    sumA= sumA + A[i];
//}
//Console.WriteLine();
//Console.WriteLine("Sum of all elements A array :: " + sumA);
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        sumB = sumB + B[i, j];
//    }
//}
//Console.WriteLine("Sum of all elements B array :: " + sumB);
//Console.WriteLine();

//int productA = 1;
//float productB = 1;

//for (int i = 0; i < A.Length; i++)
//{
//    if (A[i] % 2 == 0)
//    {
//        productA = productA * A[i];
//    }
//}


//for(int i = 0;i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        if (B[i, j] % 2 == 0)
//        {
//            productB= productB * B[i, j];
//        }
//    }
//}

//Console.WriteLine("Prouct of even numbers in A array :: " + productA);
//if (productB == 1)
//{
//    Console.WriteLine("Array B don`t have even numbers");
//}
//else
//{
//Console.WriteLine("Prouct of even numbers in B array :: " + productB);
//}

//int evenSumA = 0;
//float rowNotEvenSumB = 0;
//for (int i = 0; i < A.Length; i++)
//{
//    if (A[i]%2==0)
//    {
//        evenSumA = evenSumA + A[i];
//    }
//}

//for (int i = 0; i < row; i++)
//{
//    if (B[i, i] %2 == 0) 
//    { 
//        //it`s even
//    }
//    else
//    {
//        rowNotEvenSumB = rowNotEvenSumB + B[i,i];
//    }
//}

//Console.WriteLine("Sum of even elements in A array :: " + evenSumA);
//Console.WriteLine("Sum of not even row elements in B array :: " + rowNotEvenSumB);



//N4
//Random random = new Random();
//int[,] A = new int[5, 5];
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        A[i, j] = random.Next(-100, 100);
//    }
//}
//Console.WriteLine("It`s your array :: ");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(A[i, j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int sum = 0;

//int max = A[0, 0];
//int min = A[0, 0];

//int maxRow = 0;
//int minRow = 0;
//int maxCol = 0;
//int minCol = 0;
//for (int i = 0; i < 5; i++)
//{
//    for(int j = 0;j < 5; j++)
//    {

//        if (A[i, j] > max) 
//        { 
//            max = A[i, j];
//            maxRow= i;
//            maxCol= j;
//        }
//        if (A[i, j] < min)
//        {
//            min = A[i, j];
//            minRow = i;
//            minCol= j;
//        }
//    }
//}
//int startNumberRow = (minRow < maxRow) ? minRow : maxRow; 
//int endNumberRow = (minRow < maxRow) ? maxRow : minRow; 
//int startNumberCol = (minCol < maxCol) ? minCol  : maxCol; 
//int endNumberCol = (minCol < maxCol) ? maxCol : minCol; 
//for (int i = startNumberRow; i <= endNumberRow; i++)
//{
//    for (int j = startNumberCol; j <= endNumberCol; j++)
//    {
//        sum += A[i, j];
//    }
//}
//Console.WriteLine("Sum of number :: "+sum);

//N5
int[] arr = new int [10];
Console.Write("Enter numbers for your array :: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] - min == 5)
    {
        count++;
    }
}
Console.WriteLine("Еhe number of numbers that differ by 5 :: "+count);