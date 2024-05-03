using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        int guess = -1;
        while(guess != magicNumber )
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        }
    }
}