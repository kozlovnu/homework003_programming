// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [4];
FillRandomArray(array);
PrintArray(array);
int countEven = 0;
int countOdd = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) countEven++;
    else countOdd++;

}
Console.WriteLine($"This array contains {countEven} even and {countOdd} odd numbers");

void FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}