// See Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();
WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
int result = SumOfTheDigitNumber(number);
WriteLine(result);




int SumOfTheDigitNumber(int number1)
{
    int result1 = 0;
    while(number1 > 0)
    {
        result1 = result1 + number1 % 10;
        number1 = number1 / 10;
    }
    return result1;
}