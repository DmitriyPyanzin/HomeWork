Console.WriteLine("Введите длинну первой стороны:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну второй стороны:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну третьей стороны:");
int num3 = Convert.ToInt32(Console.ReadLine());
TriangleViev(num1, num2, num3);

void TriangleViev(int x1, int x2, int x3)
{
    if(x1 == x2 && x1 == x3 && x2 == x3) Console.WriteLine("Треугольник равносторонний!");
    else if(x1 == x2 || x1 == x3 || x2 == x3) 
        Console.WriteLine("Треугольник равнобедренный!");
    else Console.WriteLine("Треугольник не равнобедренный");
}