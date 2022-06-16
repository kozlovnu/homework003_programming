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

// Start of cycle
while (true)
{
    
    // Console.WriteLine(i);
    Console.WriteLine("Enter command");
    string input = Console.ReadLine();
/*
    string exit = "exit";
    string name = "setname";
    string setPswd = "setpassword";
    string writeName = "writename";
    string help = "help";
*/
    if (Condition(input, exit))
    {
        break;
    }
    else if (Condition(input, name))
    {
        Console.WriteLine("Enter username: ");
        userName = Console.ReadLine();
    }
    else if (Condition(input, setPswd))
    {
        if (userName != "null")
        {
            Console.WriteLine("Set your password: ");
            userPassword = Console.ReadLine();
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
            Console.WriteLine("Enter your password: ");
            string Password = Console.ReadLine();
            if (Password == userPassword)
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            if (userPassword == "null")
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }
    }
}