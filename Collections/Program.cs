// See https://aka.ms/new-console-template for more information
string[] names = new string[] { "Celil", "Hikmet", "Tuba" };

Console.WriteLine(names[0]);

List<string> names2 = new List<string> { "Celil", "Hikmet", "Tuba" };

Console.WriteLine(names2[0]);

names2.Add("Tat");
Console.WriteLine(names2.Count);