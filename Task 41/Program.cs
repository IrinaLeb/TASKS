// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

int CountPozitiveNum (int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res++;
        }
    }
    return res;
}

Console.Clear();
Console.Write("Введите число M: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = GetArray(size, -1000, 1000);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine();
Console.Write("Количество чисел больше нуля равно: ");
Console.Write(String.Join(", ", CountPozitiveNum(arr)));