using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOfDay = 1;
            //Console.WriteLine(numberOfDay);
            //int firstNumber = 1;
            //int secondNumber = 2;

            //for (int indexer = 0; indexer < 3; indexer++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("*\t");
            //    }
            //    Console.WriteLine();
            //}

            //int counter = 0;

            //for (counter = 0; counter < 5; counter++)
            //{
            //    Console.WriteLine(counter);
            //}
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //foreach (char c in vowels)
            //{
            //    Console.WriteLine(c);
            //}
            {
                // Input two numbers
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nBefore swapping:");
                Console.WriteLine($"First number: {num1}, Second number: {num2}");

                // Swapping logic
                int temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("\nAfter swapping:");
                Console.WriteLine($"First number: {num1}, Second number: {num2}");
            }

        }

    }
}
