// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Первое решение, где за позицию элемента считается его позиция в таблице,
// если считать по строке, а затем переходя на новую строку.
// 1 2 3 4 5
// 6 7 8 9 10

int rows = 3;
int columns = 5;
int[,] table = new int[rows, columns];

FillArray(table, 0, 100);
PrintArray(table);

Console.Write("Введите позицию элемента: ");
int findPosition = Convert.ToInt32(Console.ReadLine());

// Условие, если заданная позиция отсутствует в массиве.
int sizeTable = rows * columns;
if (findPosition > sizeTable)
{
    Console.WriteLine(
        "Элемент не найден!" + " " +
        "Позиция элемента находится за пределами массива.");
}


int currentPosition = 1;
int result = 0;
bool findStatus = false;
// Перебор массива по циклам, до тех пор пока currentPosition не сравняется с findPosition
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (currentPosition != findPosition)
        {
            currentPosition++;
        }
        else
        {   // Выход из цикла, когда позиция найдена.
            result = table[i, j];
            Console.WriteLine($"Элемент на позиции {findPosition} = {result}");

            // Переменная для указания статуса поиска, нужна для выхода из следующего цикла.
            findStatus = true;
            break;
        }
    }
    // Проверка статуса поиска, чтобы завершить цикл, если элемент найден.
    if (findStatus != false)
    {
        break;
    }
}

void FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}