// Игра угадайка. Программа загадывает случайное число. 
// Пользователь его угадывает. Если пользователь дает неправильный ответ, 
// то программа сообщает, больше загаданное число или меньше. 
// На отгадывание дается 3 попытки.

int rnd = new Random().Next(1,100);
Console.WriteLine(rnd);
for (int i = 1; i < 5; i++)
{
    if (i<4)
    {
        Console.WriteLine("Enter your number: ");
        int number = Convert.ToInt32(Console.ReadLine());
    
        if (number == rnd)
        {
            Console.WriteLine("You win!");
            Console.WriteLine($"You guessed by {i} attempts");
            break;
        }
    
        else if (number < rnd)
        {
            Console.WriteLine("The number is bigger");
            Console.WriteLine();
        }
        else if (number > rnd)
        {
            Console.WriteLine("The number is smaller");
            Console.WriteLine();
        }

    }
    else
    {
        Console.WriteLine("You loose");
    }
}