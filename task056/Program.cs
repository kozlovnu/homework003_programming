// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[5,3];
int[] sum = new int[array.GetLength(0)];
FillRandomArray(array);
PrintArray(array);
FindSum(array,sum);

void FindSum(int[,] array, int[] sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
        Console.WriteLine($"Sum of elements line {i} = {sum[i]}");
    }
    int min = sum[0];
    int index = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (min > sum[i])
        {
            min = sum[i];
            index = i;
        }
        
    }
    Console.WriteLine($" Line {index} is the line with the smallest sum of elements");
}

void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}