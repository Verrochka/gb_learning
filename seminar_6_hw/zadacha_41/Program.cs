// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел вы хотите ввести? Напишите: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];

Console.WriteLine("\nДалее мы попросим вас ввести числа. Помните, они могут быть как положительными, так и отрицательными.");
Console.WriteLine("Следите, чтобы они не были дробными. Принимаются только целые числа");

// не получилось код с 12 по 22 строчки сделать функцией(( - пишет, что там что-то куда-то не возвращает
// int[] KeyboardInput(int number) - вот так пыталась
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) 
        {
        Console.Write("\nВведите последнее число: ");
        array[i] = int.Parse(Console.ReadLine());
        break;
        }
    Console.Write("\nВведите число: ");
    array[i] = int.Parse(Console.ReadLine());
    }

int PositiveNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write($"\nКоличество введенных вами положительных чисел равно {PositiveNumbersCount(array)}");
