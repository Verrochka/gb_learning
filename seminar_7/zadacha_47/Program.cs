// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк");
int m = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Int32.Parse(Console.ReadLine());

double [,] matrix = new double[m, n];

int lengthRows = matrix.GetLength(0); // чтобы программа работала быстрее, оптимизация
int lengthColumns = matrix.GetLength(1); // введение переменных перед циклом. Это актуально, если цикл очень большой

for (int i = 0; i < lengthRows; i++)
{
    for (int j = 0; j < lengthColumns; j++)
    {
        matrix[i, j] = new Random().NextDouble() * 10; // массив вещественных чисел от 0 до 10
        Console.Write(Math.Round(matrix[i, j], 2) + "\t"); // литерал t - tab. 
    }
    Console.WriteLine(); // Переход на новую строку
}
