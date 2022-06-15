// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Решение 1.
int m = 4;
int n = 3;

double[,] newArray = new double[m,n];
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i,j] = new Random().Next(0,100);
        newArray[i,j] /= 10;
    }
}
PrintArray(newArray);

// Решение 2.
int rows = 4;
int columns = 4;

double[,] table = new double[rows, columns];

DoubleNumbersFillArray(table);

PrintArray(table);

void PrintArray(double[,] arr)
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

void DoubleNumbersFillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double temp = new Random().NextDouble();
            arr[i, j] = Math.Round(temp, 3);
        }
    }
}