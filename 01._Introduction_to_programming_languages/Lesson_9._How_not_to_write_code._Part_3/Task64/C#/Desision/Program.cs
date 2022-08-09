//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

void Zadacha64()
{
    Console.Clear();
    Console.WriteLine("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Recursion(firstNumber, secondNumber);
}

void Recursion(int num1, int num2)
{
    if (num1 >= num2) return;
    Console.Write(num1 % 3 == 0? num1:" ");
    num1++;
    Recursion(num1, num2);
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha64();
MySignature();