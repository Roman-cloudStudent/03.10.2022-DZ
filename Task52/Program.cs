// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int y = Convert.ToInt32(Console.ReadLine());

int[,] Matrix(int a, int b, int min, int max)
{
    int[,] myMatrix = new int[a, b];
    Random rnd = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rnd.Next(min, max);
        }
    }
    return myMatrix;
}

double[] AverageInColumn(int[,] myMatrix)
{
    double[] sum = new double[y];

    for (int j = 0; j < myMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            sum[j] += myMatrix[i, j];
        }

        sum[j] /= x;
    }
    return sum;
}

void PrintMyArray(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            if (j < myMatrix.GetLength(1) - 1)
            {
                Console.Write($"{myMatrix[i, j],3}, ");
            }
            else
            {
                Console.Write($"{myMatrix[i, j],3}");
            }
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] sum)
{
    Console.Write("[");
    for (int i = 0; i < sum.Length; i++)
    {
        if (i < sum.Length - 1)
        {
            Console.Write($"{Math.Round(sum[i], 1),3}, ");
        }
        else
        {
            Console.Write($"{Math.Round(sum[i], 1),3}");
        }
    }
    Console.WriteLine("]");
}

int[,] newMyMatrix = Matrix(x, y, 0, 10);
PrintMyArray(newMyMatrix);
Console.WriteLine();
double[] summary = AverageInColumn(newMyMatrix);
Console.Write($"Среднее арифметическое каждого столбца -> ");
PrintArray(summary);