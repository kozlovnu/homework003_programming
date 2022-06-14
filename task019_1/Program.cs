// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five-digit number: ");
string number = Console.ReadLine();
Console.WriteLine("----------");

int length = number.Length;
int result = 0;
/*
int count = 0;
while(count < length-1)
{
    if (number[count] == number[length-1])
    {
        count ++;
        length --;
        Console.WriteLine("yes");
    }
    
    else
    {
        {
            Console.WriteLine("no");
            break;
        }
    }
}

*/


for (int i = 0; i < length-1; i ++)
{
    if(number[i] == number[length-1])
    {
        length --;
        result = 1;
        // Console.WriteLine("yes");
    }
    else
    {
        result = 0;
        //Console.WriteLine("no");
        break;
    }
}

if (result == 1)
{
    Console.WriteLine("It's a polindrome");
}
else
{
    Console.WriteLine("It's NOT a polindrome");
}