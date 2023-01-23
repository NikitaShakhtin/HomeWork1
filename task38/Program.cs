
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Clear();

        Write("Ввудите размер массива");
        int n = Convert.ToInt32(ReadLine());
        int[] mass = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            mass[i] = rnd.Next(-50, 50);
            Write($" {mass[i]} ");
        }
        int min = 0;
        int max = 0;
        foreach (int i in mass)
        {
            if (min > i) min = i;
            if (max > i) max = i;
        }
        Write($"\n Максимвльный элемент: {max}\n Минимальный элемент: {min}");
        Write($"Разница между максимальным и минимальным элементом: {max - min}");
    }
}