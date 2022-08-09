//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

Console.Clear();
Console.Write("Cколько денюжек Ванечка, ты хочешь положить? ");
double money = Convert.ToInt64(Console.ReadLine());
Console.Write("На сколько месяцев Ванечка, ты хочешь положить? ");
int month = Convert.ToInt32(Console.ReadLine());
Calculation(money);


void Calculation(double number)
{
    for(int i = 0; i < month; i++)
    {
        number += number * 0.015;
    }
    Console.Write("Вот сколько бабла ");
    Console.WriteLine(Math.Round(number, 2));
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
}

MySignature();