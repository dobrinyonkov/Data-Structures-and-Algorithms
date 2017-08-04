using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurrencesOfValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            IDictionary<double, int> numsCount = new SortedDictionary<double, int>();
            CountNumbers(numbers, numsCount);

        }

        private static void CountNumbers(double[] numbers, IDictionary<double, int> numsCount)
        {
            foreach (var number in numbers)
            {
                int count = 1;
                if (numsCount.ContainsKey(number))
                {
                    count = numsCount[number] + 1;
                }
                numsCount[number] = count;
            }
            foreach (var pair in numsCount)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
