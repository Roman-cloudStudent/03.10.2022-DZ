// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите два числа для сравнеия");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
 
bool num1 = a > b;
bool num2 = a == b;
bool num3 = a < b;
 
if (num1)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else if (num2)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else if (num3)
{
    Console.WriteLine($"Число {a} меньше {b}");
}
