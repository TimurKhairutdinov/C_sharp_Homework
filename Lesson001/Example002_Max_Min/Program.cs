// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    if(a > b)
    { 
        max = a;
        min = b;
        Console.WriteLine("Максимальное число: " + max);
        Console.WriteLine("Минимальное число: " + min);
    }
    else
    {
        max = b;
        min = a;
        Console.WriteLine("Максимальное число: " + max);
        Console.WriteLine("Минимальное число: " + min);
    }
}