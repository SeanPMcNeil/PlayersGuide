﻿using System;

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");

Console.Beep(442, 1000);