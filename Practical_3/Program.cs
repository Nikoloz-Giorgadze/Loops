using System;



namespace Practical_3
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            {
                for(int i = 1; i <=x; i++)
                {
                    int cubed = i * i * i;
                    Console.WriteLine($"{i} cubbed is {cubed}");
                }
            }
           
        }
    }
}