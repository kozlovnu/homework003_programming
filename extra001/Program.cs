// В переменной string есть секретное сообщение, во второй есть пароль. 
// Пользователю программы даётся 3 попытки ввести пароль и увидеть 
// секретное сообщение.

string text = "Secret message";
string password = "Password";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter password: ");
    string input = Console.ReadLine();
    Console.WriteLine("------------------");
    if (input == password)
    {
        Console.WriteLine(text);
        break;
    }
    else
    {
        Console.WriteLine("Wrong password");
        Console.WriteLine();
    }
}