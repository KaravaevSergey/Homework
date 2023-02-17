// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int[] a = GetArray(5,-3,5);
int sum = 0;

for (int i = 1; i < a.Length; i = i + 2)
{
    sum = sum + a[i];
}
Console.WriteLine(String.Join(", ", a));
Console.WriteLine(sum);
