using System;

namespace Interface.Library
{
    interface IAntikythera
    {
        int Add(int x, int y);
        double Add(double x, double y);

        int Sub(int x, int y);
        double Sub(double x, double y);

        int Div(int x, int y);
        double Div(double x, double y);

        int Mul(int x, int y);
        double Mul(double x, double y);
    }

    public partial class AntikytheraInterface : IAntikythera
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }
        public double Add(double x, double y)
        {
            return (x + y);
        }
    }

    public partial class AntikytheraInterface : IAntikythera
    {
        public int Sub(int x, int y)
        {
            return (x - y);
        }
        public double Sub(double x, double y)
        {
            return (x - y);
        }
    }

    public partial class AntikytheraInterface : IAntikythera
    {
        public int Div(int x, int y)
        {
            return (x / y);
        }
        public double Div(double x, double y)
        {
            return (x / y);
        }
    }

    public partial class AntikytheraInterface : IAntikythera
    {
        public int Mul(int x, int y)
        {
            return (x * y);
        }
        public double Mul(double x, double y)
        {
            return (x * y);
        }
    }
}
