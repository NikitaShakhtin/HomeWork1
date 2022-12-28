// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.   
using static System.Console;
Clear();

Write("Введите число для ввода таблицы квадратов от 1 до числа:");
int.TryParse(ReadLine(), out int n);

for (int i=1; i<n+1; i++)
{
   WriteLine($"Куб числа {i} = {Math.Pow(i,3)}");
}
