//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void DiffMaxMin()
{
    Console.Clear();
    Console.WriteLine("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine());
    double [] array = new double[size];
    Console.WriteLine("Введите диапозон чисел: ");
    double range = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите количество цифр после запятой, но не больше 15: ");
    int fractional = int.Parse(Console.ReadLine());

    FillArray(array, range, fractional);
    PrintArray(array);
    Console.WriteLine($"Разница между максимальным элементом {FindMax(array)} и минимальным {FindMin(array)} равна {Math.Round(FindMax(array) - FindMin(array), fractional)}");
}

double[] FillArray(double[] array, double range, int fractional)
{
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++) 
    {
        if(i % 2 == 0) array[i] = Math.Round(rand.NextDouble() * range, fractional);
        else array[i] = Math.Round(rand.NextDouble() * -range, fractional);                 //Задачи задать отрицательных вещественных чисел не было, но это чисто для себя
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + ", ");
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double maxNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(maxNumber < array[i]) maxNumber = array[i];
    }
    return maxNumber;
}

double FindMin(double[] array)
{
    double minNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(minNumber > array[i]) minNumber = array[i];
    }
    return minNumber;
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

DiffMaxMin();
MySignature();