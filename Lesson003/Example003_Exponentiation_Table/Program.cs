// Задача 23. Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N.
// Внес изменения: при вводе данных, нужно ввести степень возведения, таким образом можно ввести любую степень, не ограничаваясь условием.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сепень возведения: ");
int exponent = Convert.ToInt32(Console.ReadLine()); // Позволяет ввести любую степень, а не только 3 как указано в условии.
int count = 1;
while (count <= number)
{
    int countQuatro = Convert.ToInt32(Math.Pow(count,exponent));
    Console.WriteLine($"{count}^{exponent} = {countQuatro}");
    count++;
}