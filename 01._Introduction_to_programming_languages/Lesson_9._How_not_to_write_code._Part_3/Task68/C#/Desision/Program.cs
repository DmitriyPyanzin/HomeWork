//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Zadacha68()
{
    Console.WriteLine("Эта программа вычисляет функцию Аккермана для двух неотрицательных чисел.");
    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите клавишу 'Enter'");
    Console.ReadLine();

    Console.Write("Введите первое число: ");
    int firstNum = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNum = int.Parse(Console.ReadLine());
    int akkerman = Recursion(firstNum, secondNum);

    Console.WriteLine(firstNum < 0 || secondNum < 0? "Вы ввели отрицательное(-ые) число(-а).":akkerman);
}

int Recursion(int num1, int num2)
{
    if (num1 == 0) return num2 += 1;

    else if (num1 > 0 && num2 == 0) return Recursion(num1 - 1, 1);

    else return Recursion(num1 - 1, Recursion(num1, num2 - 1));
}


void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha68();
MySignature();