using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            bool passIsCorrect = false;

            string correctPassword = String.Concat(userName.Reverse().ToArray());
            bool userIsBlock = false;
            int count = 0;
            while (!passIsCorrect && !userIsBlock)
            {
                string password = Console.ReadLine();
                if (password.Equals(correctPassword))
                {
                    Console.WriteLine($"User {userName} logged in.");
                    passIsCorrect = true;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        userIsBlock = true;
                        Console.WriteLine($"User {userName} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
