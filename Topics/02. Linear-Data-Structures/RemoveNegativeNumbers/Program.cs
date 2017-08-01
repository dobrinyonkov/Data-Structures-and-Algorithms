using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeNumbers
{
    class Program
    {
        private const int ListLength = 50;
        private const int MinRange = -100;
        private const int MaxRange = 100;
        private static readonly Random Generator = new Random();

        static void Main(string[] args)
        {
            //Write a program that removes from given sequence all negative numbers.

            List<int> numbers = new List<int>();

            while (ListLength > numbers.Count)
            {
                int randomNumber = Generator.Next(MinRange, MaxRange);
                numbers.Add(randomNumber);
            }

            IList<int> result = RemoveNegatives(numbers);
            Console.WriteLine(string.Join(" ", result));

        }

        private static IList<int> RemoveNegatives(IList<int> numbers)
        {
            IList<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}
