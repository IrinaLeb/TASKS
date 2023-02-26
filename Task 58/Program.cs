// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixArray(int row, int col, int minValue, int maxValue)
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

void PrintArray(int[,] MatrixArray)
{
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            Console.Write($"{MatrixArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] ProdFirstSecondMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] MixMatrix = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
    if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
    {
        Console.Write("Умножение матриц невозможно");
        return MixMatrix;
    }

    for (int i = 0; i < MixMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MixMatrix.GetLength(1); j++)
        {
            for (int l = 0; l < FirstMatrix.GetLength(1); l++)
            {
                MixMatrix[i, j] += (FirstMatrix[i, l] * SecondMatrix[l, j]);
            }
        }
    }
    Console.WriteLine();
    return MixMatrix;
}

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк первой матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);

int[,] FirstMatrix = MatrixArray(row1, col1, 1, 5);
PrintArray(FirstMatrix);
Console.WriteLine();
int[,] SecondMatrix = MatrixArray(row2, col2, 1, 5);
PrintArray(SecondMatrix);
int[,] ProdMatrix = ProdFirstSecondMatrix(FirstMatrix, SecondMatrix);
PrintArray(ProdMatrix);