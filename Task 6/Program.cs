// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.Clear();

Console.WriteLine("Введите число ");
int NUM = int.Parse(Console.ReadLine()!);

if (NUM % 2 == 0)
{
    Console.WriteLine($"Число {NUM} является четным");
}
else
{
    Console.WriteLine($"Число {NUM} не является четным");
}