// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();

int[] array = new int[8];
fillArray(array);
printArray(array);




void fillArray(int[] arrnew)
{
    for(int i = 0; i < arrnew.Length; i++)
    {
        arrnew[i] = new Random().Next(0, 8);
    }
}

void printArray(int[] arrnew)
{
    Write("[");
    for(int i = 0; i < arrnew.Length; i++)
    {
        Write($"{arrnew[i]}");
        if(i < arrnew.Length-1) Write(", ");
    }
    WriteLine("]");
}