// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = Input("Enter the value of b1: ");
double k1 = Input("Enter the value of k1: ");
double b2 = Input("Enter the value of b2: ");
double k2 = Input("Enter the value of k2: ");

double FindY(double k, double x, double b)
{
    return k * x + b; 
}

double x = (b2 - b1)/(k1 - k2);

Console.WriteLine($"x = {x}");
double y = FindY(k2, x, b2);

Console.WriteLine($"Point of intersection is A({x}; {y})");


