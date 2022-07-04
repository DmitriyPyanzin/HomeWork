//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCubeNumbers(number);

void FindCubeNumbers(int num)
{
    for(int i = 1; i <= num; i++)
        Console.Write(Math.Pow(i, 3) + ", ");
}
Console.WriteLine("ВСЁ!!!");


void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
}

MySignature();