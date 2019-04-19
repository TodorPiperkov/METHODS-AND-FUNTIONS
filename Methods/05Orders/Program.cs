using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            VendingMachine(order, amount);
        }

        private static void VendingMachine(string order, double amount)
        {
            if (order == "coffee")
            {
                double coffeeCost = 1.50 * amount;
                Console.WriteLine($"{coffeeCost:F2}");
            }
            else if (order == "water")
            {
                double waterCost = 1.00 * amount;
                Console.WriteLine($"{waterCost:F2}");
            }
            else if (order == "coke")
            {
                double cokeCost = 1.40 * amount;
                Console.WriteLine($"{cokeCost:F2}");
            }
            else if (order == "snacks")
            {
                double snacksCost = 2.00 * amount;
                Console.WriteLine($"{snacksCost:F2}");
            }
        }
    }
}
