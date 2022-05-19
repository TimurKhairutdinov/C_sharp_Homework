// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

int[] array = new int[8];
RandomArray(array, 0, 100);
void RandomArray(int[] array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
        if (i == 0)
            Console.Write("[");
        Console.Write(array[i]);
        if (i < array.Length - 1) // Проверка если цикл последний, то запятую не ставит.
            Console.Write(",");
        else
            Console.Write("]");
    }
    Console.WriteLine();
}


// так и не понял как решить через string
// плюс проблемы с конвертацией из  в string в int

/* string arrayStr = Console.ReadLine();
//int[] newArray = new int[arrayStr.Length];
int[] newArray = new int[arrayStr.Length];
for (int i = 0; i < arrayStr.Length; i++)
{
    if (arrayStr[i] != ',' || arrayStr[i] != ' ')
    {
        Console.Write(arrayStr[i]);
        newArray[i] = Convert.ToInt32(arrayStr[i]);
        Console.Write(newArray[i]);
    }

}

Console.WriteLine(newArray.Length);
 */