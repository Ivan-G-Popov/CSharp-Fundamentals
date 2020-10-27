using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] english = { "England", "USA" };
            string[] spanish = { "Spain", "Argentina", "Mexico" };

            string language = Console.ReadLine();
            string spokenLanguage = "";
            if (english.Contains(language))
            {
                spokenLanguage = "English";
            }
            else if (spanish.Contains(language))
            {
                spokenLanguage = "Spanish";
            }
            else
            {
                spokenLanguage = "unknown";
            }
            Console.WriteLine(spokenLanguage);
        }
    }
}
