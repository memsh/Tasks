using System.Linq;
using UnityEngine;
namespace Task29
{

    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static string RepeatString(this string str, int times)
        {
            return string.Concat(Enumerable.Repeat(str, times));
        }
    }
}
