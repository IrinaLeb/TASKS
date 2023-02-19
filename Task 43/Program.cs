// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

void Check(double b1, double k1, double b2, double k2)
{
    if (((k1 == k2) && (b1 == b2)))
    {
        Console.WriteLine();
        Console.Write("Прямые совпадают");
    }
    
    else if (k1 == k2)
    {
        Console.WriteLine();
        Console.Write("Прямые параллельны");
    }    
}

double DirectX(double b1, double k1, double b2, double k2)
{
    double x1 = b2 - b1;
    double x2 = k1 - k2;
    double X = x1 / x2;
    return X;
}

double DirectY(double k1, double b1, double X)
{
    double y1 = k1 * X;
    double Y = y1 + b1;
    return Y;
}

Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Check(b1, k1, b2, k2);
double X = DirectX(b1, k1, b2, k2);
double Y = DirectY(k1, b1, X);
Console.WriteLine();
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({X:f1}; {Y:f1})");