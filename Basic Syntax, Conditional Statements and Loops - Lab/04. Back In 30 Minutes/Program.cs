using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += hours * 60;          // add hours as minutes
            minutes += 30;                  // add 30 min

            int day = (minutes / 1440);     //  1440 min in one day
            minutes %= 1440;                // clear days from minutes
            hours = minutes / 60;           // 60 min in one hour
            minutes %= 60;                 // clear hours from minutes

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
