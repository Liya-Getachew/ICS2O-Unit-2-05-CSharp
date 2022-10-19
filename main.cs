// Created by: liya getachew
// Created on: Oct 19 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double hoursWorked;
        double salary;
        const double TAX_RATE = 0.18;

        Console.WriteLine("This program calculates the take home pay from a job.");
        Console.WriteLine("");
      
        Console.WriteLine("please enter your enployment information.");
        Console.WriteLine("");

        Console.Write("Enter hours spent working: ");
        hoursWorked = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter hourly rate: $");
        salary = Convert.ToInt32(Console.ReadLine());

        double takeHomeMoney = (hoursWorked * salary) * (1.00 - TAX_RATE);
        double taxedMoney = (hoursWorked * salary) * (TAX_RATE);

        Console.WriteLine("");
        Console.WriteLine("Your pay will be: $" + takeHomeMoney.ToString("0.00") + ". ");
        Console.WriteLine("The government will take: $" + taxedMoney.ToString("0.00") + ". ");

        Console.WriteLine("\nDone.");
    }
}