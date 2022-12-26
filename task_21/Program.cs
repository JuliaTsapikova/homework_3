// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double GetUserValue(string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine()!);
    return(result);
}


double distance(double ax, double ay, double az, double bx,
                double by, double bz)
{
    double result = Math.Sqrt(Math.Pow((bx - ax),2) + 
    Math.Pow((by - ay), 2) + Math.Pow((bz-az), 2));
    return(result);
}


double ax = GetUserValue("Введите координаты точки а по оси х: ");
double ay = GetUserValue("Введите координаты точки а по оси у: ");
double az = GetUserValue("Введите координаты точки а по оси z: ");

double bx = GetUserValue("Введите коордитаны точки b по оси х: ");
double by = GetUserValue("Введите координаты точки b по оси у: ");
double bz = GetUserValue("Введите координаты точки b по оси z: ");

double result = distance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками а и b составляет:{Math.Round(result, 2)}");