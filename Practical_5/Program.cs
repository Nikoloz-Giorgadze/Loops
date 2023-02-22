using System;

namespace Practical_5
{
    class Program
    {
        static  void Main()
        {
            Console.WriteLine("Enter a number of rows of floyds triangle to be printed: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int a, b;
            for (int i = 1; i <= x; i++)
            {
                if(i%2==0)
                {
                    a = 1;
                    b = 0;
                }
                else
                {
                    a = 0;
                    b = 1;
                }
                for(int j = 1; j <= i; j++)
                {
                    if(j%2==0)
                    {
                        Console.Write("{0}",a);
                    }
                    else
                    {
                        Console.Write("{0}",b);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}