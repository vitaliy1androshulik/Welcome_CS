using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace _24_GenericHomeWork
{
    class MyStack<T>
   {
       private int top;
       private T[] arr;
       private int size;
       public MyStack()
       {
           top = -1;
           arr = new T[1];
           size = 0;
       }
    
       public void Push(T item)
       {
            if (top == arr.Length - 1)
            {
                Array.Resize(ref arr, arr.Length +1);
            }
            size++;
            top++;
            arr[top] = item;
        }
        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = arr[top];
            top--;
            size--;
            return item;
        }
        public bool IsEmpty()
       {
           return top == 0;
       }
       public int GetSize()
       {
           return size;
       }
       public T Peek()
       {
           if(!IsEmpty())
           {
               return arr[top];
           }
           else
           {
               T msg;
               string a = "Stack is empty";
               msg = (dynamic)a;
               return msg;
           }
       }
       public int Count()
       {
            return size + 1 ;
       }

       public void Print()
       {
           for (int i = 0; i < arr.Length; i++)
           {
                if ((dynamic)arr[i] != null)
                {
                    Console.Write($"{arr[i]} ");
                }
           }
           Console.WriteLine();
        }
   }
    class MyQueue<T>
    {
        private T[] arr;
        private int size;
        private int top;
        public MyQueue(int size)
        {
            this.size = size;
            arr = new T[size];
            top = 0;
        }
        public bool IsFull()
        {
            return top == size;
        }
        public bool IsEmpty()
        {
            return top == 0;
        }
        public void Enqueue(T elem)
        {
            if (!IsFull())
            {
                arr[top++] = elem;
            }
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            return arr[top - 1];
        }
        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T first = arr[0];
                for (int i = 0; i < top; i++)
                {
                    arr[i] = arr[i + 1];
                }
                top--;
                return first;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
        public int GetCount()
        {
            return top;
        }
        public void Clear()
        {
            top = 0;
        }
        public void Print()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            static T MaxOfNumbers<T>(params T[] values)
            {
                return values.Max();
            }
            static T MinOfNumbers<T>(params T[] values) 
            {
                return values.Min();
            }
            static T SumOfNumInArr<T>(T [] values)
            {
                dynamic res = default(T);
                for (int i = 0; i < values.Length; i++)
                {
                    res += values[i];
                }
                return res;
            }


            int maxInt = MaxOfNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine($"Max of int numbers :: {maxInt}");
            double maxDoub = MaxOfNumbers(1.2, 2.3, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.4,9.5);
            Console.WriteLine($"Max of double numbers :: {maxDoub}");

            Console.WriteLine();
            int minInt = MinOfNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine($"Min of numbers :: {minInt}");
            double minDoub = MinOfNumbers(1.2, 2.3, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.4, 9.5);
            Console.WriteLine($"Min of double numbers :: {minDoub}");

            Console.WriteLine();
            int[] arrInt = { 1, 2, 3, 4,5,6,7,8};
            double[] arrDoub = { 1.2, 2.3, 3.4, 4.5,5.6,6.7,7.8,8.8};
            Console.WriteLine($"Sum of int numbers :: {SumOfNumInArr(arrInt)}");
            Console.WriteLine($"Sum of double numbers :: {SumOfNumInArr(arrDoub)}");



            //Stack
            //try
            //{
            //    MyStack<int> stack = new MyStack<int>();
            //    stack.Push(1);
            //    stack.Push(2);
            //    stack.Push(3);
            //    stack.Push(4);
            //    stack.Push(5);
            //    stack.Push(6);
            //    Console.WriteLine();
            //    stack.Print();
            //    stack.Pop();
            //    Console.WriteLine();
            //    //stack.Print();
            //    Console.WriteLine(stack.Pop());
            //    Console.WriteLine(stack.Pop()); 
            //    Console.WriteLine(stack.Pop()); 
            //    Console.WriteLine(stack.Pop()); 
            //    int size = stack.Count();
            //    Console.WriteLine($"Stack count :: {size}");
            //}
            //catch (InvalidOperationException ex ) 
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Queue
            try
            {
                MyQueue<string> qu = new MyQueue<string>(5);
                qu.Enqueue("Privit");
                qu.Enqueue("Paka");
                qu.Enqueue("world");
                qu.Enqueue("Groshi");
                qu.Print();
                Console.WriteLine(qu.GetCount());
                qu.Dequeue();
                qu.Dequeue();
                qu.Print();
                Console.WriteLine(qu.Peek());
            }
            catch  (InvalidOperationException ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}