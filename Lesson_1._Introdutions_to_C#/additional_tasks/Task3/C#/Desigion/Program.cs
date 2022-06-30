Console.Write("Введите рост первого спортсмена: ");
double growth1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите рост второго спортсмена: ");
double growth2 = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите рост третьего спортсмена: ");
double growth3 = Convert.ToInt64(Console.ReadLine());
double max = 0, middle = 0, min = 0;

if(growth1 < growth2)
{
    middle = growth2;
    min = growth1;
}
else
{
    middle = growth1;
    min = growth2;
}
if(middle < growth3) max = growth3;
else if(growth3 < middle)
{
    max = middle;
    if(growth3 > min) middle = growth3;
    else
    {
        middle = min;
        min = growth3;
    }
}


Console.WriteLine($"Максимальный рост {max}, средний рост {middle}, маленький рост {min}");