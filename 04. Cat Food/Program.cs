using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());
            int groupOne = 0;
            int groupTwo = 0;
            int groupTree = 0;
            double foodLeight = 0;
            for (int i = 1; i <= cats; i++)
            {
                double food = double.Parse(Console.ReadLine());
                if(food >= 100 && food < 200)
                {
                    groupOne += 1;
                }
                if (food >= 200 && food < 300)
                {
                    groupTwo += 1;
                }
                if (food >= 300 && food < 400)
                {
                    groupTree += 1;
                }
                foodLeight += food;
            }
            double priceForFoodPerDay = ((foodLeight / 1000) * 12.45);
            Console.WriteLine($"Group 1: {groupOne} cats.");
            Console.WriteLine($"Group 2: {groupTwo} cats.");
            Console.WriteLine($"Group 3: {groupTree} cats.");
            Console.WriteLine($"Price for food per day: {priceForFoodPerDay:f2} lv.");
        }
    }
}
