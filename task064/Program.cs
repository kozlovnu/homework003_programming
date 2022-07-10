// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Enter number: ");
int m = int.Parse(Console.ReadLine());
int n = 1;
Console.WriteLine(Numbers(m,n));

int Numbers(int m, int n)
{
    if (m == n)
    {
       return n;
    } 
    if (m < n)
    {
        Console.Write($"{Numbers(m, n - 1)}, ");
    }
    if (m > n)
    {
        Console.Write($"{Numbers(m, n + 1)}, ");
    }

    return n;
}


/*
int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
Console.WriteLine(Numbers(m, n));
 
int Numbers(int m, int n)
{
    if (m == n)
    {
       return n;
    } 
    if (m < n)
    {
        Console.Write($"{Numbers(m, n - 1)}, ");
    }
    if (m > n)
    {
        Console.Write($"{Numbers(m, n + 1)}, ");
    }

    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/