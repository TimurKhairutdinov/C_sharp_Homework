// Задача 4. Напишите программу, которая получает три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max > b)
{
    if(max > c)
    {
        Console.Write("Максимальное число: " + max);
    }
    else 
    {
        max = c;
        Console.Write("Максимальное число: " + max);
    }
}
else
{
    max = b;
    if(max > c)
    {
        Console.Write("Максимальное число: " + max);
    }
    else
    {
        max = c;
        Console.Write("Максимальное число: " + max);
    }
}