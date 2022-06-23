// Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – 
// первая добавляет к числовому массиву значение, тем самым увеличивая массив, 
// а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

int size = Input("Enter the length of array: ");
int[] array = new int[size];
int[] addArray = new int[size+1];
int[] removeArray = new int[size-1];
int add = 0;
FillRandomArray(array);
PrintArray(array);

AddToArray(array, addArray);

PrintArray(addArray);

RemoveFromArray(array, removeArray);


void RemoveFromArray(int[] array, int[] removeArray)
{
    add = Input("Enter the number index to remove: ");
    if (add >= 0 && add < array.Length)
    {
        if (add == 0)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                removeArray[i] = array[i+1];
            }
        }
        else 
        {
            for (int i = 0; i < add; i++)
            {
                removeArray[i] = array[i];
            }
            for (int i = add; i < array.Length-1; i++)
            {
                removeArray[i] = array[i+1];
            }
        }
        PrintArray(removeArray);
    }
    
    else Console.WriteLine($"There is no number with index {add}");
}

void AddToArray(int[] array, int[] addArray) // добавить массив
{
    add = Input("Enter the number to add: ");
    for (int i = 0; i < array.Length; i++)
    {
        addArray[i] = array[i];
        addArray[size] = add;
    }
    
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}