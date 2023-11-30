using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPHomeWork
{
    public partial class FreezerNew
    {
        private static string model;
        private static int count;

        static FreezerNew()
        {
            model = "Lg";
            count = 0;
        }


        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
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
            set
            {
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
            set
            {
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

        public FreezerNew()
        {
            this.height = 0;
            this.width = 0;
            this.minT = 0;
            this.maxT = 0;
            this.volume = 0;
        }

        public FreezerNew(int Height, int Width) { this.height = Height; this.width = Width; }
        public FreezerNew(int Height, int Width, int Volume) { this.height = Height; this.width = Width; this.volume = Volume; }
        public FreezerNew(int Height, int Width, int MaxT, int MinT, int Volume) { this.height = Height; this.width = Width; this.volume = Volume; this.maxT = MaxT; this.minT = MinT; }


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
}
