/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

Console.WriteLine("Program for calculating a point of intersection of two straight lines.");
Console.WriteLine("First strait line: y = k1 * x + b1, second straigh line: y = k2 * x + b2.");

double[] distance = new double[2];
double k1 = GetNumber("Enter k1:");
double b1 = GetNumber("Enter b1:");
double k2 = GetNumber("Enter k2:");
double b2 = GetNumber("Enter b2:");

IntersectionOfStraightLines(k1, b1, k2, b2);

double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error. Enter correct data.");
        }
    }
    return result;
}

void IntersectionOfStraightLines(double k1, double b1, double k2, double b2)
{
    /* y = k1 * x + b1 
    y = k2 * x + b2 

    y - y = k1 * x + b1 - k2 * x - b2 =>
    k2* x -k1 * x = b1 - b2 =>
    x * (k2 - k1) = b1 - b2 =>
    x = (b1 - b2) / (k2 - k1) */
    double x = (b1 - b2) / (k2 - k1);
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("These straight lines coincide, all points of the first line are also points of the second line.");
            return;
        }
        else
        {
            Console.WriteLine("These lines are parallel, there is no intersection point.");
            return;
        }
    }
    else
    {
        double y = k2 * x + b2;
        distance[0] = x;
        distance[1] = y;
        Console.WriteLine($"These lines cross in point x = {distance[0]}, y = {distance[1]}.");
        return;
    }
}

