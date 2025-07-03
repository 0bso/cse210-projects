using System;

class Program
{
    static void Main(string[] args) 
    {
        Random randomGenerator = new Random();

        int magic_num = randomGenerator.Next(1,100);

        bool correct = false;

        int total_guesses = 0;

        Console.WriteLine("Try and Guess the Magic Number!");

        do
        {
            total_guesses += 1;

            Console.WriteLine("What is your Guess?");
            string guess_str = Console.ReadLine();
            int guess_num = int.Parse(guess_str);

            if(guess_num > magic_num){
                Console.WriteLine("Lower");
                correct = false;
            }
            else if( guess_num < magic_num){
                Console.WriteLine("Higher");
                correct = false;
            }
            else if( guess_num == magic_num){
                Console.WriteLine($"You guessed it! Number of guesses: {total_guesses}");
                correct = true;
            }
        }while (correct == false);

        
    }
}