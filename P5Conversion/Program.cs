using System;
using System.Globalization;

class Program
{

    static void Main()
    {

        int number = 5;
        float convertNumber;
        string numberstring = number.ToString();
        
        Console.WriteLine(numberstring);
        
        numberstring = "56.3";
        convertNumber = Convert.ToSingle(numberstring);
        number = Convert.ToInt32(convertNumber);
        Console.WriteLine(number);

    }
    
}
