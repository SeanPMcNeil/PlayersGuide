int manticoreHealth = 10;
int cityHealth = 15;

int manticoreDistance = -1;

while (manticoreDistance < 0 || manticoreDistance > 100)
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
    string? playerOneResponse = Console.ReadLine();
    manticoreDistance = Convert.ToInt32(playerOneResponse);

    if (manticoreDistance < 0 || manticoreDistance > 100)
        Console.WriteLine("Please choose a distance between 0 and 100!");
}

Console.Clear();

int round = 1;

do
{
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");

    int cannonDamage = 1;

    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        cannonDamage = 10;
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        cannonDamage = 3;
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        cannonDamage = 3;
    }

    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write("Enter desired cannon range: ");
    string? playerTwoResponse = Console.ReadLine();
    int cannonDistance = Convert.ToInt32(playerTwoResponse);


    if (cannonDistance == manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= cannonDamage;
        if (manticoreHealth > 0)
            cityHealth--;
        round++;
    }
    else if (cannonDistance < manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round FELL SHORT of the target.");
        cityHealth--;
        round++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("That round OVERSHOT the target.");
        cityHealth--;
        round++;
    }
} while (manticoreHealth > 0 && cityHealth > 0);

if (manticoreHealth <= 0)
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
else if (cityHealth <= 0)
    Console.WriteLine("The Manticore has destroyed the city of Consolas!");