// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;
Clear();

Write("Введите k1: ");
var k1 = Convert.ToDouble(ReadLine());
Write("Введите b1: ");
var b1 = Convert.ToDouble(ReadLine());
Write("Введите k2: ");
var k2 = Convert.ToDouble(ReadLine());
Write("Введите b2: ");
var b2 = Convert.ToDouble(ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
WriteLine($"Пересечение в точке: ({x};{y})");
