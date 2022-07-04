// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
int n = digitArray.Length;

int Sum(int num)
{
    int sum = 0;

    for (int i = 0; i < n; i++)
    {
    sum = sum + digitArray[i];
    }
    return sum;
}

Console.WriteLine($"Сумма цифр данного числа равна {Sum(number)}");