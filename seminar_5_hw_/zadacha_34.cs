//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int EvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 10 == 0)
        {
        Console.WriteLine();
        }
        Console.Write(array[i] + " ");
    }  
}

int[] array = GetArray(50, 100, 999);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в данном массиве равно {EvenNumbers(array)}.");


