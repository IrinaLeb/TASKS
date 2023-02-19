// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CheckTriangele(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (CheckTriangele(a, b, c))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}
