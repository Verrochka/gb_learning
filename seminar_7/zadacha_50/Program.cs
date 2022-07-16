// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
        matrix[i, j] = new Random().Next(-100, 100);  
        Console.Write(matrix[i, j] + "\t"); 
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки элемента. Отсчет начинается со строки 0");
int indexRow = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента. Отсчет начинается со столбца 0");
int indexColumn = Int32.Parse(Console.ReadLine());

if (indexRow > lengthRows - 1 || indexColumn > lengthColumns - 1)
{
    Console.WriteLine("К сожалению, такого элемента в данном массиве не существует. Вы вышли за границы массива");
    Console.WriteLine($"Вам нужно ввести номер строки не более {lengthRows - 1}, а номер столбца не более {lengthColumns - 1}");
}

Console.WriteLine($"Искомый элемент массива {matrix[indexRow, indexColumn]}");