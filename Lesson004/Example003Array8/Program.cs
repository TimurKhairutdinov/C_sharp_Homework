// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заволнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

// int[] array = new int[8];

// RandomArray(array, 0, 100);

// void RandomArray(int[] array, int start, int end)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(start, end);
//         if (i == 0)
//             Console.Write("[");
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверка если цикл последний, то запятую не ставит.
//             Console.Write(",");
//         else
//             Console.Write("]");
//     }
//     Console.WriteLine();
// }

string output = Console.ReadLine();

int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
        countNumbers++;
}

int[] numbers = new int[countNumbers];
int numberIndex = 0;
for (int i = 0; i < output.Length; i++)
{
    string subString = String.Empty;
    while (output[i] != ',')
    {
        if (i != output.Length - 1)
        {
            subString += output[i].ToString();
            i++;
        }
        else
        {
            subString += output[i].ToString();
            break;
        }
    }

    if (subString == "" || subString == " ")
        continue;

    if (i != output.Length - 1)
    {
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }
    else numbers[numberIndex] = Convert.ToInt32(subString);
}

PrintArray(numbers);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


