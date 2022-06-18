// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter the number: ");
string number = Console.ReadLine();
int length = number.Length;
int result = 0;
int num = Convert.ToInt32(number);

for (int i = 0; i < length; i++)
{
    int numb = num % 10;
    result += numb;
    num /= 10;
}
Console.WriteLine($"Summ of {number} chars = {result}");

