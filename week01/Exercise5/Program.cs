using System;

class Program
{
    static void Main(string[] args) 
    {
        DisplayWelcomeMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squared_number = SquareNumber(number);

        DisplayResult(name, squared_number);
    }

    static void  DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your Name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string str_number = Console.ReadLine();
        int number = int.Parse(str_number);
        return number;
    }

    static int SquareNumber(int number)
    {   

        return number * number;
    }

    static void DisplayResult(string name, int squared_number)
    {
        Console.WriteLine($"{name}, the square of your number is {squared_number}");
    }

}