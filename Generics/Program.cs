// See https://aka.ms/new-console-template for more information
using Generics;
using System;

MyList<string> names = new MyList<string>();

names.Add("Celil");
Console.WriteLine(names.Length);

names.Add("Tuba");
Console.WriteLine(names.Length);

names.Add("Hikmet");
Console.WriteLine(names.Length);

foreach (var item in names.Items)
{
    Console.WriteLine(item);
}