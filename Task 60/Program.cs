// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray3D(int m, int n, int h)
{
    int[,,] result = new int[m, n, h];

    for (int k = 0; k < h; ++k)
    {
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                result[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return result;
}

void FillArray3D(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == array[i, j, k])
                {
                    array[i, j, k] = count++;
                }
            }
        }
    }
}

void PrintIndex(int[,,] arrayIndex)
{
    for (int i = 0; i < arrayIndex.GetLength(0); i++)
    {
        for (int k = 0; k < arrayIndex.GetLength(2); k++)
        {
            for (int j = 0; j < arrayIndex.GetLength(1); j++)
            {
                Console.Write($"{arrayIndex[j, i, k]} ({k},{j},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] array3D = GetArray3D(2, 2, 2);
FillArray3D(array3D);
PrintIndex(array3D);
Console.WriteLine();