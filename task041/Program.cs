// Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter numbers separated by commas: ");
string str = Console.ReadLine();

int[] numbers = StringToNumbers(str);
int count = 0;
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) count++;
}

Console.WriteLine(count);

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] StringToNumbers(string input)
{
    int countNumbers = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        {
            countNumbers++;
        }
    }

    int[] numbers = new int[countNumbers];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tempString = "";

        while(input[i] != ',')
        {
            if(i != input.Length - 1)
            {
                tempString += input[i].ToString();
                i++;
            }
            else
            {
                tempString += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(tempString);
        index++;
    }

    return numbers;
}