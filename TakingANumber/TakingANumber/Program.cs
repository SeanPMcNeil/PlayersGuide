int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");

Console.WriteLine(result);

int result2 = AskForNumberInRange("What is the airspeed velocity of an unladen swallow?", 23, 25);

Console.WriteLine(result2);

int AskForNumber(string text)
{
    Console.Write(text + " ");
    string? response = Console.ReadLine();
    int number = Convert.ToInt32(response);

    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text + " ");
        string? response = Console.ReadLine();
        int number = Convert.ToInt32(response);

        if (number >= min && number <= max)
            return number;

        Console.WriteLine("Guess again!");
    }
}