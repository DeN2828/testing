using zood;

Console.WriteLine("enter birth date in format DD.MM");
string input = Console.ReadLine();
Zood zood = new Zood(input);
zood.Output();