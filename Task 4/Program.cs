// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine(num3);
    }
}
else if (num2 > num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}