using System.Threading.Tasks.Sources;

namespace _16_InterfacesHomeWork
{
    interface IOutput
    {
        void Show();
        void ShowInfo(string info);
    }

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    class Array : IOutput, IMath
    {
        int[] arr = new int[5] {2,3,5,1,4};
        public void Show()
        {
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }
        public void ShowInfo(string info) 
        {
            int a = int.Parse(info);
            for (int i = 0; i < arr.Length; i++)
            {

                if (a == arr[i])
                {
                    Console.WriteLine(arr[i]+" in index :: "+i);
                }
            }
        }
        public void Print()
        {
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }
        public int Max()
        {
            int Max=arr[0];
            Max = arr.Max();
            return Max;
        }
        public int Min()
        {
            int Min = arr[0];
            Min = arr.Min();
            return Min;
        }
        public float Avg()
        {
            float avg = 0;
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum+= arr[i];
            }
            avg = sum/arr.Length;
            return avg;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(valueToSearch == arr[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public void SortDesc()
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByParam(bool isAsc)
        {
            if(isAsc == true)
            {
                SortAsc();
            }
            else if(isAsc == false)
            {
                SortDesc();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            //Array arr = new Array();
            //arr.Show();
            //Console.WriteLine();
            //arr.ShowInfo("from");


            //N2
            //Array arr = new Array();
            //arr.Print();
            //Console.WriteLine();
            //Console.WriteLine($"Max value :: {arr.Max()}");
            //Console.WriteLine($"Min value :: {arr.Min()}");
            //Console.WriteLine($"Avg value :: {arr.Avg()}");
            //Console.WriteLine($"Searched value ::b {arr.Search(6)}");


            //N3
            Array arr1 = new Array();
            Array arr2 = new Array();
            Array arr3 = new Array();
            Console.Write("Unsorted array :: "); arr1.Print();
            arr1.SortAsc();
            Console.WriteLine();
            Console.Write("Sorted array :: ");
            arr1.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Unsorted array :: "); arr2.Print();
            arr2.SortDesc();
            Console.WriteLine();
            Console.Write("Sorted array :: ");
            arr2.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Unsorted array :: "); arr3.Print();
            arr3.SortByParam(false);
            Console.WriteLine();
            Console.Write("Sorted array :: ");
            arr3.Print();
        }
    }
}