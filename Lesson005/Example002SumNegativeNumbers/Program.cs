// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Создание массива. Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
int start = -99; // задание диапазона рандомных чисел, от 
int end = 100; // до 
RandomFillArray(numbers, start, end); // заполнение массива рандомными числами
WriteArray(numbers);
int qtyOdd = OddNumbers(numbers); // количество нечетных чисел, переменная используется для создания массива нечетных чисел
Console.WriteLine("Количество нечётных чисел: " + qtyOdd);
int[] oddNumbers = new int[qtyOdd]; // создание массива нечетных чисел
// Далее идёт заполнение массива нечетными числами
int j = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        oddNumbers[j] = numbers[i];
        j++;
    }
    else
    {
        continue;
    }
}
WriteArray(oddNumbers);
// Далее используя массив нечётных чисел, суммируем его элементы
int sum = 0;
for (int i = 0; i < oddNumbers.Length; i++)
{
    sum = sum + oddNumbers[i];
}
Console.WriteLine("Сумма нечётных чисел равна: " + sum);
int OddNumbers(int[] array) // Функция считает количество нечётных чисел.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
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






