﻿// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int num = 2;

while(num <= N)
{
Console.WriteLine($"{num},");
num = num + 2;
}