// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все четные числа в промежутке от {1} до {number}: ");

for (int counter = 2; counter <= number; counter++)
if (counter % 2 == 0)
{
    Console.Write($"{counter} ");
    counter++;
}