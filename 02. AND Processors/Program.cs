using System;

namespace _02._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int processors = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            int deys = int.Parse(Console.ReadLine());
            double processorsToProduce = employees * deys* 8;
            double processorsForTime = Math.Floor(processorsToProduce / 3);
            if (processors <= processorsForTime)
            {
                double profit = processorsForTime - processors;
                Console.WriteLine($"Profit: -> {(profit*110.10):f2} BGN");
            } else
            {
                double diff = processors - processorsForTime;
                Console.WriteLine($"Losses: -> {(diff*110.10):f2} BGN");
            }
        }
    }
}
