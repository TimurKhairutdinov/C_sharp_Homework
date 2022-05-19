// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputNumber(string name)
{
    Console.WriteLine($"Введите число {name}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = InputNumber("");
int result = 0;
int remainder;
while (number != 0)
{
    remainder = number % 10;    // 452%10 = 2 // 45%10 = 5 // 4%10 = 4
    result += remainder;        // 0 = 0+2     // 2 = 2+5   // 7 = 7+4
    number = number / 10;       // 452/10 = 45 // 45/10 = 4 // 4/10 = 0
}
Console.WriteLine($"Ответ: {result}");