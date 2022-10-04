/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = CreateRandomArray(4);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов массива: {SummNotEven(array)} ");

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SummNotEven(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        count = count + array[i];
    }
    return count;
}
