using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double averageGoldForDey = 0;
            double goldDay = 0;
            int deys = 0;
            double averageSumGoldDays = 0;
            double sum = 0;
            for (int i = 1; i <= locations; i++)
            {
                averageGoldForDey = double.Parse(Console.ReadLine());
                deys = int.Parse(Console.ReadLine());
                for (int j = 1; j <= deys; j++)
                {
                    goldDay = double.Parse(Console.ReadLine());
                    sum += goldDay;
                }
                averageSumGoldDays = sum / deys;
                if (averageSumGoldDays < averageGoldForDey)
                {
                    double diff = averageGoldForDey - averageSumGoldDays;
                    Console.WriteLine($"You need {diff:f2} gold.");
                    sum = 0;
                }
                else
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageSumGoldDays:f2}.");
                    sum = 0;
                }
            }
        }
    }
}
