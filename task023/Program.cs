// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < number; i++)
{
    double result = Math.Pow(i,3);
    Console.Write($"{result}, ");
}
Console.WriteLine(Math.Pow(number,3));