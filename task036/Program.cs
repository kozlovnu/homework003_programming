// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
FillRandomArray(array);
PrintArray(array);
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) sum += array[i];
}
Console.WriteLine($"Sum of odd array elements = {sum}");


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