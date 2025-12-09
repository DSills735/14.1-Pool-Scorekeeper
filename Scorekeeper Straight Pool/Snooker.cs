public class Snooker
{
    internal static void PlaySnooker(string player1, string player2)
    {
        int player1Score = 0;
        int player2Score = 0;
        int p1Max = 0;
        int p2Max = 0;
        int p2Wins = 0;
        int p1Wins = 0;

        Console.WriteLine("Welcome to Snooker. Who is going to break? Enter 1 or 2.");
        bool validInput = false;

        //picks who will go first then exit the loop
        while (!validInput)
        {
            int player = Convert.ToInt32(Console.ReadLine());
            if (player == 1)
            {
                validInput = true;
                
            }
            else if (player == 2)
            {
                validInput = true; 
            }
            else
            {
                Console.WriteLine("Invalid input. Try again. Enter 1 or 2.");
                player = Convert.ToInt32(Console.ReadLine());
            }

            
    }
}
}