namespace _20_DelegationHomeWork
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 3, -2, 5, -8, 7, 0, 1, 4, -6 };

            Action<int[]>[] operationMethods = {
            CalculateNegativeCount,
            CalculateSum,
            CalculatePrimeCount,
            SetNegativesToZero,
            SortArray,
            MoveEvenToFront
        };

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Calculate the number of negative elements");
            Console.WriteLine("2. Calculate the sum of all elements");
            Console.WriteLine("3. Calculate the count of prime numbers");
            Console.WriteLine("4. Set all negative elements to 0");
            Console.WriteLine("5. Sort the array");
            Console.WriteLine("6. Move all even elements to the front");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= operationMethods.Length)
            {
                operationMethods[choice - 1](array);
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    Console.WriteLine($"Operation result: {array[0]}");
                }
                else
                {
                    Console.WriteLine("The array has been modified:");
                    foreach (var element in array)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid operation choice.");
            }
        }
        static void CalculateNegativeCount(int[] array)
        {
            array[0] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[0]++;
                }
            }
        }

        static void CalculateSum(int[] array)
        {
            array[0] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[0] += array[i];
            }
        }

        static void CalculatePrimeCount(int[] array)
        {
            array[0] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]))
                {
                    array[0]++;
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void SetNegativesToZero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }
        }

        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        static void MoveEvenToFront(int[] array)
        {
            Array.Sort(array, (a, b) => (a % 2 == 0 && b % 2 != 0) ? -1 : 1);
        }
    }
}