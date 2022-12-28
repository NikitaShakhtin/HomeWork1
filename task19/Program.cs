//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

WriteLine("Введите число: ");
string number = ReadLine();
int len = number.Length;

if (len == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 WriteLine($"{number} - Палиндром");
    }
 else
    {
 WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
