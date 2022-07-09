// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[4,4];
double[] average = new double[4];

FillRandomArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        average[i] += Convert.ToDouble(array[j,i]);
    }
}

PrintAverage(average);

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

void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]/array.Length + " ");
    }
    Console.WriteLine();
}