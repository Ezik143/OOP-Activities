using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Activities;

namespace activity1tO4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Activity 1: Largest Number and Reverse Array
            int[] numbers = { 1, 2, 3, 4, 5};
            int Largest = Activity1.largestNumber(numbers);
            Console.WriteLine("Largest number: " + Largest);
            int[] reversedArray = Activity1.ReverseArray(numbers);
            Console.WriteLine("Reversed array: " + string.Join(", ", reversedArray));

            //Activity 2: Linear Search Task
            int target = 3;
            Console.WriteLine($"Target {target} found at index: {Activity2.linearSearch(numbers, target)}");
            //No found
            target = 6;
            target = 6; 
            Console.WriteLine($"Target {target} found at index:{Activity2.linearSearch(numbers, target)}");

            //Activity 3: String reversal
            string inputString = "Hello, World!";
            Console.WriteLine($"original {inputString}");
            Console.WriteLine($"reversed {Activity3.stringReversed(inputString)}");

            //Activity 4: String split and count
            string sentence = "This is a sample sentence for Activity 4";
            Console.WriteLine($"Sentence: {sentence}");
            int count = Activity4.wordCount(sentence);
            Console.WriteLine($"word counts: {count}");
        }
    }
}
