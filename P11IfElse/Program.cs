using System;

class Program
{

    static void Main()
    {

        int age;
        
        Console.WriteLine("What's your age?");
        age = Convert.ToInt32(Console.ReadLine());

        bool isChild = age <= 12;
        bool isTeen = age >= 13 & age <= 19;
        bool IsGrownup = age >= 20;

        if (isChild == true)
        {
            Console.WriteLine("You are a child");
        }
        else if (isTeen == true)
        {
            Console.WriteLine("You are a teenager");
        }
        else if (IsGrownup == true)
        {
            Console.WriteLine("You are a grown-up");   
        }

        int secondValue;
        Console.WriteLine("Give me another integer");
        secondValue = Convert.ToInt32(Console.ReadLine());

        int Max = Math.Max(age, secondValue);
        
        Console.WriteLine("The maximum is: " + Max);

        int evenOdd = Max % 2;

        if (evenOdd > 0)
        {
            Console.WriteLine("The maximum number is odd.");
        }
        else if (evenOdd == 0)
        {
            Console.WriteLine("The maximum number is even");
        }

    }
    
}