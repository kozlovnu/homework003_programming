// Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, 
// когда пишем exit еще 4 команды (их можно придумать самому). Например:
// SetName – Установить имя
// Help – вывести список команд
// SetPassword – Установить пароль
// Exit – выход
// WriteName – вывести имя после ввода пароля

string userPassword = "null";
Console.WriteLine("To display the list of commands enter 'Help'");
string userName = "user";

for (int i = 1; i > 0; i++)
{
    // Console.WriteLine(i);
    Console.WriteLine("Enter command");
    string input = Console.ReadLine();

    string exit = "Exit";
    string name = "SetName";
    string setPswd = "SetPassword";
    string writeName = "WriteName";
    string help = "Help";

    if (input == exit)
    {
        break;
    }
    else if (input == name)
    {
        Console.WriteLine("Enter username: ");
        userName = Console.ReadLine();
    }
    else if (input == setPswd)
    {
        Console.WriteLine("Set your password: ");
        userPassword = Console.ReadLine();
    }
    else if (input == help)
    {
        Console.WriteLine("Enter 'Exit' for end");
        Console.WriteLine("Enter 'SetName' to set user name");
        Console.WriteLine("Enter 'SetPassword' to set the password");
        Console.WriteLine("Enter 'WriteName' to display username after entering password");
    }
    else if (input == writeName)
    {
        
        Console.WriteLine("Enter your password: ");
        string Password = Console.ReadLine();
        if (Password == userPassword)
        {
            Console.WriteLine($"Hello, {userName}!");
        }
        else if (userPassword == "null")
        {
            Console.WriteLine("You did not set your password");
        }
        else
        {
            Console.WriteLine("Incorrect password");
        }
    }
}