// Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, 
// когда пишем exit еще 4 команды (их можно придумать самому). Например:
// SetName – Установить имя
// Help – вывести список команд
// SetPassword – Установить пароль
// Exit – выход
// WriteName – вывести имя после ввода пароля


Console.WriteLine("To display the list of commands enter 'Help'");
string userName = "null";
string userPassword = "null";

string exit = "exit";
string name = "setname";
string setPswd = "setpassword";
string writeName = "writename";
string help = "help";

// methods
bool Condition(string a, string b) 
    {
        return a == b;
    }
string Input(string output)
{
    Console.Write(output);
    return Console.ReadLine();
}
// Start of cycle
while (true)
{
    
    string input = Input("Enter command: ");

    if (Condition(input, exit))
    {
        break;
    }
    else if (Condition(input, name))
    {
        userName = Input("Enter username: ");
    }
    else if (Condition(input, setPswd))
    {
        if (userName != "null")
        {
            userPassword = Input("Set your password: ");
        }
        else
        {
            Console.WriteLine("You should set user name at first. Enter command 'setname'");
        }
    }
    else if (Condition(input, help))
    {
        Console.WriteLine("Enter 'exit' for end");
        Console.WriteLine("Enter 'setname' to set user name");
        Console.WriteLine("Enter 'setpassword' to set the password");
        Console.WriteLine("Enter 'writename' to display username after entering password");
    }
    else if (Condition(input, writeName))
    {
        if (userPassword == "null")
        {
            Console.WriteLine($"Hello, {userName}!");
        }
        
        else
        {
            string Password = Input("Enter your password: ");
            if (Password == userPassword)
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else if (userPassword == "null")
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }
    }
    else
    {
        Console.WriteLine("Unknown command. To display the list of commands enter 'help'");
    }
}