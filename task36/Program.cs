// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.


using static System.Console;
Clear();

WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Write(numbers[i] + " ");
        }
    Write("]");
    WriteLine();
}