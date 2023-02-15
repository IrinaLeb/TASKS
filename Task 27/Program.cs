// Задача 27. Напишите функцию и запустите ее, которая принимает на вход число и выдает сумму цифр в числе 
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Clear();
int Accepts(int num)
{
int Sum = 0;
   for (int i = 0; i <= num; i++)
{ 
    while (num != 0)
    {
        Sum += num % 10; //Sum = Sum + num % 10;
        num /= 10; //num = num / 10;
    }
}
    return Sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр числа {N} -> {Accepts(N)}");