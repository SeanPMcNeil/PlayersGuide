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

while (manticoreHealth > 0 || cityHealth > 0)
{
    
}