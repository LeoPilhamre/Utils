using System;

namespace Interface
{
    public class WriteTests
    {
        private readonly InterfaceTest Tests;

        public WriteTests()
        {
            Tests = new InterfaceTest();

            WriteReverse();
            WriteCharAt();
            WriteAdd();
            WriteSub();
            WriteDiv();
            WriteMul();
            WriteDist();
        }

        private void Write(object x, object y){
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
        }

        private void WriteReverse()
        {
            string r = Tests.TestReverse();

            Console.WriteLine("Reversed: ");
            Console.WriteLine(r);
        }

        private void WriteCharAt()
        {
            char c = Tests.TestCharAt();

            Console.WriteLine("Char at 0: ");
            Console.WriteLine(c);
        }

        private void WriteAdd()
        {
            int x = Tests.TestAdd().Item1;
            double y = Tests.TestAdd().Item2;

            Console.WriteLine("Addition: ");
            Write(x, y);
        }

        private void WriteSub()
        {
            int x = Tests.TestSub().Item1;
            double y = Tests.TestSub().Item2;

            Console.WriteLine("Subtraction: ");
            Write(x, y);
        }

        private void WriteDiv()
        {
            int x = Tests.TestDiv().Item1;
            double y = Tests.TestDiv().Item2;

            Console.WriteLine("Division: ");
            Write(x, y);
        }

        private void WriteMul()
        {
            int x = Tests.TestMul().Item1;
            double y = Tests.TestMul().Item2;

            Console.WriteLine("Multiplication: ");
            Write(x, y);
        }

        private void WriteDist()
        {
            double distance = Tests.TestDist();

            Console.WriteLine("Distance: ");
            Console.WriteLine(distance.ToString());
        }
    }
}