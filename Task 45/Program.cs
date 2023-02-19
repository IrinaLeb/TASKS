// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 

int[] CopyArray(int[] arr)
{
int[] newArr = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
newArr[i] = arr[i];
}
return newArr;
}

int[] array = { 1, 2, 3, 55 };

Console.Clear();
int[] tooArray = CopyArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", tooArray));