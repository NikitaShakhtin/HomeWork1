 // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;
            WriteLine("Введите 3 числа:");
            int num_1 = int.Parse(ReadLine()!);
            int num_2 = int.Parse(ReadLine()!);
            int num_3 = int.Parse(ReadLine()!);

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            WriteLine("Наибольшее из введённых чисел -> " + max);
