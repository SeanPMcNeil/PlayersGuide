int score;

Console.WriteLine("How many estates do you have?");
int estates = Convert.ToInt32(Console.ReadLine());

score = estates;

Console.WriteLine("How many duchies do you have?");
int duchies = Convert.ToInt32(Console.ReadLine());

score += (duchies * 3);

Console.WriteLine("How many provinces do you have?");
int provinces = Convert.ToInt32(Console.ReadLine());

score += (provinces * 6);

Console.WriteLine($"Total Score: {score}");