// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalculateAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return CalculateAckerman(m - 1, 1);
    else return CalculateAckerman(m - 1, CalculateAckerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите число m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n = ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({m},{n}) = {CalculateAckerman(m, n)}");