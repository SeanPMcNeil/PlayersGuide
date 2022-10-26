Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // This is the thing being named, received from the user
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // This is what describes the named thing, received from the user
string c = "of Doom"; // DOOM
string d = "3000"; // Gotta have a number
// Removed second "of" that was displaying between a and c and changed it to just a space
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
/* Aside from commenting, assigning more descriptive names to the variables can help with code readability */