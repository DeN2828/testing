﻿using zood;

Console.WriteLine("Enter date in format DD.MM.YYYY");
string input = Console.ReadLine();
Moon moon = new Moon(input);
moon.Output();
Console.WriteLine("enter birth date in format DD.MM");
string input = Console.ReadLine();
Zood zood = new Zood(input);
zood.Output();