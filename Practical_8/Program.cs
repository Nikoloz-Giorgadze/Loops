using System;


namespace Practical_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            int x=decimalNumber;
            int temporary;
            string result = string.Empty;
            while(decimalNumber > 0)
            {
                temporary = decimalNumber % 2;
                decimalNumber /= 2;
                result = temporary.ToString() + result;
            }
            Console.WriteLine($"Decimal number {x} in binary is: {result}");
        }
    }
}