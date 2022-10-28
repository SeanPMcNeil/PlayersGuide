/* 
 * Write a program that takes in a user-entered # of chocolate eggs that get
 * distributed to the sisters, with the leftovers going to the Duckbear
 */

Console.WriteLine("How many chocolate eggs were gathered today?");

int chocEggs = Convert.ToInt32(Console.ReadLine());

int sisterEggs = chocEggs / 4;
Console.WriteLine("Each sister gets " + sisterEggs + " chocolate eggs.");

int duckBearEggs = chocEggs % 4;
Console.WriteLine($"The Duckbear gets {duckBearEggs} chocolate eggs.");

// The duckbear gets more eggs if the total amount is 3, 7, or 11 