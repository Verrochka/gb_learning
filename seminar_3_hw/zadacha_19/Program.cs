// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Здесь важный момент, как перевести число в массив одной строчкой. Строка 6.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
int n = digitArray.Length;

if (n == 5 && digitArray[0] == digitArray[4] && digitArray[1] == digitArray[3])
{
    Console.WriteLine("Это число является палиндромом, т.е. оно читается одинаково справа налево и слева направо");
}

else if (n == 5 && digitArray[0] != digitArray[4] || digitArray[1] != digitArray[3])
{
    Console.WriteLine("Это число не является палиндромом");
}

else if (n != 5)
{
    Console.WriteLine("Вы ввели неверное число. Подсказка: пятизначное число - это когда в числе содержится 5 цифр)");
}