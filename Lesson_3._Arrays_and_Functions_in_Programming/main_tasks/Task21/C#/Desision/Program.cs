//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
FindDistance(x1, y1, z1, x2, y2, z2);

void FindDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    
    double A = Math.Pow(xb - xa, 2);
    double B = Math.Pow(yb - ya, 2);
    double C = Math.Pow(zb - za, 2);
    Console.WriteLine($"Длина отрезка {Math.Sqrt(A + B + C)}");
}


void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
}

MySignature();