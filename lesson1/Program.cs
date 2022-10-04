/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = CreateRandomArray(4);
PrintArray(array);
PrintNewArray(array);
int nemberOfEvenNumbers = FindEvenNumbers(array);
Console.Write($"Количество чётных чисел в массиве: {nemberOfEvenNumbers}");


int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

void PrintNewArray(int[] array)
{
    Console.Write("Четные числа исходного массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
