// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter number m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($" Sum of numbers from {m} to {n} is {NumbersSum(m,n)}");

int NumbersSum(int m, int n)
{
    if (m == n)
    {
       return n;
    } 
    if (m < n)
    {
        return n += NumbersSum(m, n - 1);  
    }
    if (m > n)
    {
        return n += NumbersSum(m, n + 1);
        
    }

    return n;
}