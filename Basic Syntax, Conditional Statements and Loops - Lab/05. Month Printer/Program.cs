using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if ((number > 12) || (number < 1))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[number - 1]);
            }
        }
    }
}
