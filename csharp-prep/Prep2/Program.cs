using System;
using System.Security.Cryptography;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage? ");
        string stringPercent = Console.ReadLine();
        int percent = int.Parse(stringPercent);
        
        string letter = "";
        if (percent >= 90)
            {
                letter = "A";
            }
        else if (percent>= 80)
            {
                letter= "B";
            }
        
        else if (percent>= 70)
            {
                letter= "C";
            }
        
        else if (percent>= 60)
            {
                letter= "D";
            }
        else
            {
                letter=  "F";
            }
        Console.WriteLine($"Your grade is: {letter}");
        

    }
}