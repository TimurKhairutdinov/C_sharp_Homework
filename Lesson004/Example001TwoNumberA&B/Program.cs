// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string name)
{
    Console.WriteLine($"Введите число {name}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int numberA = InputNumber("A");
int numberB = InputNumber("B");
int result = 1;
for (int i = 0; i < numberB; i++) // 
{   // В первой итерации умножается число 1 на numberA, чтобы в следующей итерации получить прозведение numberA*numberA.
    result = result * numberA; 
}
Console.WriteLine($"{numberA}^{numberB} = {result}");
/* 2*2*2*2 = 16
0*2 = 2
2*2 = 4
4*2 = 8
8*2 = 16
*/