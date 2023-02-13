// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int GetSumm(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i; // sum = sum + 1
    }
    return sum;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {N} равна {GetSumm(N)}");