using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    public class Activity4
    {
        public static int wordCount(string word)
        {
            if(word == null)
            {
                throw new ArgumentException("Cannot be null");
            }
            
            string[] output = word.Split(' ');

            return output.Length;
        }
    }
}
