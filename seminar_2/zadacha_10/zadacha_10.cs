Console.WriteLine ("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.WriteLine ($"Вторая цифра данного числа равна {number / 10 % 10}");
}

else
{
    Console.WriteLine ("Проверьте, что Вы ввели именно трехзначное число. Там должно быть 3 цифры:)");
}