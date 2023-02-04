// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

// Console.WriteLine("Напишите любое трезначное число");
// int a = int.Parse(Console.ReadLine()!);
// int n = a / 10;
// int b = n %= 10;
// Console.WriteLine($"{b}");

int a = new Random().Next(100,999); 
Console.WriteLine($" {a} ");   
int n = a / 10;
int b = n %= 10;
Console.WriteLine($"{b}");

// int n = a % 10;
// if (n = a % 10)
// {
//     Console.WriteLine($" {n} ");
// }
// else
// {
//     Console.WriteLine("нет такой цифры");
// }