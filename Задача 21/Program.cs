// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Clear();
Console.Write("Введите X точки A: ");
double XA = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки A: ");
double YA = double.Parse(Console.ReadLine());
Console.Write("Введите Z точки A: ");
double ZA = double.Parse(Console.ReadLine());

Console.Write("Введите X точки B: ");
double XB = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
double YB = double.Parse(Console.ReadLine());
Console.Write("Введите Z точки B: ");
double ZB = double.Parse(Console.ReadLine());

double AB = Math.Round(Math.Sqrt(Math.Pow((XB - XA),2) + Math.Pow((YB - YA), 2) + Math.Pow((ZB - ZA), 2)), 3);

Console.Write($"Растояние между двумя точками = {AB}");