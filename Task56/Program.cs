// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Задайте двумерный массив:");
Console.WriteLine("Введите количество строк массива: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало диапазона случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона случайных чисел: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, col];
CreateMatrix(array);
PrintMatrix(array);
Console.WriteLine();
int minSum = int.MaxValue;
int lineNumber = 0;
Console.WriteLine($"Наименьшая сумма элементов {MinSumOfRowElements(array)} в строке {lineNumber}");

int[,] CreateMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            if (j < myMatrix.GetLength(1) - 1)
            {
                Console.Write($"{myMatrix[i, j],3} , ");
            }
            else
            {
                Console.Write($"{myMatrix[i, j],3} ");
            }
        }
        Console.WriteLine("]");
    }
}

int MinSumOfRowElements(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            sum += newMatrix[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            lineNumber++;
        }
    }
    return minSum;
}