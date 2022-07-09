// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Enter amount of Lines matrixA: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter amount of Columns matrixA: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter amount of Lines matrixB: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter amount of Columns matrixB: ");
int b = int.Parse(Console.ReadLine());

int[,] matrixA = new int[m,n];
int[,] matrixB = new int[a,b];
int[,] multiplication = new int[m,b];

FillRandomArray(matrixA);
FillRandomArray(matrixB);
Console.WriteLine("MatrixA: ");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("MatrixB: ");
PrintArray(matrixB);
Console.WriteLine();
if (n != a) Console.WriteLine("Cannot multiply matrixes");
else
{
    MultiplyMatrix(matrixA, matrixB, multiplication);
    Console.WriteLine("Multiplicated matrix:");
    PrintArray(multiplication);
}


void MultiplyMatrix(int[,] arrayA, int[,] arrayB, int[,] multiply)
{
    
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                multiply[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
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