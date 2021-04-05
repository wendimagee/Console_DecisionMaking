using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! What's your name?");
            string name = Console.ReadLine();
            bool goAgain = true;
            do
            {
                try
                {
                    Console.WriteLine("Hello, " + name + "! Please enter a number between 1 and 100");
                    int number = Int32.Parse(Console.ReadLine());
                    if (number < 1 || number > 100)
                    {
                        throw new Exception();
                    }

                    else if (number % 2 == 0)
                    {
                        if (number < 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else if (number > 25 && number <= 60)
                        {
                            Console.WriteLine("Even");
                        }

                        else if (number > 60)
                        {
                            Console.WriteLine(number + " Even");
                        }
                    }
                    else
                    {
                        Console.WriteLine(number + " The number is odd");
                    }
                }
                catch
                {
                    Console.WriteLine(name + ", that's an invalid entry. Try again");
                    goAgain = true;
                }
                Console.WriteLine("\n\nWould you like to check another number?(y/n)");
                char answer = char.Parse(Console.ReadLine());
                if (char.ToLower(answer) == 'y')
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
            }
            while (goAgain == true);
        }
    }
}
