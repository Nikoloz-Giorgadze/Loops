using System;

namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {number} is: " + sum);

        }
    }
}