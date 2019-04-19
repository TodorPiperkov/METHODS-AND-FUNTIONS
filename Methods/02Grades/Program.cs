using System;

namespace _01SignofIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double  grade = double.Parse(Console.ReadLine());

            GradesMethod(grade);
        }

        private static void GradesMethod(double grade)
        {
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.50 && grade <= 5.49 )
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
