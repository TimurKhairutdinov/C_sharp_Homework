// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = 9;
int columns = 9;

int[,] table = new int[rows, columns];

FillArray(table, 0, 10);
PrintArray(table);

string outputResult = string.Empty;
for (int i = 0; i < table.GetLength(1); i++)
{
    double tempResult = 0;
    for (int j = 0; j < table.GetLength(0); j++)
    {
        tempResult += table[j, i];
    }

    tempResult /= rows;
    outputResult += Math.Round(tempResult, 2) + " ";
}

Console.WriteLine("Среднее арифметическое каждого столбца: " + outputResult);


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