// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 0  1  2   3   4
// [3  7  22  2  78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(),3);
    }
    return result;
}
Console.Clear();
double[] a = GetArray(5,10,50);

double max(double[] a)
{
    double max1 = a[0];
    for (int ran = 1; ran < a.Length; ran++)
    {
        if(a[ran] > max1)
        {
            max1 = a[ran];
        }


    }   
    return max1;
}

double min(double[] a)
{
    double min1 = a[0];
    for (int ran = 1; ran < a.Length; ran++)
    {
        if(a[ran] < min1)
        {
            min1 = a[ran];
        }


    }   
    return min1;
}

double max3 = max(a);
double min3 = min(a);
double F = max3 - min3;
Console.WriteLine(String.Join(", ", a));
Console.WriteLine(F);