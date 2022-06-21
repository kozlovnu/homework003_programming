// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int [5];
FillRandomArray(array);
PrintArray(array);

int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) min = array[i];
    else if (max < array[i]) max = array[i];
}
int result = max - min;

Console.WriteLine($"The difference between max and min array elements = {result}");

void FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}