// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter number m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number n: ");
int n = int.Parse(Console.ReadLine());

if (m > 0 && n > 0)
    Console.WriteLine($"A({m},{n}) = {Akkerman(m,n)}");
else 
    Console.WriteLine("All numbers must be more than zero");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
       return n+1;
    } 
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);  
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n -1));   
    }
    return n;
}