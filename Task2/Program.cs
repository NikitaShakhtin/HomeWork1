// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
            WriteLine("Введите первое число: ");
            int A = int.Parse(ReadLine()!);

           WriteLine("Введите второе число: ");
            int B = int.Parse(ReadLine()!);

            if (A > B)
            {
                WriteLine("Первое число " + A + " больше чем второе " + B);
            }
            else
            {
                WriteLine("Второе число " + B + " больше чем первое " + A);
            }
