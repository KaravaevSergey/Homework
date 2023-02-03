// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Напишите любое число");
int a = int.Parse(Console.ReadLine()!);
int n = a % 10;
if (n = a % 10)
{
    Console.WriteLine($" {n} ");
}
else
{
    Console.WriteLine("нет такой цифры");
}
