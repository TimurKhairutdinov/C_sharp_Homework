// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


string str = Convert.ToString(new Random().Next(0,10000)); // random
string numbers = Console.ReadLine(); // input

void ThirdNumber(string number)
{                                                     
    if (number.Length >= 3) Console.Write(number[2]); 
    else Console.Write("Число состоит менее, чем из трёх цифр");
}

ThirdNumber(numbers);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(str);
ThirdNumber(str);