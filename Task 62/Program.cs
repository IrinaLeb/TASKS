// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetSpiralArray(int row, int col)
{
    int[,] array2D = new int[row, col];
    return array2D;
}

int FillArray(int[,] SpiralArray)
{
    int count = 1;
    int size = SpiralArray.GetLength(0);
    int size2 = SpiralArray.GetLength(1);

    for (int i = 0; i < size / 2; i++)
    {
        for (int j = i; j < size2 - i; j++)

            SpiralArray[i, j] = count++;

        for (int k = 1; k < size - i; k++)

            SpiralArray[k, size - 1 - i] = count++;

        for (int j = size2 - i - 2; j > i; j--)

            SpiralArray[size2 - 1 - i, j] = count++;

        for (int k = size - 1 - i; k > i; k--)

            SpiralArray[k, i] = count++;
    }
    return count;
}


void PrintSpiralArray(int[,] SpiralArray2D)
{
    for (int i = 0; i < SpiralArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < SpiralArray2D.GetLength(1); j++)
        {
            Console.Write($"{SpiralArray2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] array2D = GetSpiralArray(4, 4);
FillArray(array2D);
PrintSpiralArray(array2D);