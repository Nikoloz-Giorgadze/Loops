using System;

namespace Practical_1
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 0; i <= 10; i++)
                sum += i;
            Console.WriteLine($"Sum from 1 to 10 is: {sum}");
        }

    }
}