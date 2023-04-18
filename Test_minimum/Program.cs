using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMinimum<int> _Minimum = new TestMinimum<int>();
            Console.WriteLine($"Maximum = {_Minimum.Minimum(4, 7, 9)}");
            Console.ReadKey();
        }
    }
}
