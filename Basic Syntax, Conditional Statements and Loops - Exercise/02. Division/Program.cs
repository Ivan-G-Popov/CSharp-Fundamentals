using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] devisionsNumbers = { 2, 3, 6, 7, 10 };
            int devision = 0;
            bool isDevidet = false;
            for (int i = 0; i < devisionsNumbers.Length; i++)
            {
                if (number % devisionsNumbers[i] == 0)
                {
                    isDevidet = true;
                    devision = devisionsNumbers[i];
                }
            }
            if (isDevidet)
            {
                Console.WriteLine($"The number is divisible by {devision}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
