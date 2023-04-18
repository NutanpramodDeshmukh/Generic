using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_minimum
{
    internal class TestMinimum<T> where T : IComparable
    {
        public static int IntMinimum(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;

        }
        public static float FloatMinimum(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;

        }
        public static string StringMinimum(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;

        }
        public T Maximum(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
