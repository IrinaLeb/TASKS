// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] randomArray()
{
    int[] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
    }
    return array;
}

void PrintArray(int[] tooArray)
{
    for (int i = 0; i < tooArray.Length; i++)
    
    Console.Write($"{tooArray[i]} ");       
}

void PrintInArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");        
    }
        Console.Write("]");
}
int[] array = randomArray(); 
PrintArray(array);
Console.Write("-> ");
Console.Write("[ ");
PrintInArray(array);