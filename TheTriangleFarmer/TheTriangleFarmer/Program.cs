Console.WriteLine("Please enter a base length of the triangle (decimals allowed): ");
double triangleBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the height of the triangle (decimals allowed): ");
double triangleHeight = Convert.ToDouble(Console.ReadLine());

double triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine($"The area of the triangle is: {triangleArea}");