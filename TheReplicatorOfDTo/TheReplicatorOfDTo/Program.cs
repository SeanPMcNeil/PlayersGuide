int[] firstArray = new int[5];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write("Please enter a number: ");
    firstArray[i] = Convert.ToInt32(Console.ReadLine());
}

int[] secondArray = new int[5];

for (int j = 0; j < secondArray.Length; j++)
{
    secondArray[j] = firstArray[j];
}

for (int k = 0; k < firstArray.Length; k++)
{
    Console.WriteLine($"Array 1: {firstArray[k]} | Array 2: {secondArray[k]}");
}