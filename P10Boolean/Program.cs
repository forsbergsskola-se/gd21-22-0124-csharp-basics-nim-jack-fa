using System;

class Program
{

    static void Main()
    {

        string ageString;
        int age;
        
        Console.WriteLine("What is your age?");
        ageString = Console.ReadLine();
        age = Convert.ToInt32(ageString);
        
        bool isChild = age <= 12;
        bool isTeenager = 13 <= age & age <= 19;
        bool isGrownup = age > 19;
        
        Console.WriteLine("You are a child: " + isChild);
        Console.WriteLine("You are a teenager: " + isTeenager);
        Console.WriteLine("You are a grown-up: " + isGrownup);

    }
    
}