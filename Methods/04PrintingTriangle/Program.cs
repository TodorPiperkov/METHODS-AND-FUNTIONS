using System;

namespace _04PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            TriangleFromGivenName(num);
            RevesedTriangle(num);
        }

        private static void RevesedTriangle(int maxNum)
        {
            for (int i = maxNum - 1; i >= 1; i--)
            {
                PrintRowWithNumbers(i);
            }
        }

        private static void TriangleFromGivenName(int maxNum)
        {
            for (int row = 1; row <= maxNum; row++)
            {
                PrintRowWithNumbers(row);
            }

        }

        private static void PrintRowWithNumbers(int row)
        {
            for (int number = 1; number <= row; number++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
