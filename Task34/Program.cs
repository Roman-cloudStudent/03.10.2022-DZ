// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:");
int number = Convert.ToInt32(Console.ReadLine());

int[] MyArray(int num, int min, int max)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int EvenNumbers(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] arra)
{
    Console.Write("[");
    int size = arra.Length - 1;
    for (int i = 0; i < arra.Length; i++)
    {
        if (i < arra.Length - 1)
        {
            Console.Write($"{arra[i]}, ");
        }
        else
        {
            Console.Write($"{arra[i]}");
        }
    }
    Console.WriteLine("]");
}

int[] array = MyArray(number, 100, 1000);
PrintArray(array);
int x = EvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве -> {x}");