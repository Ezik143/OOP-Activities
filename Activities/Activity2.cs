using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    public class Activity2
    {
        public static int linearSearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1; 
        }
    }
}
