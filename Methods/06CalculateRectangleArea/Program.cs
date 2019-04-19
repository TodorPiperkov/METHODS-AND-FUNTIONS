using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(width, height));

        }

        private static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
