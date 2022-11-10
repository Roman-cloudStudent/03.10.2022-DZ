// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс элемента в строке:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента в столбце:");
int y = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int a, int b, int min, int max)
{
    int[,] myMatrix = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        if (a > 0 && b > 0)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                myMatrix[i, j] = rnd.Next(min, max);
            }
        }

    }
    return myMatrix;
}

bool isElement(int[,] matrix)
{
    return x < rows && x >= 0 && y < columns && y >= 0;
}

void PrintMatrix(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (j < array2d.GetLength(1) - 1)
                Console.Write($"{array2d[i, j],4}, ");
            else Console.Write($"{array2d[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

if (rows > 0 && columns > 0)
{
    int[,] newArray2d = CreateMatrix(rows, columns, 0, 10);
    PrintMatrix(newArray2d);
    Console.WriteLine();
    bool c = isElement(newArray2d);
    if (c) Console.WriteLine($"{x}, {y} -> такой элемент в массиве есть -> {newArray2d[x, y]}");
    else if (x < 0 && y >= 0 && y < columns) Console.WriteLine("Такого элемента в массиве нет. Введите значение индекса строки больше 0.");
    else if (x >= 0 && x < rows && y < 0) Console.WriteLine("Такого элемента в массиве нет. Введите значение индекса столбца больше 0.");
    else if (x < 0 && y < 0) Console.WriteLine("Такого элемента в массиве нет. Введите значение индекса строки и столбца больше 0.");
    else Console.WriteLine($"{x}, {y} -> такого элемента в массиве нет");
}
else if (rows < 0 && columns > 0) Console.WriteLine("Введите значение строки больше 0.");
else if (rows > 0 && columns < 0) Console.WriteLine("Введите значение столбца больше 0.");
else Console.WriteLine("Введите значение строки и столбца больше 0.");