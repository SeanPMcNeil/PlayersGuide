int userOnesNumber = -1;

while (userOnesNumber < 0 || userOnesNumber > 100)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    string? userOnesResponse = Console.ReadLine();
    userOnesNumber = Convert.ToInt32(userOnesResponse);
}

Console.Clear();

int userTwosGuess;

Console.WriteLine("User 2, guess the number.");

do
{
    Console.Write("What is your next guess? ");
    string? userTwosResponse = Console.ReadLine();
    userTwosGuess = Convert.ToInt32(userTwosResponse);

    if (userTwosGuess > userOnesNumber)
    {
        Console.WriteLine($"{userTwosGuess} is too high.");
    }
    else if (userTwosGuess < userOnesNumber)
    {
        Console.WriteLine($"{userTwosGuess} is too low.");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
    }
}
while (userTwosGuess != userOnesNumber);