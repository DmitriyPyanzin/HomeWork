void OberArray()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    Console.Clear();
    int size = 8;
    int[] array = new int[size];
    array = FillArrayFunc(size);
    int[] NewArray = OrderArray(array);
    PrintArray(NewArray);
}

int[] FillArrayFunc(int size)
{
    int[] FillArray = new int[size];
    Random rand = new Random(size);
    for(int i = 0; i < FillArray.Length; i++)
    {
        FillArray[i] = rand.Next(-100, 101);
    }
    return FillArray;
}

int[] OrderArray(int[] array)
{
    int len = array.Length - 1;
    while(len > 0)
    {
        int index = 0;
        int max = Math.Abs(array[index]);
        int temp;
        int maxIndex = 0;
        while(index <= len)
        {
            if(Math.Abs(array[index]) > Math.Abs(max))
            {
                max = array[index];
                maxIndex = index;
            }
            index++;
        }
        temp = array[len];
        array[len] = max;
        array[maxIndex] = temp;
    len--;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вот он какой отсортированный массив :) ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

OberArray();
MySignature();