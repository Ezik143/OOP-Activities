using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    public class Activity1
    {
        public static int largestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }
            int largest = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }
            return largest;
        }

        public static int[] ReverseArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }
            int[] reversed = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[numbers.Length - 1 - i];
            }
            return reversed;
        }
    }
}
