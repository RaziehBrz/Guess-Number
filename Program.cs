internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        var min = 1;
        var max = 100;
        bool playAgain = true;
        int round = 0;
        int guess;

        Console.Clear();

        while (playAgain)
        {
            var randomNumber = random.Next(min, max + 1);
            do
            {
                Console.WriteLine("Enter a number between 1-100 :");
                guess = Convert.ToInt32(Console.ReadLine());

                validation(guess, randomNumber, round);

                round++;

            } while (guess != randomNumber);

            Console.WriteLine("Would you like to play again ? Y / N");
            var answer = Console.ReadLine();

            playAgain = answer.ToUpper() == "Y";
            Console.Clear();
        }
        Console.WriteLine("Thanks for playing ^-^");
    }

    static void validation(int guess, int randomNumber, int round)
    {
        if (guess > randomNumber)
        {
            Console.WriteLine(guess + " is too high !!");
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine(guess + " is too low !!");
        }
        else
        {
            Console.WriteLine("Number : " + guess);
            Console.WriteLine("You win ^-^");
            Console.WriteLine("Round : " + round);

        }

    }

}