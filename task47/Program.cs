// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;
Clear();

WriteLine("Введите количество строк ");
int м= Convert.ToInt32(ReadLine());
WriteLine("Введите количество столбцов");
int n= Convert.ToInt32(ReadLine());
float[,] Create2DFloatArray(int hight, int length, int min, int max)
{
    float[,] towDimFloatArray = new float[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            towDimFloatArray[i, j] = new Random().Next(min, max);
            towDimFloatArray[i, j] *= new Random().NextSingle();

        }
    }

    return towDimFloatArray;
}

void Print2DFloatArray(float[,] myArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}
float[,] myFloatArray = Create2DFloatArray(3, 4, -10, 10);
Print2DFloatArray(myFloatArray);
Console.WriteLine();
