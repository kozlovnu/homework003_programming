// Задача 62: Заполните спирально массив 4 на 4.

int n = 4;
int[,] array = new int[n,n];
int number = 1;
int i = 0;
int j = 0;

while(number <= n * n)
{
    array[i, j] = number;
    if(i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
    number++;
}

PrintArray(array);

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