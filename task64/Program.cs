//Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех 
//натуральных числел в промежутке от N до 1.

using static System.Console;
Clear();
WriteLine($"апишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.");
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Write(count + ", ");
}

int InputNumbers(string input) 
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}