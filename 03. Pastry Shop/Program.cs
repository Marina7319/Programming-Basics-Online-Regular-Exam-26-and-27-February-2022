using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string sweets = Console.ReadLine();
            int numSweets = int.Parse(Console.ReadLine());
            int deyFromMonth = int.Parse(Console.ReadLine());
            double sum = 0;
            if (deyFromMonth <= 15)
            {
                if (sweets == "Cake")
                {
                    double price = numSweets * 24;
                    sum = price - price * 0.1;
                }
                if (sweets == "Souffle")
                {
                    double price = numSweets * 6.66;
                    sum = price - price * 0.1; ;
                }
                if (sweets == "Baklava")
                {
                    double price = numSweets * 12.60;
                    sum = price - price * 0.1; ;
                }
            }
            if (deyFromMonth > 15)
            {
                if (sweets == "Cake")
                {
                    double price = numSweets * 28.7;
                    sum = price;
                }
                if (sweets == "Souffle")
                {
                    double price = numSweets * 9.8;
                    sum = price;
                }
                if (sweets == "Baklava")
                {
                    double price = numSweets * 16.98;
                    sum = price;
                }
            }
            if (deyFromMonth <= 22)
            {
                if (sum > 100 && sum < 200)
                {
                    sum = sum - sum * 0.15;
                }
                if (sum > 200)
                {
                    sum = sum - sum * 0.25;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
