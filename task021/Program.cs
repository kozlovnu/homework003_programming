// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

int Input(string output) // метод ввода 
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Distance(int a, int b) // метод нахождения расстояния между точками
{
    return a - b;
}

int Square (int a) // метод для нахождения квадрата
{
    return a * a;
}

int x1 = Input("Enter coordinate х1: ");
int y1 = Input("Enter coordinate y1: ");
int z1 = Input("Enter coordinate z1: ");

int x2 = Input("Enter coordinate х2: ");
int y2 = Input("Enter coordinate y2: ");
int z2 = Input("Enter coordinate z1: ");

int lineX = Distance(x1, x2);
int lineY = Distance(y1, y2);
int lineZ = Distance(z1, z2);

double result = Math.Sqrt(Square(lineX) + Square(lineY) + Square(lineZ));
Console.WriteLine($"Distance between two dots = {result}");