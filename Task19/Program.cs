// Задача №19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int fiveDigit = Math.Abs(Convert.ToInt32(Console.ReadLine()));  

if (fiveDigit >= 10000 && fiveDigit < 100000)
    if (FiveDigitNumber(fiveDigit))
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
else
    Console.WriteLine("Введённое число не пятизначное! Введите пятизначное число.");

bool FiveDigitNumber(int number)
{
    bool result = number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10;
    return result;
}