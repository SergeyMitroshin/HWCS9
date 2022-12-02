/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumElemens (int m, int n)  // с циклом
{
    int result = 0;
        for (int i=m; i<=n; i++) 
            result+=i;
    return result;
}

int SumElemensR(int m,int n)    // с рекурсией
{
    int result = 0;
    if (m<=n)
        result = m + SumElemensR(m+1,n);
    return result;
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);    
// Console.WriteLine("Результат: " + SumElemens(m,n));  // без рекурсии
Console.WriteLine("Результат: " + SumElemensR(m,n)); // с рекурсией
