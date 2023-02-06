//Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы 
//натуральных элементов в промежутке от M до N.

using static System.Console;
Clear();
WriteLine($"Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}