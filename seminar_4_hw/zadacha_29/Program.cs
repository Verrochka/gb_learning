// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// В первой строчке 5 элементов, во второй строчке 3 элемента

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
    for (int i = 0; i < 5; i++)
    {
        Console.Write(massiv[i] + " ");
    }
        
        Console.WriteLine();

    for (int i = 5; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
}

int[] array = GetArrayRandom(8);
ShowArray(array);
