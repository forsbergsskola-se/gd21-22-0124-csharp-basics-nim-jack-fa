using System;

class Program
{

    static void Main()
    {

        
        int seed;
        
        Console.WriteLine("Please enter a seed");
        seed = Convert.ToInt32(Console.ReadLine());
        Random random = new Random(seed);

        int num1;
        int num2;
        int num3;

        num1 = random.Next(0, 6);
        num2 = random.Next(0, 6);
        num3 = random.Next(0, 6);
        
        Console.WriteLine("Three integers between 0-5:");
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);


        double num4 = random.NextDouble() / 2;
        double num5 = random.NextDouble() / 2;
        double num6 = random.NextDouble() / 2;

        Console.WriteLine("Three numbers between 0.0 and 0.5:");
        Console.WriteLine(num4);
        Console.WriteLine(num5);
        Console.WriteLine(num6);

        double num7 = random.NextDouble() * ((0.7 - 0.2) + 0.2);
        double num8 = random.NextDouble() * ((0.7 - 0.2) + 0.2);
        double num9 = random.NextDouble() * ((0.7 - 0.2) + 0.2);
        
        Console.WriteLine("Three numbers between 0.2 and 0.7");
        Console.WriteLine(num7);
        Console.WriteLine(num8);
        Console.WriteLine(num9);

        string critChanceString;
        double critChance;
        
        Console.WriteLine("Give me a crit-chance. (0.0 for 0%, 1.0 for 100%");
        critChanceString = Console.ReadLine();
        critChance = Convert.ToDouble(critChanceString);
        
        for (int i = 0; i < 5; i++)
        {
            double critChanceCheck = random.NextDouble();
            bool Crit = critChanceCheck <= critChance;
            
            if (Crit == true)
            {
                Console.WriteLine("Crit!");
            }
            else
            {
                Console.WriteLine("No Crit :(");
            }
            
            
        }
        


    }
    
}