using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writes project #
            Console.WriteLine("Project 9");
            //asks for the size of the array
            Console.WriteLine("Please input the number for the desired array size");
            //declares array size and convert the inputted number to its value
            int arraySize = Convert.ToInt32(Console.ReadLine());
            //declares the array and sets its size
            int[] numbers = new int[arraySize];
            // declares the value that will be used to store the sum
            int sum = 0;

            //creates a loop that ask for a number, increases the sum, and keeps track of how many rounds it still needs to loop
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            //writes a line that tells the sum
            Console.WriteLine($"The sum of your inputted array is {sum}");

            //sorts the array by ascending order
            Array.Sort(numbers);

            // writes a line introducing your array
            Console.WriteLine("Your Array:");
            //creates a loop that writes each of element of the array
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}