// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using static System.Console;
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Write(MakeArray(number, count));

int ReadInt(string message)
{
    Write(message);
    return Convert.ToInt32(ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}