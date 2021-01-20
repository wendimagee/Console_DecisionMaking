using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Please enter a number between 1 and 100");
            int number = Int32.Parse(Console.ReadLine());
            
            if (number % 2 == 0 )
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine(number + "The number is odd");
            }



        }
    }
}
