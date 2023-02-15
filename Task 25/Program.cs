// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Erect(int C, int D)
{
    int Degree = 1;
    for (int i = 1; i <= D; i++)
    {
        Degree *= C; //Degree = Degree * C;
    }
    return Degree;
}

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} -> {Erect(A, B)}");