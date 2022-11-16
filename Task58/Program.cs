// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Задайте двумерный массив:");
Console.Write("Введите количество строк матрицы 1: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы 2: ");
int str2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int col2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона случайных чисел: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myMatrix1 = new int[str1, col1];
int[,] myMatrix2 = new int[str2, col2];
int[,] matrixResult = new int[str1, col2];
CreateMatrix1(myMatrix1);
Console.WriteLine("Матрица А:");
PrintMatrix(myMatrix1);
Console.WriteLine();
CreateMatrix2(myMatrix2);
Console.WriteLine("Матрица В:");
PrintMatrix(myMatrix2);
Console.WriteLine();
if (col1 == str2)
{
    Console.WriteLine("Произведение двух матриц - матрица С:");
    PrintMatrix(MultiplyMatrix(myMatrix1, myMatrix2));
}
else
{
    Console.WriteLine($"Нельзя перемножить матрицы! Количество столбцов матрицы A не равно количеству строк матрицы B");
}



int[,] CreateMatrix1(int[,] matrix1)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max);
        }
    }
    return matrix1;
}

int[,] CreateMatrix2(int[,] matrix2)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max);
        }
    }
    return matrix2;
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

int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matrix3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                matrix3[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return matrix3;
}