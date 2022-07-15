//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void Matrix()
{
    Console.Clear();
    Console.WriteLine("Для построения матрицы необходимо ввести:");
    Console.WriteLine();
    Console.Write("Количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Диапозон чисел будет от 0 до ");
    Console.Write("Введите число: ");
    int range = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Сколько чисел после запятой оставить? ");
    Console.Write("Введите число: ");
    int desimal = int.Parse(Console.ReadLine());
    Console.WriteLine();
    double[,] doubleArray = new double[rows, columns];
    FillMatrix(doubleArray, rows, columns, range, desimal);
    PrintMatrix(doubleArray, rows, columns);
}

double [,] FillMatrix(double[,] array, int rows, int columns, int range, int desimal)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * range, desimal);
        }
    }
    return array;
}

void PrintMatrix(double[,] array, int rows, int columns)
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

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Matrix();
MySignature();