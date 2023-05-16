using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int iMagNum;
        int iGuesNum;

        Random randomGenerator = new Random();
        iMagNum = randomGenerator.Next(1,11);

        do
        {
        // Console.Write("What is the magic number? ");
        // string magNum = Console.ReadLine();

        // iMagNum = int.Parse(magNum);

        Console.Write("What is your guess? ");
        string guesNum = Console.ReadLine();
        iGuesNum = int.Parse(guesNum);
        if (iGuesNum > iMagNum)
        {
            Console.WriteLine("Lower");
        }
        else if (iGuesNum < iMagNum)
        {
            Console.WriteLine ("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        } while (iGuesNum != iMagNum);

    }
}