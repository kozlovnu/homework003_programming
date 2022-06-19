// Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
// С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. 
// Программа заканчивает свою работу в тот момент, когда решит пользователь.


double usd = Convert.ToDouble(Input("Enter amount of usd: "));
double rur = Convert.ToDouble(Input("Enter amount of rur: "));

double amount = 0; // количество конвертируемой валюты

// курс конвертации
double usd2rur = 56.41;
double rur2usd = 1 / 56.41;

// методы
double Converting(double a, double b) // конвертация
{
    return a * b;
}
string Input(string output) // метод ввода данных
{
    Console.Write(output);
    return Console.ReadLine();
}

bool Condition(string a, string b) // метод условия
    {
        return a == b;
    }

// команды
string exit = "exit";
string usdRur = "usd2rur";
string rurUsd = "rur2usd";
string help = "help";
string balance = "balance";

while(true)
{
    Console.WriteLine("To see existing commans enter 'help'");
    Console.WriteLine();
    string input = Input("Enter your command: ");
    Console.WriteLine();

    if (Condition(input, exit))
    {
        break;
    }
    else if (Condition(input, usdRur))
    {
        amount = Convert.ToDouble(Input("Enter amount of currency to convert: "));
        if (amount <= usd)
        {
            rur = rur + Converting(usd, usd2rur);
            usd = usd - amount;
        }
        else
        {
            Console.WriteLine("You don't have enough money.");
        }

    }
    else if (Condition(input, rurUsd))
    {
        amount = Convert.ToDouble(Input("Enter amount of currency to convert: "));
        if (amount <= rur)
        {
            usd = usd + Converting(rur, rur2usd);
            rur = rur - amount;
        }
        else
        {
            Console.WriteLine("You don't have enough money.");
        }
    }
    else if (Condition(input, help))
    {
        Console.WriteLine("Enter 'exit' for end");
        Console.WriteLine("Enter 'help' to see the list of commands");
        Console.WriteLine("Enter 'usd2rur' to convert usd to rur");
        Console.WriteLine("Enter 'rur2usd' to convert rur to usd");
        Console.WriteLine("Enter 'balance' to see your account balances");
    }
    else if (Condition(input, balance))
    {
        Console.WriteLine("USD: " + usd);
        Console.WriteLine("RUR: " + rur);
    }
    else
    {
        Console.WriteLine($"Command {input} doesn't exist.");
    }
}