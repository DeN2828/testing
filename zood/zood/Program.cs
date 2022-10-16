using zood;

Console.WriteLine("Enter date in format DD.MM.YYYY");
string input = Console.ReadLine();
Moon moon = new Moon(input);
moon.Output();