// Есть программа с бесконечным циклом. Когда пользователь вводит exit 
// программа заканчивается

for (int i = 1; i > 0; i++)
{
    Console.WriteLine(i);
    string input = Console.ReadLine();
    string text = "exit";
    if (input == text)
    {
        break;
    }
}