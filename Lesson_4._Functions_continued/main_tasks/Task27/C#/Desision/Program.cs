//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumNumbers()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = FindSum(num);
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
}

SumNumbers();

int FindSum(int currentNum)
{
    int sum = 0;
    while (currentNum > 0)
    {
        sum += currentNum % 10;
        currentNum /= 10;
    }
    return sum;
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

MySignature();