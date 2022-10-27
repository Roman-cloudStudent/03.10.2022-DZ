// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива:");
int number = Convert.ToInt32(Console.ReadLine());

int[] MyArray(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1)
        {
            Console.Write($"{newArray[i]}, ");
        }
        else
        {
            Console.Write($"{newArray[i]}");
        }
    }
    Console.WriteLine("]");
}

int SumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != 0 && i % 2 != 0)
            sum += arr[i];
    }
    return sum;
}

int[] arrayOfMine = MyArray(number, 0, 100);
PrintArray(arrayOfMine);
int sum = SumOfElements(arrayOfMine);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях -> {sum}");