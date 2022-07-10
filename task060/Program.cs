// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array = new int[3,3,3];
int[] numbers = new int[89];

FillArray(array,numbers);
PrintArray(array);

void FillArray(int[,,] array, int[] numbers)
{
    int index = 10;
    for (int i = 1; i < numbers.Length; i++)
    {
        numbers[i] = index++;
    }
    for (int i = 1; i < numbers.Length; i++)
    {
        int randIndex = new Random().Next(0,numbers.Length);
        int temp = numbers[i];
        numbers[i] = numbers[randIndex];
        numbers[randIndex] = temp;
    }

    int numbersIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = numbers[numbersIndex++];
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] - {array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}