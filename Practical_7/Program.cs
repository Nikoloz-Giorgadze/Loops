using System;

namespace Practical_7
{
    class Program
    {
        static void Main()
        {
            int next = 0;
            int prev = 0;
            Console.WriteLine("Enter a number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <=number;i++)
            {
                Console.Write(",{0}",next);
                if(next==0)
                {
                    next = 1;
                }
                else
                {
                    int temporar = next;
                    next = next + prev;
                    prev = temporar;
                }
            }
        }
    }
}