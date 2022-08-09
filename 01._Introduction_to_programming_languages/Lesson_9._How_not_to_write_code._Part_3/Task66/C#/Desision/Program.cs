//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66()
{
    Console.Clear();
    int sum = 0;
    Console.WriteLine("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Recursion(firstNumber, secondNumber, sum);
}

void Recursion(int num1, int num2, int sum)
{
    if (num1 > num2) return;
    sum += num1;
    num1++;
    Recursion(num1, num2, sum);
    Console.Write(num1 == num2? sum:"");
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha66();
MySignature();