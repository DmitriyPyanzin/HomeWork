//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindCross()
{
    Console.Clear();
    Console.Write("Введите координаты первой точки первой примой: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты второй точки первой примой: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты первой точки второй примой: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты второй точки второй примой: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    FindXY(b1, k1, b2, k2);
}

void FindXY(double x1, double y1, double x2, double y2)
{
    double x = (x2 - x1)/(y1 - y2);
    double y = (y1 * x) + x1;

    Console.WriteLine();
    Console.WriteLine($"Точка пересечения y = {y}");
    Console.WriteLine($"Точка пересечения x = {x}");
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

FindCross();
MySignature();