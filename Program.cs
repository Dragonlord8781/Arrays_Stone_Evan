using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project 9");
            Console.WriteLine("Please input the number for the desired array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of your inputted array is {sum}");

            Array.Sort(numbers);

            Console.WriteLine("Your Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}