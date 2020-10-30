using System;

namespace _06._Strong_number
{
    class Program
    {
        static int factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial(number - 1);
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char ch = number[i];
                sum+=factorial(ch-'0');
            }
            if (sum == (int.Parse(number)))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

    }
}
