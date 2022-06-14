// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------");


/*
Console.WriteLine("second " + number / 1000 % 10); // вторая
Console.WriteLine("first " + number / 10000); // первая цифра
Console.WriteLine("last " + number % 10); // последняя
Console.WriteLine("fourth " + number / 10 % 10); // предпоследняя
*/


if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine("The number is polindrome");
}
else if (number > 9999 && number < 100000)
{
    Console.WriteLine("The number is NOT polindrome");
}
else
{
    Console.WriteLine("Your number is out of range");
}