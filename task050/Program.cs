// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] array = new int[4,4];

FillRandomArray(array);
PrintArray(array);
Console.WriteLine("Enter index of number: ");
int index = int.Parse(Console.ReadLine());
int indexLine = index/10;
int indexColumn = index%10;

if (indexLine >= array.GetLength(0) || indexColumn >= array.GetLength(0)|| indexLine < 0)
{
    Console.WriteLine($"Array doesn't content number with index {index}");
}
else
{
    Console.WriteLine($"Number with index {index} is {array[indexLine,indexColumn]}");
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
