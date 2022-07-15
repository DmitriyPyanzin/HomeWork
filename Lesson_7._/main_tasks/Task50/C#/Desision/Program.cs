//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindNumInMatrix()
{
    Console.Clear();
    Console.WriteLine("Для построения матрицы необходимо ввести:");
    Console.WriteLine();
    Console.Write("Количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Какой диапозон чисел задать? ");
    Console.Write("Введите число начала диапозона: ");
    int firstNum = int.Parse(Console.ReadLine());
    Console.Write("Введите число окончания диапозона: ");
    int secondNum = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] intArray = new int[rows, columns];
    FillMatrix(intArray, rows, columns, firstNum, secondNum);
    PrintMatrix(intArray, rows, columns);
    Console.WriteLine();
    Console.WriteLine("Ну так как теперь вам, Денис, виден двумерный массив, просто для проверки введите необходимое число. Удобно? По моему очень ;)))) ");
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine();
    FindNum(intArray, rows, columns, number);
}

int[,] FillMatrix(int[,] array, int rows, int columns, int firstNum, int secondNum)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(firstNum, secondNum + 1);           //Если бы эта программа была для обычного пользователя, то при вводе диапозона он скорее всего считал бы включительно это число. 
        }                                                               //и поэтому secondNum + 1
    }
    return array;
}

void PrintMatrix(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]}     "); 
        }
        Console.WriteLine();
    }
}

void FindNum(int[, ]intArray, int rows, int columns, int number)
{
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (intArray[i, j] == number)  count += 1;                     //В задаче не требовалось и можно было сделать через breake и bool flag = false
        }
    }
    Console.WriteLine(count == 0? "Искомого числа в массиве нет":$"Данное число {number} встречается в массиве {count} раз!");
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

FindNumInMatrix();
MySignature();