namespace _19_Delegation

{
    //class MyDelegate : MulticastDelegate
    //{

    //}

    public delegate void SetStringDelegate(string str);
    public delegate double GetDoubleDelegate();
    public delegate void VoidDelegate();

    public class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine("String "+str);
        }
        public static double GetCoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("Doing work.....");
        }
        public void Test()
        {
            Console.WriteLine("Testing.....");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //GetDoubleDelegate method = new GetDoubleDelegate(SuperClass.GetCoef);
            GetDoubleDelegate method =SuperClass.GetCoef;
            //Console.WriteLine(method());
            Console.WriteLine(method?.Invoke()); // символ ? - не нулл

            SuperClass super = new SuperClass();
            GetDoubleDelegate[] arr = new GetDoubleDelegate[]
            {
                SuperClass.GetCoef,
                new GetDoubleDelegate(super.GetNumber)
            };
            Console.WriteLine(arr[0].Invoke());
            Console.WriteLine(arr[1].Invoke());

            SetStringDelegate stringDelegate = new SetStringDelegate(super.Print);

            VoidDelegate voidDelegate = new VoidDelegate(super.DoWork);

            stringDelegate.Invoke("Hello friends!!");
            voidDelegate.Invoke();

            //Delegate.Combine(voidDelegate, new VoidDelegate(super.Test));
            //Delegate.Combine(voidDelegate, super.Test);
            Console.WriteLine("----------------------");
            voidDelegate += new VoidDelegate(super.Test);

            foreach (var item in voidDelegate.GetInvocationList())
            {
                (item as VoidDelegate).Invoke(); // as - типу перетворення
            }
        }
    }
}