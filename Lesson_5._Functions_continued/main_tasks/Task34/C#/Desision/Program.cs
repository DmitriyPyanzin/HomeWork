//Задача 34: Задайте массив заполненный случайными положительными трёхзначными  числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void EvenNumbers()
{   
    Console.Clear();
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];

    array = FillArray(array);
    PrintArray(array);
    Console.WriteLine($"Четных чисел в массиве {FindEvenNumber(array)}!");
}

int[] FillArray(int[] array)
{
    Random rand = new Random();    // У моего внутреннего перфекциониста зубы скрепят, как можно исправить, чтобы функция Random() не была выделена как ошибка?

    for(int i = 0; i < array.Length; i++) array[i] = rand.Next(100, 1000);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

int FindEvenNumber(int[] array)
{
    int i = 0;
    int count = 0;
    bool even;

    while(i < array.Length)
    {
        even = array[i] % 2 == 0;   //Конечно же данный метод проще было бы сделать через цикл for, 
        if(even)                    //но я решил попробовать, как работает перемнная bool.
        {
            count++;
        }
        i++;
    }
    return count;
}

void MySignature()
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

EvenNumbers();
MySignature();