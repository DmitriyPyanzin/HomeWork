//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FindColumnsAverage()
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
    FindAverage(intArray, rows, columns);
}

int[,] FillMatrix(int[,] array, int rows, int columns, int firstNum, int secondNum)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(firstNum, secondNum + 1);          
        }                                                               
    }
    return array;
}

void PrintMatrix(int[,] array, int rows, int columns)
{
    Console.WriteLine("Вот такой двумерный массив получился: ");
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]}     "); 
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] array, int rows, int columns)
{
    double sum;
    for (int i = 0; i < columns; i++)
    {
        sum = 0;
        for (int j = 0; j < rows; j++)
        {
                sum += array[j, i];     
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца равно {sum/rows}");
    }
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

FindColumnsAverage();
MySignature();