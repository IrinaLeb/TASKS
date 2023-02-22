// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 и 7 -> такого числа в массиве нет

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

bool FindElement(int pos1, int pos2, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (pos1 <= array.GetLength(0) - 1 && pos2 <= array.GetLength(1) - 1)
            {
                return true;
            }
        }
    }
    return false;
}


void PrintArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите позицию строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца: ");
int col = int.Parse(Console.ReadLine()!);

int[,] arrayToo = GetArray(5, 5, 1, 10);
PrintArray(arrayToo);
Console.WriteLine();
if (FindElement(row, col, arrayToo))
{
    Console.WriteLine($"Значение элемента строки {row} столбца {col} -> {arrayToo[row, col]}");
}
else
{
    Console.WriteLine($"{row} {col} -> такого элемента в массиве нет");
}