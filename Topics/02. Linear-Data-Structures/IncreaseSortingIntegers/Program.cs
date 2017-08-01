using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseSortingIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of integers(List<int>) 
            //ending with an empty line and sorts them in an increasing order.

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
                else if (input != string.Empty)
                {
                    Console.WriteLine("invalid number");
                }
            }

            numbers.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine(string.Join(", ", numbers));
            
        }
    }
}
