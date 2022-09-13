using System;

namespace Method_Exercise_part_2
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
         }
        public static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        static void Main(string[] args)
        {
            int x =Add(2, 5);// For my own test
            int y =Add(2, 4);// for exercise
            double a = Multiply(2, 10);
            Console.WriteLine(y);
            Console.WriteLine(a);
            

            Console.ReadLine();
        }
    }
}
