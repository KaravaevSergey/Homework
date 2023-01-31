// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()!);

if (numA > numB)
{
    Console.WriteLine($"Первое число больше второго, следовательно {numA} больше чем {numB}");
}
else
{
    Console.WriteLine($"Второе число больше первого, следовательно {numB} больше чем {numA}");
}