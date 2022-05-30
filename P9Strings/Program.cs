using System;

class Program
{

    static void Main()
    {

        string firstName;
        string lastName;
        string age;
        
        Console.WriteLine("What's your first name?");
        firstName = Console.ReadLine();
        Console.WriteLine("What's your last name?");
        lastName = Console.ReadLine();
        Console.WriteLine("What's your age?");
        age = Console.ReadLine();
        
        Console.WriteLine("Hello " + firstName + " " + lastName + ", you are " + age + " years old!");


    }
    
}