Console.WriteLine ("Введите число, обозначающее день недели. Например, 1 - это понедельник, 2 - это вторник. И т.д. 7 - это воскресенье");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number < 6)
{
    Console.WriteLine ("Это будний день");
}

if (number >=6 && number < 8)
{
    Console.WriteLine ("Это выходной день");
}

if (number > 7)
{
    Console.WriteLine ("Вы ввели число, которое не соответствует ни одному из дней недели");
}