/*Задача 4. Дано натуральное число, в котором все цифры различны. 
Определить, какая цифра расположена в нем левее: максимальная или 
минимальная.*/

Console.Clear();
Console.Write("Введите натуральное число состоящее из различных цифр: ");
string num = Console.ReadLine();

FindMaxMin(num);

void FindMaxMin(string num)
{
    int max = num[0];
    int min = num[0];
    int maxindex = 0;
    int minindex = 0;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] > max)
        {
            max = num[i];
            maxindex = i;
        }
        else if(num[i] < min)
        {
            min = num[i];
            minindex = i;
        }
    }
    if(maxindex < minindex) Console.WriteLine($"Максимальное число {num[maxindex]} расположенно левее минимального числа {num[minindex]}");
    else Console.WriteLine($"Максимальное число {num[maxindex]} расположенно правее минимального числа {num[minindex]}");
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
}

MySignature();