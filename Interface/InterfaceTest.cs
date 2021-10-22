using System;
using Interface.Library;

namespace Interface
{
    public partial class InterfaceTest
    {
        private readonly int a = -1;
        private readonly int b = 1;

        private readonly double c = -1.0d;
        private readonly double d = 1.5d;

        private readonly (int, int) p = (1, -1);
    }

    public partial class InterfaceTest
    {
        public (int, double) TestAdd()
        {
            AntikytheraInterface obj = new AntikytheraInterface();

            int x = obj.Add(a, b);
            double y = obj.Add(c, d);

            return (x, y);
        }
    }

    public partial class InterfaceTest
    {
        public (int, double) TestSub()
        {
            AntikytheraInterface obj = new AntikytheraInterface();

            int x = obj.Sub(a, b);
            double y = obj.Sub(c, d);

            return (x, y);
        }
    }

    public partial class InterfaceTest
    {
        public (int, double) TestDiv()
        {
            AntikytheraInterface obj = new AntikytheraInterface();

            int x = obj.Div(a, b);
            double y = obj.Div(c, d);

            return (x, y);
        }
    }

    public partial class InterfaceTest
    {
        public (int, double) TestMul()
        {
            AntikytheraInterface obj = new AntikytheraInterface();

            int x = obj.Mul(a, b);
            double y = obj.Mul(c, d);

            return (x, y);
        }
    }

    public partial class InterfaceTest
    {
        public double TestDist()
        {
            int x = p.Item1;
            int y = p.Item2;

            StadeInterface obj = new StadeInterface(x, y);

            double distance = obj.Distance;

            return distance;
        }
    }
}