// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear();

WriteLine("Введите первое число");
double number1 = Convert.ToDouble(ReadLine());
WriteLine("Введите второе число");
double number2 = Convert.ToDouble(ReadLine());
double result = exponentiation(number1, number2);
WriteLine(result);




double exponentiation(double number1a, double number2a)
{   
    double result1 = Math.Pow(number1a, number2a);
    return result1;
}
