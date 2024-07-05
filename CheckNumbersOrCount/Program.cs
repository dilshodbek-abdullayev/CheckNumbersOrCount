using CheckNumbersOrCount.Services;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t\t\tWelcome!!!\n\tThis program determines the number of numbers, letters and other characters in the entered text");
        Console.Write("Enter the text => ");
        string userInput = Console.ReadLine();
        CheckService.PrintRequest(userInput);
    }    
}