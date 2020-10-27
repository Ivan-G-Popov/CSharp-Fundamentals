using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int givenMultiplier = int.Parse(Console.ReadLine());

            if (givenMultiplier <= 10)
            {
                for (int times = givenMultiplier; times <= 10; times++)
                {
                    int product = theInteger * times;
                    Console.WriteLine($"{theInteger} X {times} = {product}");
                }
            }
            else
            {
                Console.WriteLine($"{theInteger} X {givenMultiplier} = {theInteger * givenMultiplier}");
            }
        }
    }
}
