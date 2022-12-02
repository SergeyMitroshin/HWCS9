/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintElement (int n)
{
   if (n>0)
    {
    if (n>1) Console.Write(n + ", ");
         else Console.WriteLine (n);
    PrintElement(n-1);
    } 
}

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Результат: ");
PrintElement(n);