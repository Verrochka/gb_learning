// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Нужно перейти на новую строку после 5 элемента

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
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i % 5 == 0)
        {
        Console.WriteLine();
        }
        Console.Write(massiv[i] + " ");
    }  
}

int[] array = GetArrayRandom(8);
ShowArray(array);
