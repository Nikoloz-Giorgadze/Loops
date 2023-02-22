using System;

namespace Practical_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 1; i <= x; i++)
            {
                if(i%2==1)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of odd numbers from 1 to {x} is: {sum}");
        }
    }
}