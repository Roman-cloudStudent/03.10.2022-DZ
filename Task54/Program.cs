// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
SortRowFromMaxToMin(array);
PrintMatrix(array);



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

int[,] SortRowFromMaxToMin(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < newMatrix.GetLength(1) - 1; k++)
            {
                if (newMatrix[i, k] < newMatrix[i, k + 1])
                {
                    int temp = 0;
                    temp = newMatrix[i, k];
                    newMatrix[i, k] = newMatrix[i, k + 1];
                    newMatrix[i, k + 1] = temp;
                }
            }
        }
    }
    return newMatrix;
}