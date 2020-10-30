using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0.0;
            double discount = 0;
            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    if (numbersOfPeople >= 30)
                    {
                        discount = 15 / 100.0;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    if (numbersOfPeople >= 100)
                    {
                        numbersOfPeople -= 10;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    if (numbersOfPeople >= 10 && numbersOfPeople<=20)
                    {
                        discount = 5 / 100.0;
                    }
                    break;
            }
            double totalPrice = numbersOfPeople * price - (numbersOfPeople * price) * discount;
            Console.WriteLine($"Total price: {totalPrice,2:F}");
        }
    }
}