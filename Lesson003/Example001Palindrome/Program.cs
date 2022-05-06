// Зададча 19. Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string numberPal = Console.ReadLine();
if (numberPal.Length < 5 || numberPal.Length > 5)
{
    Console.WriteLine("<ERROR> Введенноё число не соответствует требованию пятизначного числа!");
    return;
}

if (numberPal[0] == numberPal[4] && numberPal[1] == numberPal[3])           //  0 == 4 , 1 == 3, // ? 2 == 2.
{
    Console.WriteLine("Число является палиндромом");

}
else
{
    Console.WriteLine("Число не является палиндромом");
}


Console.Write(numberPal);