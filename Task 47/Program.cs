// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)

        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void printArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array2D = FillArray(m, n, -10, 10);
printArray(array2D);
