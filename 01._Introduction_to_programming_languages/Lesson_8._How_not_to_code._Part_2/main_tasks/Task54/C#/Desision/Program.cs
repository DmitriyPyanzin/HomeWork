//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()                                                                         //Главный метод
{
    int answerNum;
    string answer;
    Console.Clear();
    Console.WriteLine("Данная программа упорядочевает построчно элементы массива как для положительных, так и для отрицательных чисел!");
    Console.WriteLine();
    Console.WriteLine("Давай создадим массив из целых чисел!");
    Console.WriteLine();
    Console.Write("Какой длины будет массив: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Какой ширины будет массив: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] matrix = new int[rows, columns];

    FillMatrix(matrix, rows, columns);
    
    do
    {
        PrintMatrix(matrix, rows, columns);
        Console.WriteLine();
        Console.WriteLine("Так как в задаче написано упорядочить по убыванию, это от большего к меньшиму, а в примере от меньшего к большиму, то я решил сделать так!)))))");
        Console.WriteLine();
        Console.Write("Если хотите от меньшего к большему то введите 'Max', если наоборот то 'Min'. Для выхода нажмите 'Ctrl+C': ");
        answer = Console.ReadLine().ToLower();
        answerNum = answer == "max" || answer == "min"? 1:0;
        if (answerNum != 1) Console.Clear(); 
    }
    while(answerNum != 1);
    
    ArregementRows(matrix, rows, columns, answer);
    PrintMatrix(matrix, rows, columns);
}
    

int[,] FillMatrix(int[,] array, int rows, int columns)                                //Метод заполнения массива
{
    Random rand = new Random();
    Console.WriteLine();
    Console.WriteLine("А теперь определим диапозон чисел");
    Console.WriteLine();
    Console.Write("От кагого числа заполнять массив: ");
    int firstNum = int.Parse(Console.ReadLine());
    Console.Write("До кагоко числа заполнять массив: ");
    int secondNum = int.Parse(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(firstNum, secondNum);
        }
    }
    return array;
}

void PrintMatrix(int[,] array, int rows, int columns)                                 //Метод вывода массива
{
    Console.WriteLine();
    Console.WriteLine("Вот такой массив получился!");
    Console.WriteLine();
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine();
    }
}

int[,] ArregementRows(int[,] array, int rows, int columns, string answer)              //Метод расстановки
{
    if (answer == "max")                                //Метод перебора по максимуму
    {
        int max;
        int maxIndexRow;
        int temp;

        for (int i = 0; i < rows; i++)
        {
            max = array[i, 0];
            maxIndexRow = 0;

            for (int count = 0; count < columns - 1; count++)
            {
                for (int j = 0; j < columns - count; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxIndexRow = j;
                    }

                }

                temp = array[i, (columns - 1 - count)];
                array[i, (columns - 1 - count)] = max;
                array[i, maxIndexRow] = temp;
                max = array[i, 0];
                maxIndexRow = 0;    
            }
            
        }
        return array;
    }   

    else                                        //Метод пузырьком по минимуму
    {
        for (int i = 0; i < rows; i++)
        {
            for (int count = 0; count < columns - count; count++)
            {
                for (int j = 0; j < columns - 1 - count; j++)
                {
                    if (array[i, j] < array[i, j + 1]) (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                }
  
            }
        }
        return array;
    }   
}

void MySignature()                                              //Метод подписи
{
    Console.WriteLine();
    Console.WriteLine("________________________");
    Console.WriteLine("the program was implemented by Dmitry Pyanzin");
    Console.WriteLine("________________________");
    Console.WriteLine();
}

Zadacha54();
MySignature();