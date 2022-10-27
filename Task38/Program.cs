// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива:");
int number = Convert.ToInt32(Console.ReadLine());


double[] MyArray(int num, double min, double max)
{
    var rnd = new Random();
    double[] array = new double[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] myNewArray)
{
    Console.Write("[");
    for (int i = 0; i < myNewArray.Length; i++)
    {
        if (i < myNewArray.Length - 1)
        {
            Console.Write($"{myNewArray[i]}, ");
        }
        else
        {
            Console.Write($"{myNewArray[i]}");
        }
    }
    Console.WriteLine("]");
}


double DifferenceMaxAndMin(double[] newArray)
{
    double maximum = newArray[0];
    double minimum = newArray[0];

    for (int i = 1; i < newArray.Length; i++)
    {
        if (minimum > newArray[i])
        {
            minimum = newArray[i];
        }
        if (maximum < newArray[i])
        {
            maximum = newArray[i];
        }
    }
    double diff = maximum - minimum;
    return diff;
}


double[] arr = MyArray(number, 0.0, 100.0);
PrintArray(arr);
double summary = DifferenceMaxAndMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива => {summary}");