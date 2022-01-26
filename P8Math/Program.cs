using System;

namespace P8Math
{
    class Maths
    {
        static void Main()
        {
            string firstString;
            string secondString;
            double first;
            double second;
            
            Console.WriteLine("Give me your first number");
            firstString = Console.ReadLine();
            Console.WriteLine("Give me your second number");
            secondString = Console.ReadLine();

            first = Convert.ToDouble(firstString);
            second = Convert.ToDouble(secondString);
            
            double Max = Math.Max(first, second);
            double Min = Math.Min(first, second);
            double sqrt = Math.Sqrt(first);
            double abs = Math.Abs(first);
            double round = Math.Round(first);
            double floor = Math.Floor(first);
            double ceil = Math.Ceiling(first);
            double clamp = Math.Clamp(first, 0, second);
            double pow = Math.Pow(first, second);
            
            Console.WriteLine("Max: " + Max);
            Console.WriteLine("Min: " + Min);
            Console.WriteLine("Sqrt: " + sqrt);
            Console.WriteLine("Abs: " + abs);
            Console.WriteLine("Round: " + round);
            Console.WriteLine("Floor: " + floor);
            Console.WriteLine("Ceiling: " + ceil);
            Console.WriteLine("Clamp: " + clamp);
            Console.WriteLine("Pow: " + pow);

        }
    }
}