// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int m = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Int32.Parse(Console.ReadLine());

int [,] matrix = new int[m, n];

int lengthRows = matrix.GetLength(0); 
int lengthColumns = matrix.GetLength(1); 

for (int i = 0; i < lengthRows; i++)
{
    for (int j = 0; j < lengthColumns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);  
        Console.Write(matrix[i, j] + "\t"); 
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < lengthColumns; j++)
{
    double sumColumnsNumbers = 0;
    double columnsNumbersAverage = 0;

    for (int i = 0; i < lengthRows; i++)
    {
    sumColumnsNumbers = sumColumnsNumbers + matrix[i, j]; 
    }
    Console.WriteLine($"Среднее арифметическое элементов {j} столбца равно {Math.Round(columnsNumbersAverage = sumColumnsNumbers / (double)lengthRows, 2)}");
}
