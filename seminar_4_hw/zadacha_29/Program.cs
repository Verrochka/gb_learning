// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

void ShowArray(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write(item + " ");
    }
}

int[] array = GetArrayRandom(8);
ShowArray(array);