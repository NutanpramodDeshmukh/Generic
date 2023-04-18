using System;
using System.Collections.Generic;
using System.Text;



namespace minimum_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"Minimum number = {Test_minimum.IntMinimum(5, 9, 8)}");
            Console.WriteLine($"Minimum number = {Test_minimum.FloatMinimum(0.5f, 0.9f, 0.8f)}");
            Console.WriteLine($"Maximum String = {Test_minimum.StringMinimum("A", "b", "C")}");
            Console.ReadKey();
        }
    }
}
