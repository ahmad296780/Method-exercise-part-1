using System;
using System.Globalization;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"hi {name}, how are you? please tell me your favorite color");
            string color = Console.ReadLine(); 
            Console.WriteLine($"ok so your favorite color is {color}, what about animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"no problem i can provide you with best {animal}");
            Console.ReadLine();
        }
    }
}
