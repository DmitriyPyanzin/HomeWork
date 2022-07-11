//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FindSum()
{
    Console.Clear();
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];

    array = FillArray(array);
    PrintArray(array);
    Console.WriteLine($"Сумма нечетных элементов массива равна {SumIndexOddArray(array)}");
}

int[] FillArray(int[] array)
{
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++) array[i] = rand.Next(-100, 101);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

int SumIndexOddArray(int[] array)
{
    int index = 0;
    int sum = 0;
    while(index < array.Length)
    {
        if(TrueSum(index)) 
        {
            sum += array[index];
        }
        index++;
    }
    return sum;
}

bool TrueSum(int index)         //Вот тут я решил попробовать создать bool метод
{
    return index % 2 == 1; 
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

FindSum();
MySignature();