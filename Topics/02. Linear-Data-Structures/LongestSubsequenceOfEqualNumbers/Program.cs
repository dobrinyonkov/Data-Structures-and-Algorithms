using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubsequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that finds the longest subsequence of 
            //equal numbers in given List and returns the result as new List<int>.

            Console.WriteLine("Fill the list");
            string input = " ";
            int current = 0;
            List<int> numbers = new List<int>();

            while (input != string.Empty)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out current))
                {
                    numbers.Add(current);
                }
            }

            int startIndex = 0;
            int endIndex = 0;
            int counter = 1;
            int maxLength = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                    if (counter > maxLength)
                    {
                        maxLength = counter;
                        endIndex = i + 1;
                    }   
                }
                else
                {
                    counter = 1;
                }
            }

            startIndex = endIndex - (maxLength - 1);
            List<int> result = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
