using System;

namespace _11Matoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string shit = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            AsdAsd(firstNum, shit, secondNum);

        }

        private static void AsdAsd(double firstNum, string shit, double secondNum)
        {
            if (shit == "/")
            {
                Console.WriteLine(firstNum / secondNum);
            }
            else if (shit == "*")
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (shit == "+")
            {
                Console.WriteLine(firstNum + secondNum);
            }
            else if (shit == "-")
            {
                Console.WriteLine(firstNum - secondNum);
            }
        }
    }
}
