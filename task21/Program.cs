// .Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

using static System.Console;
Clear();

Write("Точка A1 -> Введите координату x:");
int.TryParse(ReadLine(), out int ax);
Write("Точка A2 -> Введите координату y:");
int.TryParse(ReadLine(), out int ay);
Write("Точка A3 -> Введите координату z:");
int.TryParse(ReadLine(), out int az);

Write("Точка B1 -> Введите координату x:");
int.TryParse(ReadLine(), out int bx);
Write("Точка B2 -> Введите координату y:");
int.TryParse(ReadLine(), out int by);
Write("Точка B3 -> Введите координату z:");
int.TryParse(ReadLine(), out int bz);

double length = Math.Sqrt(Math.Pow(ax-bx),2)+(Math.Pow(ay-by),2)+(Math.Pow((az-bz),2));
WriteLine($"{length:f2}");



    