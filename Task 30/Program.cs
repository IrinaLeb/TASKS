// Решение в группах задач: Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] getArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void printArray(int[] inArray)

{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)

        Console.Write($"{inArray[i]} ");

    Console.Write("]");
}

int[] array = getArray();
printArray(array);
