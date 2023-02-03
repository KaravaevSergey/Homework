// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите цифру от 1 до 7");
int A = int.Parse(Console.ReadLine()!);


if (A > 0 && A <= 5)
{
    Console.WriteLine("на работку пора ");
}
else if (A > 5 && A <= 7)
{
    Console.WriteLine("посиди дома");
}

else
{
    Console.WriteLine("Внимательней читайте перечень цифр, вы балбес");
}
