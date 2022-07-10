// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение коэффициента b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента k2: ");
double k2 = double.Parse(Console.ReadLine());

double[] array = {b1, k1, b2, k2};
 
double x = (b1 - b2) / (k2 - k1);

double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, равна {x}, {y}");

