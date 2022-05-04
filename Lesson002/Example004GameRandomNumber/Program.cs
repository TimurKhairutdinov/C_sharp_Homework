// Угадайка.

int random = new Random().Next(0, 101);
Console.WriteLine("Игра - угадайте число от 0 до 100!");
Console.Write("Press enter ");
Console.ReadLine();
Console.WriteLine("Введите желаемое количество попыток: ");
int how = Convert.ToInt32(Console.ReadLine()); // Не вводить 0 :)
Console.WriteLine();
int count = 0;
while (count < 101)
{
    count++;
    Console.Write("Попытка: " + count + " ");
    Console.Write("Ваше число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > random) Console.WriteLine("Число больше загаданного");
    if (number < random) Console.WriteLine("Число меньше загаданного");
    if (number == random)
    {
        Console.WriteLine();
        Console.WriteLine("Win!");
        break;
    }
    if (count == how)
    {
        Console.WriteLine();
        Console.WriteLine("Вы использовали все попытки.");
        Console.WriteLine("Загаданное число: " + random);
        break;
    }
    Console.WriteLine();
}
Console.WriteLine("Попыток: " + count);