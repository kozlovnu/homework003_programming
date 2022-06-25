// Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int size = Input("Enter amount of numbers: ");

int[] array = new int[size];
int count = 0;
Console.WriteLine("Enter elements of array");
FillArray(array);

for (int i = 0; i < size; i++)
{
    if (array[i] > 0) count++;
}

PrintArray(array);
Console.WriteLine($"Amount of positive numbers in array is {count}");

void FillArray(int[] array)
{
    for (int i = 0; i < size; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}