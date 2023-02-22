using System;

namespace Practical_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The divisors for {number} number are:");
            Console.Write(1);
            for (int divisor=2;divisor<=number;divisor++)
            {
                if((number%divisor)==0)
                    Console.Write($",{divisor}");
            }
            
        }
    }
}