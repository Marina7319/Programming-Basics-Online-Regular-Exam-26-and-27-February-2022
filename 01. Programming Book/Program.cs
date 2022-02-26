using System;

namespace _01._Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForPrintingOnePage = double.Parse(Console.ReadLine());
            double priceForPrintingOneFrontPage = double.Parse(Console.ReadLine());
            int discountForPapper = int.Parse(Console.ReadLine());
            double priceForDesigner = double.Parse(Console.ReadLine());
            int discountForSum = int.Parse(Console.ReadLine());
            double sumPages = priceForPrintingOnePage * 899;
            double sumFronPageAndBackpage = 2 * priceForPrintingOneFrontPage;
            double sum = sumPages + sumFronPageAndBackpage;
            double discountForPrintingPaper = sum - sum * discountForPapper/100;
            double price = discountForPrintingPaper + priceForDesigner;
            double money = price - price * discountForSum/100;
            Console.WriteLine($"Avtonom should pay {money:f2} BGN.");
        }
    }
}
