using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    public class Activity3
    {
        public static string stringReversed(string original)
        {
            if (original == null)
            {
                throw new ArgumentNullException("Cannot be empty");
            }
            char[] temp = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                temp[i] = original[original.Length - 1 - i];
            }
            return new string(temp);
        }
    }
}
