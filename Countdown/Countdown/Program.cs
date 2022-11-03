Countdown(10);

int Countdown(int number)
{
    Console.WriteLine(number);

    if (number == 0) return 0;

    return Countdown(number - 1);
}