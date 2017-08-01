using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads N integers from the console and reverses them using a stack.
            //Use the Stack < int > class.

            Console.WriteLine("Count of nummbers:");
            int size = 0;
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid Number");
                return;
            }


            Stack<int> numbers = new Stack<int>();

            int current;
            string input = " ";

            for (int i = 0; i < size; i++)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out current))
                {
                    numbers.Push(current);
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            Console.WriteLine("Reversed numbers: {0}", string.Join(", ", numbers));
        }
    }
}
