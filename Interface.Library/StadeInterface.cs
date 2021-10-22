using System;

namespace Interface.Library
{
    interface IStade
    {
        int X { get; set; }
        int Y { get; set; }
        double Distance { get; }
    }

    public class StadeInterface : IStade
    {
        public StadeInterface(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public double Distance{
            get {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
    }
}