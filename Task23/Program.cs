// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) TableOfDigits(number);
else Console.WriteLine("Введите число больше 0");


void TableOfDigits(int digit)
{
    for (int count = 1; count <= digit; count++)
    {
        Console.WriteLine($"|{count,4}|{Math.Pow(count, 3),4}|");
    }
}

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);