// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Напишите любое число");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
    Console.WriteLine("Такой цифры нет");
}
while (a >= 100)
{
   if (a < 1000)
   {
    int b = a % 10;
    Console.WriteLine($"Третья цифра в числе: {b}" );  
   } 
   a = a / 10;
}
   