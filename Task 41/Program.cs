// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
Console.Clear();
int[] a = GetArray(5, -10, 10);
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        sum ++;
    }
     
}
Console.WriteLine(String.Join(", ", a));
Console.WriteLine($"{sum}");
