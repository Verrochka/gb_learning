// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int AvStepeniB(int num1, int num2)
{
    int aVstepeniB = 1;

    for (int i = 1; i <= num2; i++)
    {
    aVstepeniB = aVstepeniB * num1;
    }
    return aVstepeniB;
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число. Именно в эту степень будет возведено первое записанное Вами число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Первое число, возведенное в степень, равную второму числу, равно {AvStepeniB(num1, num2)}");

