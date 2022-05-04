// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет является этот день выходным.

Console.WriteLine("Введите число от 1 до 7 соответствующему дню недели");
int day = Convert.ToInt32(Console.ReadLine());
Week(day);

void Week(int day)
{
    int monday = 1;
    int tuesday = 2;
    int wednesday = 3;
    int thursday = 4;
    int friday = 5;
    int saturday = 6;
    int sunday = 7;
    if(day!=0)
    {
        if(day <= 7)
        {
            if (day == monday) Console.WriteLine("Понедельник"); 
            if (day == tuesday) Console.WriteLine("Вторник"); 
                if (day == wednesday) Console.WriteLine("Среда"); 
            if (day == thursday) Console.WriteLine("Четверг"); 
            if (day == friday) Console.WriteLine("Пятница"); 
            if (day == saturday) Console.WriteLine("Суббота выходной"); 
            if (day == sunday) Console.WriteLine("Воскресенье выходной"); 
        }
        else Console.Write("Введенное число больше 7");
    }
    else Console.WriteLine("Вы ввели 0");
}
