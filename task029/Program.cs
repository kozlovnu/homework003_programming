// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter the amount of massive elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] number = new string[size];

for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine($"Enter {i+1} number: ");
    number[i] = Console.ReadLine();
}

Output(number);

void Output(string[] a)
{
    for (int i = 0; i < a.Length-1; i++)
    {
  
        Console.Write($"{a[i]}, ");
    }
    Console.WriteLine(number[size-1]);
}