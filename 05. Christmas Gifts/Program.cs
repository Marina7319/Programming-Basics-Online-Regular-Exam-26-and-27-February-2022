using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int toys = 0;
            int sweather = 0;
            int underSixteen = 0;
            int sixteen = 0; 
            while(input != "Christmas")
            {
                int years = int.Parse(input);
                if(years <= 16)
                {
                    underSixteen++;
                    toys += 5;
                }
                if (years > 16)
                {
                    sixteen++;
                    sweather += 15;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {sixteen}");
            Console.WriteLine($"Number of kids: {underSixteen}"); 
            Console.WriteLine($"Money for toys: {toys}");
            Console.WriteLine($"Money for sweaters: {sweather}");
        }
    }
}
