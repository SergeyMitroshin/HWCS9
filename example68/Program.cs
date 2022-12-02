/*
Задача 68: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int m, int n)
{
  int result = 0;
  if (m == 0)
    result = n + 1;
  else
    if ((m != 0) && (n == 0))
      result = Akkerman(m - 1, 1);
    else
      result = Akkerman(m - 1, Akkerman(m, n - 1));
  return result;
}

Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Результат: " + Akkerman(m,n));
