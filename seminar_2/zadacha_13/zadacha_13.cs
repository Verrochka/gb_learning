Console.WriteLine ("Введите любое число до миллиона");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    if (number >=100 && number <1000)
    Console.WriteLine ($"Третья цифра данного числа равна {number % 10}");

    if (number >=1000 && number <10000)
    Console.WriteLine ($"Третья цифра данного числа равна {number / 10 % 10}");

    if (number >=10000 && number <100000)
    Console.WriteLine ($"Третья цифра данного числа равна {number / 100 % 10}");

    if (number >=100000 && number <1000000)
    Console.WriteLine ($"Третья цифра данного числа равна {number / 1000 % 10}");

    if (number >=1000000 && number <1000001)
    Console.WriteLine ($"Третья цифра данного числа равна {number / 10000 % 10}");

    if (number >=1000001)
    Console.WriteLine ($"Вы ввели число больше миллиона. Введите число до миллиона");
}

else
{
    Console.WriteLine ("Третьей цифры в этом числе нет");
}