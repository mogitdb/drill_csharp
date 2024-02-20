```csharp

using System;

class NumberSage
{
    static void Main()
    {
        // Variables

        // Stores the secret number to be guessed
        int secretNumber;

        // Names of the first and second players
        string player1;
        string player2;

        // Results of rolling a die for each player to determine who starts
        int player1Roll;
        int player2Roll;

        // The name of the currently active player
        string activePlayer;

        // The guess input as a string to be parsed as an integer
        string guessInput;

        // The parsed guess as an integer
        int guessNumber;

        // The message displayed when a player wins
        string victoryMessage;

        // Boolean flag to control the game loop, set to 'true' when the game ends
        bool isGameEnded = false;

        // Pre-Game Setup
        Console.WriteLine("Welcome to Number Sage!");
        Console.WriteLine("Unravel the mysteries of the stars to find the sacred number.");

        // Assign a random number to secretNumber
        Random random = new Random();
        secretNumber = random.Next(1, 101); // Assigns a random number between 1 and 100

        // Get player names
        Console.Write("Enter name for Player 1 (Use letters only!): ");
        player1 = Console.ReadLine();
        Console.Write("Enter name for Player 2 (Use letters only!): ");
        player2 = Console.ReadLine();

        // Roll a d20 to determine who starts
        player1Roll = random.Next(1, 21); // Rolls a 20-sided die for player 1
        player2Roll = random.Next(1, 21); // Rolls a 20-sided die for player 2
        Console.WriteLine($"{player1} rolls a cosmic die and gets: {player1Roll}");
        Console.WriteLine($"{player2} rolls a cosmic die and gets: {player2Roll}");

        // Determine activePlayer based on dice rolls
        if (player1Roll == player2Roll)
        {
            // In case of a tie, randomly choose the starting player
            Console.WriteLine("The stars have aligned! Both players are destined for greatness we'll let the stars decide who begins.");
            activePlayer = random.Next(0, 2) == 0 ? player1 : player2;
            Console.WriteLine($"By the will of the cosmos, {activePlayer} will start.");
        }
        else
        {
            // The player with the higher roll starts
            activePlayer = player1Roll > player2Roll ? player1 : player2;
        }

        // Main Game Loop

        // While the game is not ended, players take turns to guess the number
        while (!isGameEnded)
        {
            // Prompt the current player for their guess
            Console.WriteLine($"{activePlayer}'s turn. Enter your guess:");
            guessInput = Console.ReadLine();

            // Parse the player's guess and ensure it is a valid number
            if (!int.TryParse(guessInput, out guessNumber))
            {
                // If parsing fails, the input is not a number, and the player is prompted again
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // Check if the player's guess matches the secret number
            if (guessNumber == secretNumber)
            {
                // If the guess is correct, announce the victory and end the game
                victoryMessage = $"Congratulations, {activePlayer}! You, the Number Sage, have guessed the sacred number!";
                Console.WriteLine(victoryMessage);
                isGameEnded = true; // Set the isGameEnded flag to true to exit the game loop
            }
            else
            {
                // If the guess is wrong, give a hint and switch to the other player
                if (guessNumber < secretNumber)
                {
                    Console.WriteLine("The stars whisper that the sacred number is higher...");
                }
                else
                {
                    Console.WriteLine("The stars whisper that the sacred number is lower...");
                }

                // Switch the activePlayer for the next turn
                activePlayer = activePlayer == player1 ? player2 : player1;
            }
        }

        // Game End Message
        Console.WriteLine("Thank you for playing Number Sage! Press any key to exit.");
        Console.ReadKey();
    }
}
//ggwp its da end of da code