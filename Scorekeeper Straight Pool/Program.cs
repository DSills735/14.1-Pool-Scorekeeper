public static class Program
{

    internal static void Main(string[] args)
    {
        Initialization();
    }

    internal static void Initialization()
    {
        Console.WriteLine("Welcome to the pool tracker. Please enter the player names.");
        Console.WriteLine("Enter the name of Player 1:");

        string player1 = Console.ReadLine()!;

        Console.WriteLine("Enter the name of Player 2:");

        string player2 = Console.ReadLine()!;

        Console.Clear();
        MainMenu(player1, player2);
    }

    internal static void MainMenu(string player1, string player2)
    {
        Console.WriteLine($"{player1} and {player2}, what game do you want to play? Pick an option from below.");
        Console.WriteLine("1. Play Straight pool");
        Console.WriteLine("2. Play snooker");

        string userInput = Console.ReadLine()!;
        bool validInput = false;
        int p2Wins = 0;
        int p1Wins = 0;

        while (!validInput)
        {

            if (userInput == "1")
            {
                StraightPool.PlayStraightPool(player1, player2, p2Wins, p1Wins);
                validInput = true;
                Console.Clear();
            }
            else if (userInput == "2")
            {
                Snooker.PlaySnooker(player1, player2);
                //userInput = Console.ReadLine()!;
            }
            else
            {
                Console.WriteLine("Please enter an option from above.");
                userInput = Console.ReadLine()!;
            }

        }
    }
}
