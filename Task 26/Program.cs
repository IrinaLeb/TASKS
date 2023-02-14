// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.Clear();

int GetNumber(int S)
{
    int quantity = 0;
    if (S == 0)
    {
        quantity = 1;
    }
    else
    {
        while (S != 0)
        {
            S /= 10;
            quantity++;
        }
    }
    return quantity;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Количество цифр в числе {N} -> {GetNumber(N)}");