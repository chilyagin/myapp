using System;
using myapp.CalcTest;

namespace myapp.hw
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 22;
            Console.WriteLine("x + y = {0}", Calc.Sum(x, y));

        }
    }
}
