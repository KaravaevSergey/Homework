// string[,] table = new string[2,5];
// table [1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"you   {table[rows, columns]}   you");
//     }
// }



// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// int Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5));

// напишите программу вычисляющую среднее арефмитическое двух чисел

// int a = 4;
// int b = 7;
// double c = (double) (a + b) / 2;

// Console.WriteLine($"Среднее арефмитическое двух чисел {c}");

// // введите три числа и выведите на экран значение суммы и произведения этих числел

//  Console.WriteLine("Введите первое число: ");
//  int A = Convert.ToInt32(Console.ReadLine()!);
//  Console.WriteLine("Введите второе число: ");
//  int B = Convert.ToInt32(Console.ReadLine()!);
//  Console.WriteLine("Введите третье число: ");
//  int C = Convert.ToInt32(Console.ReadLine()!);

//  int Z = A + B + C;
//  int D = A * B * C;
//  Console.WriteLine(Z);
// Console.WriteLine(D);

// напишите программу проверяющую число на четность

// Console.Clear();

// Console.WriteLine("Введите ваши цЫфорки: ");
// int a = int.Parse(Console.ReadLine()!);

// if (a % 2 == 0)
// {
//     Console.WriteLine("цЫфорка чОтная!");
// }
// else
// {
//     Console.WriteLine("цЫфорка нечОтная!");
// }

// // сделайте калькулятор с помощью if else и switch case

// Console.Clear();
// double a, b; string sum;
// Console.WriteLine("Введите первое число: ");
// a = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите второе число: ");
// b = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Выберите вид операции: '+', '-', '*', '/' ");
// sum = Console.ReadLine()!;

// if (sum == "*")
// {
//     Console.WriteLine(a * b);
// }
// else if (sum == "/")
// {
//     Console.WriteLine(a / b);
// }
// else if (sum == "+")
// {
//     Console.WriteLine(a + b);
// }
// else if (sum == "-")
// {
//     Console.WriteLine(a - b);
// }

// Console.Clear();
// double a, b; string sum;
// Console.WriteLine("Введите первое число: ");
// a = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите второе число: ");
// b = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Выберите вид операции: '+', '-', '*', '/' ");
// sum = Console.ReadLine()!;

// switch (sum)
// {
//     case "+":
//         Console.WriteLine(a + b);
//         break;
//     case "-":
//         Console.WriteLine(a - b);
//         break;
//     case "*":
//         Console.WriteLine(a * b);
//         break;
//     case "/":
//         Console.WriteLine(a / b);
//         break;
//     default:
//         Console.WriteLine("Неизвастный вид операции");
//         break;
// }
Console.Clear();
int chet = 0;
int nechet = 0;

Console.WriteLine("Введите первое число: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int d = int.Parse(Console.ReadLine()!);

while (c <= d)
{
    if (c % 2 == 0)
    {
        chet++;
    }
    else
    {
        nechet++;
    }
    c++;
}
Console.WriteLine("количество четных чисел - " + chet);
Console.WriteLine("количество не четных чисел - " + nechet);