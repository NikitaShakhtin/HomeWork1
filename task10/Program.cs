// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using static System.Console;
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
WriteLine("Вы ввели не трехзначное число");
}
else
{
 WriteLine(InCenter(number));
}

int ReadInt(string message)
{
 Write(message);
 return Convert.ToInt32(ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
}