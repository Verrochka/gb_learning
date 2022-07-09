//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}

double DiffMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
            max = array[i];
            }
            if (array[i] < min)
            {
            min = array[i];
            }
        }
    double diff = max - min;
    return diff;
}

void PrintArray(double[] array)
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
double[] array = GetArray (20);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMinMax(array)}.");