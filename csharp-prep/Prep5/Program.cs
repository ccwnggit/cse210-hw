using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");   
        
        string name;
        int number;

        DisplayWelcome();
        name = PromptUserName ();
        number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome ()
    {
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName ()
    {
    string name;
    Console.Write("Please enter your name: ");
    name = Console.ReadLine();

    return name;
    }

    static int PromptUserNumber()
    {
    string favorNum;
    int favorNumInt;
    Console.Write("Please enter your favorite number: ");
    favorNum = Console.ReadLine();
    favorNumInt = int.Parse(favorNum);
    return favorNumInt;
    }

    static int SquareNumber(int number)
    {
    int squared;
    squared = number * number;
    return squared;   
    }

    static void DisplayResult(string name, int number)
    {
    Console.WriteLine($"{name}, the square of your number is {number}");

    }

}