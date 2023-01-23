// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using static System.Console;
Clear();

Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
WriteLine($"Кол-во элементов > 0: {count}");
