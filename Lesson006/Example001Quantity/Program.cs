// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string output = "-1, 25554, -92, 3, 4, -6, 8, -8, 7, 3, 2, -12";

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

int qty = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        qty++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0: {qty}");


