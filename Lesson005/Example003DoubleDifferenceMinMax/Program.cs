// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[length];
FillArray(numbers);
WriteArray(numbers);
double min = FindMin(numbers);
double max = FindMax(numbers);
double result = max - min;
Console.WriteLine($"Разница между минимальным {min} и максимальным значением {max} равна {result}");

double FindMax(double[] array)
{
    int maxPos = 0; // max Position
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxPos])
        {
            maxPos = i;
        }
    }
    return array[maxPos];
}
double FindMin(double[] array)
{
    int minPos = 0; // min Position
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPos])
        {
            minPos = i;
        }
    }
    return array[minPos];
}
void FillArray(double[] array)
{
    Console.WriteLine("Заполните массив!");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

}
void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        Console.Write(array[i]);
        if (i + 1 < array.Length)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("]");
        }
    }
    Console.WriteLine();
}
