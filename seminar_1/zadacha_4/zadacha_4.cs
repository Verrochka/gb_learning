int number1 = 2;
int number2 = 3;
int number3 = 7;
int max_number = number1;
if (number2 > max_number)
{
    max_number = number2;
}
if (number3 > max_number)
{
    max_number = number3;
}
Console.WriteLine($"max = {max_number}");
