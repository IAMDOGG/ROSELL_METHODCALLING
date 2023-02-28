using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSELL_methodcalling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];

            // Get user input for numbers array
            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            // Call methods to perform calculations and display results
            Console.WriteLine($"Average: {Average(numbers)}");
            Console.WriteLine($"Minimum: {Min(numbers)}");
            Console.WriteLine($"Maximum: {Max(numbers)}");
            Console.WriteLine($"Median: {Median(numbers)}");
            display(numbers);
        }

        static double Average(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        static double Min(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static double Max(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static double Median(double[] numbers)
        {
            // Sort the array in ascending order
            Array.Sort(numbers);

            if (numbers.Length % 2 == 0)
            {
                // If array has even number of elements, average middle two elements
                int midIndex = numbers.Length / 2;
                return (numbers[midIndex - 1] + numbers[midIndex]) / 2;
            }
            else
            {
                // If array has odd number of elements, return middle element
                int midIndex = (numbers.Length - 1) / 2;
                return numbers[midIndex];
            }
        }

        static void display(double[] numbers)
        {
            Console.WriteLine("Numbers entered:");
            foreach (double num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
