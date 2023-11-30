namespace _8_OOPHomeWork
{
    public partial class Freezer
    {
        private static string model;
        private static int count;

        static Freezer()
        {
            model = "Lg";
            count = 0;
        }


        private int height;
        public int Height
        {
            get { return height; }
            set {
                if (value>=0)
                {
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }
        private int width;
        public int Width
        {
            get { return width; }
            set {
                if (value >= 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }
        private int maxT;
        public int MaxT
        {
            get { return maxT; }
            set {
                if (value >= -5)
                {
                    maxT = value;
                }
                else
                {
                    maxT = value;
                }
            }
        }
        private int minT;
        public int MinT
        {
            get { return minT; }
            set
            {
                if (value <= -10)
                {
                    minT = value;
                }
                else
                {
                    minT = value;
                }
            }
        }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (volume < 0)
                {
                    Console.WriteLine("Error volume.Enter volume > 0");
                }
                else
                {
                    volume = value;
                }
            }
        }

        public Freezer()
        {
            this.height = 0;
            this.width = 0;
            this.minT = 0;
            this.maxT = 0;
            this.volume = 0;
        }

        public Freezer(int Height, int Width){ this.height = Height; this.width = Width; }
        public Freezer(int Height, int Width, int Volume){ this.height = Height; this.width = Width; this.volume = Volume; }
        public Freezer(int Height, int Width, int MaxT, int MinT, int Volume) { this.height = Height; this.width = Width; this.volume = Volume; this.maxT = MaxT; this.minT = MinT; }


        public void EditHeightAndWidth(ref int Height, ref int Width)
        {
            this.height = Height;
            this.width = Width;
            Console.WriteLine("\n\nEdited!");
        }

        public void EditVolume(ref int Volume)
        {
            this.volume = Volume;
             Console.WriteLine("\n\nEdited!");
        }
        public void Print()
        {
            Console.WriteLine($"---------------Freezer---------------");
            Console.WriteLine($"Model :: {model}");
            Console.WriteLine($"Height :: {height} sm.");
            Console.WriteLine($"Width :: {width} sm.");
            Console.WriteLine($"Max. temperature :: {maxT} °C");
            Console.WriteLine($"Min. temperature :: {minT} °C");
            Console.WriteLine($"Volume :: {volume} l.");
        }

        public override string ToString()
        {
            return $"Model :: {model}\nHeight :: {height}\nWidth :: {width}\nMinT :: {minT}\nMaxT :: {maxT}\nVolume :: {volume}";
        }

    }



    internal class Program
    {
        
        static void Main(string[] args)
        {
            Freezer[] freezer = new Freezer[5];
            for (int i = 0; i < freezer.Length; i++)
            {
                freezer[i] = new Freezer(120 + i * 2, 75 - i * 2, 0 + i, 7 + i,150);
                freezer[i].Print();
            }
            Console.WriteLine();
            Console.WriteLine();
            int h = 220, w = 90;
            int v = 300;
            freezer[2].Print();
            freezer[2].EditHeightAndWidth(ref h,ref w);
            freezer[2].Print();
            freezer[2].EditVolume(ref v);
            freezer[2].Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Print partial class ::") ;
            FreezerNew freezer1 = new FreezerNew();
            freezer1.Print();
        }
    }
}