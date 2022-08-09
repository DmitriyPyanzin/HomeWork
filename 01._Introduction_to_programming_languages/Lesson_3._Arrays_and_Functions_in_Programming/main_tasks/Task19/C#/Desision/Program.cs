//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

FindPolindrom(number);

void FindPolindrom (int num)
{
    int len = Convert.ToString(Math.Abs(num)).Length;
    if(len != 5) Console.WriteLine("Нужно было ввести пятизначное число");
    else
    {
        if(num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
            Console.WriteLine($"Число {num} является полиндромом");
        else Console.WriteLine($"Число {num} ни разу не полиндром");
    }
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
}

MySignature();