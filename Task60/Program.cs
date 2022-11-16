// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Задайте трёхмерный массив:");
Console.Write("Введите первое измерение: ");
int firstDim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе измерение: ");
int secondDim = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье измерение: ");
int thirdDim = Convert.ToInt32(Console.ReadLine());
if (firstDim * secondDim * thirdDim > 99)
{
    Console.WriteLine("Превышен предел значений элементов по условию задачи");
    return;
}
CreateThreeDimesionMatrix(firstDim, secondDim, thirdDim);


int[,,] CreateThreeDimesionMatrix(int row, int column, int depth)
{
    int[,,] matrix = new int[row, column, depth];
    int numbers = row * column * depth;
    int arrayIndex = 0;
    int startNumber = 10;
    int[] myArray = new int[numbers];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = startNumber++;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = myArray[arrayIndex++];
                Console.Write($" {matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return matrix;
}