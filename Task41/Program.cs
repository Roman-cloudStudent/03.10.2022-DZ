// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
int number = Convert.ToInt32(Console.ReadLine());

int HowManyNumbersGreaterZero(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число:");
        int y = Convert.ToInt32(Console.ReadLine());
        if (y > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintCount(int z)
{
    Console.WriteLine($"Пользователь ввел чисел больше 0 -> {z}");
}

int countNumbers = HowManyNumbersGreaterZero(number);
PrintCount(countNumbers);