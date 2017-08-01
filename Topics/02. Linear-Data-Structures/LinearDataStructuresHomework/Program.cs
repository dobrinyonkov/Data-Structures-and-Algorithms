using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinearDataStructuresHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of positive integer numbers.
            //The sequence ends when empty line is entered.
            //Calculate and print the sum and average of the elements of the sequence.
            //Keep the sequence in List<int>.

            string input = " ";

            long sum = 0;
            int current = 0;

            List<int> numbers = new List<int>();

            while (input != string.Empty)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out current))
                {
                    sum += current;
                    numbers.Add(current);
                }
                else if (input == string.Empty)
                {
                    Console.WriteLine("Invalid Number");
                    
                }

                double averge = (double)sum / (numbers.Count == 0 ? 1 : numbers.Count);
                Console.WriteLine(sum);
                Console.WriteLine(averge);
            }
        }
    }
}
