using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string theString = Console.ReadLine();
            int theNum = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatingString(theString, theNum));
        }

        private static string RepeatingString(string theString, int theNum)
        {
            string result = string.Empty;

            for (int i = 0; i < theNum; i++)
            {
                result += theString;
            }
            return result;
        }
    }
}
