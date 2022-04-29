// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= a)
{
    if(i%2!=0) // Проверка на нечётность
    {
        i++;
    }
    else
    {
    Console.Write(i + ", ");
    i++;
    }
}
// Второе решение без проверки на чётность.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// 
// while (i <= a)
// {
//    Console.Write(i + ", ");
//   i+=2;
// }