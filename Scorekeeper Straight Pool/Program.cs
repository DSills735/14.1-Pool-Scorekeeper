using System.Transactions;

Console.WriteLine("Enter the name of Player 1:");

string player1 = Console.ReadLine()!;

Console.WriteLine("Enter the name of Player 2:");

string player2 = Console.ReadLine()!;

Console.WriteLine("What score do you want to play to?");

int maxScore = Convert.ToInt32(Console.ReadLine());
int player1Score = 0;
int player2Score = 0;
PlayGame();
void PlayGame()
{   
    player1Score = 0;
    player2Score = 0;
    
    Console.Clear();
    Console.WriteLine("Welcome to a new game! Who is going to break? Enter 1 or 2");

    int breaker = Convert.ToInt32(Console.ReadLine());

    if(breaker == 2)
    {
        Player2Turn();
    }
    else
    {
        Player1Turn();
    }
}

void Player1Turn()
{
    
    Console.WriteLine($"{player1}, It is your turn! Enter your score when you are finished. You currently have {player1Score} points.");
    int score = Convert.ToInt32(Console.ReadLine());
    player1Score += score;
    Console.Clear();
    if(player1Score >= maxScore)
    {
        Console.WriteLine($"Player 2 won with a score of {player1Score}");
        Console.WriteLine("Do you want to play again? Y/N");
        string temp = Console.ReadLine()!.Trim().ToLower();

        if(temp == "y")
        {
            PlayGame();
        }
        else
        {
            Environment.Exit(0);
        }

    }
    Console.WriteLine($"{player1} scored {score}, and has a total score of {player1Score}");
    Console.WriteLine();
    Player2Turn();
}
void Player2Turn()
{
    
    Console.WriteLine($"{player2}, It is your turn! Enter your score when you are finished. You currently have {player2Score} points.");
    int score = Convert.ToInt32(Console.ReadLine());
    player2Score += score;
    Console.Clear();

    if(player2Score >= maxScore)
    {
        Console.WriteLine($"{player2} won with a score of {player2Score}");
        Console.WriteLine("Do you want to play again? Y/N");
        string temp = Console.ReadLine()!.Trim().ToLower();

        if(temp == "y")
        {
            PlayGame();
        }
        else
        {
            Environment.Exit(0);
        }
    }
    Console.WriteLine($"{player2} scored {score}, and has a total score of {player2Score}");
    Console.WriteLine();
    Player1Turn();
}