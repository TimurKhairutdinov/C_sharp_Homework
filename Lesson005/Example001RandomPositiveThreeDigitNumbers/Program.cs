// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Создание массива. Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int start = 0;
int end = 1000;
int[] numbers = new int[sizeArray];
RandomFillArray(numbers, start, end);
WriteArray(numbers);
int result = EvenNumbers(numbers);
Console.WriteLine("Количество чётных чисел в массиве: " + result);

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void RandomFillArray(int[] array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }

}
void WriteArray(int[] array)
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
            Console.Write(",");
        }
        else
        {
            Console.Write("]");
        }
    }
    Console.WriteLine();
}